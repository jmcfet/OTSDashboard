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
    
    public partial class SBPaymentHolds1
    {
        public int PaymentID { get; set; }
        public int StoreID { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public int StationID { get; set; }
        public int ClerkDrawerID { get; set; }
        public Nullable<System.DateTime> PayDate { get; set; }
        public string CheckNo { get; set; }
        public string CardNo { get; set; }
        public string CardExp { get; set; }
        public decimal CashAmount { get; set; }
        public decimal CheckAmount { get; set; }
        public decimal CardAmount { get; set; }
        public decimal TenderAmount { get; set; }
        public decimal ChangeAmount { get; set; }
        public int DrawerNumber { get; set; }
        public bool Deleted { get; set; }
        public string CardAuthNo { get; set; }
        public bool IsDebitCard { get; set; }
        public string CardTroutD { get; set; }
        public decimal GiftAmount { get; set; }
        public string GiftNo { get; set; }
        public string GiftAuthNo { get; set; }
        public string GiftTroutD { get; set; }
        public string CardMasked { get; set; }
        public string CardToken { get; set; }
        public string EcBlock { get; set; }
        public string EcKey { get; set; }
        public bool EcSwiped { get; set; }
        public int CCKeyID { get; set; }
        public Nullable<System.DateTime> ResetDate { get; set; }
        public int AccountType { get; set; }
    }
}
