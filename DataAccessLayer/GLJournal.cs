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
    
    public partial class GLJournal
    {
        public int StoreID { get; set; }
        public int GLAccountID { get; set; }
        public int GLTransType { get; set; }
        public decimal Amount { get; set; }
        public int Pieces { get; set; }
        public Nullable<System.DateTime> TransDate { get; set; }
        public bool Deleted { get; set; }
    }
}
