namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TimeCard
    {
        public int? StoreID { get; set; }

        public int? EmployeeID { get; set; }

        public DateTime? ClockIn { get; set; }

        public DateTime? Clockout { get; set; }

        [StringLength(1)]
        public string WorkType { get; set; }

        [Key]
        [Column(Order = 0)]
        public bool Deleted { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TimeCardID { get; set; }

        [StringLength(20)]
        public string AccountNumber { get; set; }
    }
}
