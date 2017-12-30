﻿
using DataAccessLayer.Models;
using DataAccessLayer.StoreDB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class OTSAccess
    {

        StoreContext dbOTS, db1OTS, db2OTS, db3OTS, db4OTS;
        BCSContext dbBCS = new BCSContext();
        //Unfortunately, you can only have one app.config file per executable, so if you have DLL’s linked into your application,
        //they cannot have their own app.config files.
        //  Solution is: You don't need to put the App.config file in the Class Library's project.
        //You put the App.config file in the application that is referencing your class library's dll.
        //there is a nasty situation in the OTS schema in that the Invoice table appears in both
        //the Assembly and the individual store databases and this causes grieve with the entity framework
        //database first approach. The solution was to switch to code first .

        public OTSAccess()
        {

        }

        public Employee GetEmployee(int empid)
        {
            Employee emp = null;
            string error = string.Empty;
            try
            {
                emp = dbOTS.Employees.Where(e2 => e2.EmployeeID == empid).SingleOrDefault();
            }
            catch (Exception e)
            {
                error = "Critical Error: Could not open Categories DataBase";
            }

            return new Employee()
            {

                FirstName = emp.FirstName,
                LastName = emp.LastName
            };
        }
        public ObservableCollection<Category> GetCats(out string error)
        {
            ObservableCollection<Category> modelCats = null;
            error = string.Empty;
            try
            {
                List<Category> dbCats = dbBCS.Categories.ToList();

                modelCats = new ObservableCollection<Category>();
                foreach (Category cat in dbCats)
                {
                    Category model = new Category()
                    {
                        ID = cat.ID,
                        Description = cat.Description,
                        Name = cat.Name
                    };
                    modelCats.Add(model);
                }
            }
            catch (Exception e)
            {
                error = "Critical Error: Could not open Categories DataBase";
            }

            return modelCats;
        }
        public List<Models.Appointment> GetAppointments(out string error)
        {
            error = string.Empty;
            List<Models.Appointment> modelAppts = new List<Models.Appointment>();
            try
            {
                List<Appointment> dbAppts = dbBCS.Appointments.ToList();


                foreach (Appointment appt in dbAppts)
                {
                    Models.Appointment model = new Models.Appointment()
                    {
                        //               ID = appt.ID,
                        Body = appt.Body,
                        EndTime = (DateTime)appt.EndTime,
                        Location = appt.Location,
                        StartTime = (DateTime)appt.StartTime,
                        Subject = appt.Subject

                    };
                    modelAppts.Add(model);
                }
            }
            catch (Exception e)
            {
                error = "Critical Error: Could not open Categories DataBase";
            }

            return modelAppts;
        }
        public void SaveAppts(Models.Appointment appt)
        {
            Appointment apptdb = new Appointment()
            {
                Body = appt.Body,
                EndTime = appt.EndTime,
                Location = appt.Location,
                StartTime = appt.StartTime,
                Subject = appt.Subject
            };
            dbBCS.Appointments.Add(apptdb);
            try
            {
                dbBCS.SaveChanges();
            }
            catch (Exception e)
            {

            }

        }
        public ObservableCollection<CustomerInfo> GetInvoices(string storeName)
        {

            var q1 = from inv in dbOTS.Invoices
                     where inv.BaggerMemo != null && inv.PickupDate == null && inv.Rack != null && inv.Rack.ToLower() != "bagged"
                     && inv.InvoiceID != 40002098 && inv.InvoiceID != 40002099
                     join cust in dbOTS.Customers on inv.CustomerID equals cust.CustomerID
                     select new CustomerInfo() { FirstName = cust.FirstName, LastName = cust.LastName, rack = inv.Rack, invoiceID = inv.InvoiceID, invmemo = cust.InvReminder, baggermemo = inv.BaggerMemo };

            var ordersGroup = from cust in dbOTS.Customers
                     where cust.InvReminder != null
                     join invoice in dbOTS.Invoices on cust.CustomerID equals invoice.CustomerID
                     where invoice.PickupDate == null && invoice.Rack != null && invoice.Rack.ToLower() != "bagged"
                     select new CustomerInfo() { FirstName = cust.FirstName, LastName = cust.LastName, rack = invoice.Rack, invoiceID = invoice.InvoiceID, invmemo = cust.InvReminder, baggermemo = invoice.BaggerMemo };

            //     string test = ((ObjectQuery)ordersGroup).ToTraceString();

            List<CustomerInfo> invinfo = q1.Union(ordersGroup).ToList();   //remove duplicates

            //now get all the processed invoices that passed
            List<int> processed = (from c in dbBCS.CPRs
                                   where c.state == 1 && c.store == storeName
                                   select c.invoiceid).ToList();
            //if invoice was processed then remove
            invinfo = (from inv in invinfo
                       where !processed.Contains(inv.invoiceID)
                       orderby inv.rack
                       select inv).ToList();

            return new ObservableCollection<CustomerInfo>(invinfo);

        }
        public List<CustomerInfo> getCPRCounts()
        {
            ConnectionStringSettingsCollection connections = ConfigurationManager.ConnectionStrings;
            string StoreConnectionString = connections["StoreContext"].ConnectionString;

            db1OTS = new StoreContext();

            db2OTS = new StoreContext(connections["Store2Context"].ConnectionString);
            db3OTS = new StoreContext(connections["Store3Context"].ConnectionString);
            db4OTS = new StoreContext(connections["Store4Context"].ConnectionString);
            List<string> storeNames = new List<string>() { "Haile", "Millhopper", "Westgate", "HuntersCrossing" };
            List<CustomerInfo> storecounts = new List<CustomerInfo>();

            for (int storeid = 0; storeid < 4; storeid++)
            {
                dbOTS = db1OTS;
                switch (storeid)
                {
                    case 1:
                        dbOTS = db2OTS;
                        break;
                    case 2:
                        dbOTS = db3OTS;
                        break;
                    case 3:
                        dbOTS = db4OTS;
                        break;
                }

                List<CustomerInfo> info = FindInvoicesToCheck(storeNames[storeid]);
                //       CPRCounts counts = new CPRCounts() { count = count1, Store = storeNames[storeid] };
                storecounts.AddRange(info);



            }
            return storecounts;
        }

        public List<missingPieceInfo> FindMissingOrders(string storeName)
        {
            DataAccessLayer.AssemblyDB.Assembly assembly = new DataAccessLayer.AssemblyDB.Assembly();
            ConnectionStringSettingsCollection connections = ConfigurationManager.ConnectionStrings;
            string StoreConnectionString = connections["StoreContext"].ConnectionString;

            db1OTS = new StoreContext(StoreConnectionString);
            //      List<Invoice> invs = assembly.Invoices.Take(10).ToList();
            StoreConnectionString = connections["Store2Context"].ConnectionString;
            db2OTS = new StoreContext(StoreConnectionString);
            StoreConnectionString = connections["Store3Context"].ConnectionString;
            db3OTS = new StoreContext(StoreConnectionString);
            StoreConnectionString = connections["Store4Context"].ConnectionString;
            db4OTS = new StoreContext(StoreConnectionString);

            List<missingPieceInfo> miss = new List<missingPieceInfo>();
            List<missingPieceInfo> missFilteredbyCustomerid = new List<missingPieceInfo>();
            
            //get all invoices for the last day
            List<DataAccessLayer.AssemblyDB.Invoice> allInvoices = (from inv in assembly.Invoices
                                                                    where DbFunctions.TruncateTime(inv.MarkInDate) >= DateTime.Today
                                                                    select inv).ToList();

           //group these by orderid
             var invsGroupedByOrderID  = from inv2 in allInvoices
                                                group inv2 by inv2.OrderID into groupedinvs
                                                select groupedinvs;
            //Invoices are now grouped by orderid so at look at each group of invoices 
            foreach (var AssemblyInvGroup in invsGroupedByOrderID)
            {
                int storeid = AssemblyInvGroup.First().StoreID;
                dbOTS = db1OTS;
                switch (storeid)
                {
                    case 2:
                        dbOTS = db2OTS;
                        break;
                    case 3:
                        dbOTS = db3OTS;
                        break;
                    case 4:
                        dbOTS = db4OTS;
                        break;
                }
               //find all the orderdetail objects with this orderid and group by orderid
                var ordersGroup = from order in dbOTS.OrderDetails
                         where AssemblyInvGroup.Key == order.OrderID
                         group order by order.OrderID into groupedby
                         select groupedby;

                if (ordersGroup.Count() > 0)
                {
                    
                    foreach (var orderDetailGroup in ordersGroup)
                    {
                       
                        int piecesInOrderDetails = (int)orderDetailGroup.Sum(o => o.Pieces);
                        OrderDetail orderDetail = orderDetailGroup.First();
                        List<AssemblyDB.AutoSort> inAutoPieces = (from auto in assembly.AutoSorts
                                                             where auto.CustomerID == orderDetail.CustomerID
                                                             &&  DbFunctions.TruncateTime(auto.InvoiceDate) >= DateTime.Today
                                                             group auto by auto.ArticleCode  into groupbyarticle
                                                              select groupbyarticle.FirstOrDefault()).ToList();
                      
                        //ignore number pieces mismatch if the item not marked in
                        if (piecesInOrderDetails != inAutoPieces.Count && inAutoPieces.Count > 0)
                        {
                            missingPieceInfo info = new missingPieceInfo()
                            {
                                orderid = AssemblyInvGroup.Key,   
                                numInvoiced = inAutoPieces.Count.ToString(),
                                numOrders = piecesInOrderDetails,
                                storeid = orderDetail.StoreID,
                                customerid = orderDetail.CustomerID,
                                date = orderDetail.DueDate.ToString()
                            };
                          
                            miss.Add(info);


                        }
                    }
                    

                }
            }
            //we have the possible mismatches between orderdetails pieces and autosort now group by customerid. there 
            //might be multiple mismatches for same customer in which case we need to look at group as a whole
            //
            var groupedbyCust = miss.GroupBy(g => g.customerid).ToList();
            foreach (var missGroup in groupedbyCust)
            {
                //these customer might have multiple orders 
                if (missGroup.Count() > 1)
                {
                    if ((int)missGroup.Sum(o => o.numOrders) != Int32.Parse(missGroup.First().numInvoiced))
                    {
                        missGroup.First().numInvoiced = string.Format("Mult work orders {0}", missGroup.First().numInvoiced);
                        missFilteredbyCustomerid.Add(missGroup.First());
                    }
                }
                else
                    missFilteredbyCustomerid.Add(missGroup.First());
            }

            return missFilteredbyCustomerid.OrderBy(o => o.storeid).ToList(); ;
        }

        private List<CustomerInfo> FindInvoicesToCheck(string storeName)
        {
            var q1 = from inv in dbOTS.Invoices
                     where inv.BaggerMemo != null && inv.PickupDate == null && inv.Rack != null && inv.Rack.ToLower() != "bagged"
                     from cust in dbOTS.Customers
                     where inv.CustomerID == cust.CustomerID
                     select new CustomerInfo() { storeName = storeName, FirstName = cust.FirstName, LastName = cust.LastName, rack = inv.Rack, invoiceID = inv.InvoiceID, invmemo = cust.InvReminder, baggermemo = inv.BaggerMemo };

            List<CustomerInfo> invinfo = q1.ToList();

            //now get all the processed invoices that passed
            List<int> processed = (from c in dbBCS.CPRs
                                   where c.state == 1 && c.store == storeName
                                   select c.invoiceid).ToList();
            List<int> invPaided = (from i in dbOTS.InvPaids
                                   select i.InvoiceID).ToList();
            //if invoice was processed then remove
            invinfo = (from inv in invinfo
                       where !processed.Contains(inv.invoiceID)
                       orderby inv.rack
                       select inv).ToList();

            return invinfo;

        }
        // find orders lost on the conveyor due to a missing rack location.
        public List<OrdersLostOnRacktoMissingRackLocationData> OrdersLostOnRacktoMissingRackLocation()
        {
            StoreContext[] connectStrings = new StoreContext[4];
            ConnectionStringSettingsCollection connections = ConfigurationManager.ConnectionStrings;
            string StoreConnectionString = connections["StoreContext"].ConnectionString;
            StoreContext CurrentContext = null; 
            connectStrings[0] = new StoreContext(StoreConnectionString);
            //      List<Invoice> invs = assembly.Invoices.Take(10).ToList();
            StoreConnectionString = connections["Store2Context"].ConnectionString;
            connectStrings[1] = new StoreContext(StoreConnectionString);
            StoreConnectionString = connections["Store3Context"].ConnectionString;
            connectStrings[2] = new StoreContext(StoreConnectionString);
            StoreConnectionString = connections["Store4Context"].ConnectionString;
            connectStrings[3] = new StoreContext(StoreConnectionString);
            List<OrdersLostOnRacktoMissingRackLocationData> ListData = new List<OrdersLostOnRacktoMissingRackLocationData>();
            for (int i = 0; i < 4; i++)
            {
                CurrentContext = connectStrings[i];
                DateTime prev = DateTime.Today.AddDays(-7).Date;
                var invs = from inv in CurrentContext.Invoices
                           where DbFunctions.TruncateTime(inv.DueDate) >= prev.Date
                           && inv.Rack == null && inv.DepartmentID != 5 && inv.PaidAmount == 0
                           select inv;
               
                foreach(Invoice inv in invs)
                {
                   
                   
                    OrdersLostOnRacktoMissingRackLocationData data = new OrdersLostOnRacktoMissingRackLocationData()
                    {
                        dueDate = inv.DueDate,
                        invoiceID = inv.InvoiceID,
                        storeID = i
                    };
                    ListData.Add(data);

                }
           
            }
            return ListData.OrderBy(o=>o.storeID).ToList();
        }
        public List<ShirtInfo> getItemCount(string type)
        {
            DataAccessLayer.AssemblyDB.Assembly assembly = new DataAccessLayer.AssemblyDB.Assembly();
            List<int> ids = (from cat in dbBCS.Categories
                             where cat.Name == type
                             join fab in dbBCS.OTISIdsToFabIds on cat.ID equals fab.CatID
                             select fab.FabID).ToList();

            var q1 = from inv in assembly.InvoiceDetails
                     where ids.Contains(inv.GarmentID)
                     join auto in assembly.AutoSorts on inv.ArticleCode equals auto.ArticleCode
                     where DbFunctions.TruncateTime(auto.DueDate) == DateTime.Today
                     select new ShirtInfo { articleID = inv.ArticleCode, invoiceID = inv.InvoiceID, dueDate = auto.DueDate };

           
            return q1.ToList();

        }
        public List<GarmentIds> getTypes()
        {


            DataAccessLayer.AssemblyDB.Assembly assembly = new DataAccessLayer.AssemblyDB.Assembly();
            assembly.Database.Log = Console.Write;
            List<DataAccessLayer.AssemblyDB.InvoiceDetail> distinctPeople = assembly.InvoiceDetails
.GroupBy(p => p.GarmentID)
.Select(g => g.FirstOrDefault())
.ToList();
            List<GarmentIds> gids = new List<GarmentIds>();
            foreach (DataAccessLayer.AssemblyDB.InvoiceDetail inv in distinctPeople)
            {
                GarmentIds g1 = new GarmentIds() { garmentID = inv.GarmentID, desc = inv.DetailDesc };
                gids.Add(g1);
            }

            return gids;
        }
        public void SaveFabIdtoCatId(List<OTISIdsToFabId> objs)
        {
            
            dbBCS.OTISIdsToFabIds.AddRange(objs);
            dbBCS.SaveChanges();
        }
    }
    
    
    
    
    
   
}
