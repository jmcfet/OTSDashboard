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
    
    public partial class CCAudit
    {
        public int AuditID { get; set; }
        public int StoreID { get; set; }
        public int EmployeeID { get; set; }
        public int StationID { get; set; }
        public string UserName { get; set; }
        public Nullable<System.DateTime> LogDateTime { get; set; }
        public string EventType { get; set; }
        public string EventOrigination { get; set; }
        public string DataResource { get; set; }
        public string Result { get; set; }
    }
}
