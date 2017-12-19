using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class CustomerInfo
    {
        public string storeName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string rack { get; set; }
        public int invoiceID { get; set; }
        public string baggermemo { get; set; }
        public string invmemo { get; set; }
    }
}
