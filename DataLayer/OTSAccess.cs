

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
//using OnTheSpot.EFStuff;
using System.Diagnostics;
using NLog;

namespace OnTheSpot.Dal
{
    public class DBAccess
    {
   //     Entities db = new Entities();
        Logger logger = LogManager.GetLogger("OnTheSpot");
        Store1Entities dbOTS;

        public DBAccess(string connectionstring)
        {
            dbOTS = new Store1Entities(connectionstring);
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

