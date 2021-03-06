namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BillCyclePeriod
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BillCycleID { get; set; }

        public DateTime? CutoffDate { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool Deleted { get; set; }
    }
}
