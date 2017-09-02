using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data
{
    public class Repository
    {
        public static List<Appointment> Events = new List<Appointment>()
        {
            new Appointment() { Subject = "Dummy Appointment #1", StartTime = new DateTime(2017, 9, 2, 10, 00, 00), EndTime = new DateTime(2017, 9, 2, 12, 00, 00) },
            new Appointment() { Subject = "Dummy Appointment #2", StartTime = new DateTime(2017, 8, 31, 10, 00, 00), EndTime = new DateTime(2017, 8, 31, 11, 00, 00) },
            new Appointment() { Subject = "Dummy Appointment #3", StartTime = new DateTime(2017, 10, 22, 11, 30, 00), EndTime = new DateTime(2008, 10, 22, 12, 00, 00) }
        
        };
    }
}
