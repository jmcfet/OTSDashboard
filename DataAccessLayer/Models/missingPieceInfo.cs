using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class missingPieceInfo
    {
        public int orderid { get; set; }
        public string numInvoiced { get; set; }
        public int numOrders { get; set; }
        public int storeid { get; set; }
        public string date { get; set; }
        public int customerid { get; set; }
        public string articleCode { get; set; }
    }
}
