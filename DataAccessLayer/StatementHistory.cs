//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class StatementHistory
    {
        public int StatementID { get; set; }
        public int StoreID { get; set; }
        public int BillCycleID { get; set; }
        public int BillCenterID { get; set; }
        public int CustomerID { get; set; }
        public int TransID { get; set; }
        public int TransType { get; set; }
        public Nullable<System.DateTime> TransDate { get; set; }
        public string TransDescription { get; set; }
        public float TransPieces { get; set; }
        public decimal TransAmount { get; set; }
        public bool Deleted { get; set; }
    }
}
