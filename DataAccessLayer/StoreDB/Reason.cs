namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reason
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReasonID { get; set; }

        [StringLength(80)]
        public string Description { get; set; }

        public int? ReasonType { get; set; }

        public DateTime? AddDate { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool Deleted { get; set; }
    }
}
