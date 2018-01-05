namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPR")]
    public partial class CPR
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string store { get; set; }

        public int invoiceid { get; set; }

        public int state { get; set; }

        [StringLength(50)]
        public string employeeID { get; set; }

        public DateTime? time { get; set; }

        [StringLength(50)]
        public string spare3 { get; set; }
    }
}
