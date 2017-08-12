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
    
    public partial class Credit
    {
        public int CreditID { get; set; }
        public int StoreID { get; set; }
        public int CreditTypeID { get; set; }
        public int CustomerID { get; set; }
        public int AddedEmpID { get; set; }
        public int AppliedEmpID { get; set; }
        public int PaymentID { get; set; }
        public Nullable<System.DateTime> CreditDate { get; set; }
        public Nullable<System.DateTime> AppliedDate { get; set; }
        public string Description { get; set; }
        public decimal Total { get; set; }
        public decimal PaidAmount { get; set; }
        public bool Deleted { get; set; }
        public string CardMasked { get; set; }
        public string CardAuthNo { get; set; }
        public int AutoCreditID { get; set; }
    }
}
