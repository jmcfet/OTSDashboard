namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClockInAccount
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AccountID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SortBy { get; set; }

        [StringLength(20)]
        public string AccountNumber { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool Enabled { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool Deleted { get; set; }
    }
}
