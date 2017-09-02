using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class OTSAccess
    {
        Store1Entities dbOTS;
        BCSEntities dbBCS = new BCSEntities();
        public OTSAccess()
        {

        }
        public OTSAccess(string store)
        {
  
            dbOTS = new Store1Entities(store);
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
        public ObservableCollection<CustomerInfo> GetInvoices(string storeName)
        {

            var q1 = from inv in dbOTS.Invoices
                     where inv.BaggerMemo != null && inv.PickupDate == null && inv.Rack != null && inv.Rack.ToLower() != "bagged"
                     && inv.InvoiceID != 40002098 && inv.InvoiceID != 40002099
                     join cust in dbOTS.Customers on inv.CustomerID equals cust.CustomerID
                     select new CustomerInfo() { FirstName = cust.FirstName, LastName = cust.LastName, rack = inv.Rack, invoiceID = inv.InvoiceID, invmemo = cust.InvReminder, baggermemo = inv.BaggerMemo };

            var q2 = from cust in dbOTS.Customers
                     where cust.InvReminder != null
                     join invoice in dbOTS.Invoices on cust.CustomerID equals invoice.CustomerID
                     where invoice.PickupDate == null && invoice.Rack != null && invoice.Rack.ToLower() != "bagged"
                     select new CustomerInfo() { FirstName = cust.FirstName, LastName = cust.LastName, rack = invoice.Rack, invoiceID = invoice.InvoiceID, invmemo = cust.InvReminder, baggermemo = invoice.BaggerMemo };

            //     string test = ((ObjectQuery)q2).ToTraceString();

            List<CustomerInfo> invinfo = q1.Union(q2).ToList();   //remove duplicates

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

    }
    public class CustomerInfo
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string rack { get; set; }
        public int invoiceID { get; set; }
        public string baggermemo { get; set; }
        public string invmemo { get; set; }
    }
}
