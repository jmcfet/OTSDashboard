namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OverdueStat
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OverdueID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OverdueCleanID { get; set; }

        public DateTime? OverdueDate { get; set; }

        [Key]
        [Column(Order = 3)]
        public float OverduePieces { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "money")]
        public decimal OverdueAmount { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool Deleted { get; set; }
    }
}
