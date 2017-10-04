namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Inventory
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreID { get; set; }

        public DateTime? InventoryDate { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "money")]
        public decimal CSTotalInv { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "money")]
        public decimal STTotalInv { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "money")]
        public decimal ISTotalInv { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "money")]
        public decimal BOTotalInv { get; set; }

        [Key]
        [Column(Order = 5)]
        public float CSPcsInv { get; set; }

        [Key]
        [Column(Order = 6)]
        public float STPcsInv { get; set; }

        [Key]
        [Column(Order = 7)]
        public float ISPcsInv { get; set; }

        [Key]
        [Column(Order = 8)]
        public float BOPcsInv { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "money")]
        public decimal CSTotalAR { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "money")]
        public decimal STTotalAR { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "money")]
        public decimal ISTotalAR { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "money")]
        public decimal BOTotalAR { get; set; }

        [Key]
        [Column(Order = 13)]
        public float CSPcsAR { get; set; }

        [Key]
        [Column(Order = 14)]
        public float STPcsAR { get; set; }

        [Key]
        [Column(Order = 15)]
        public float ISPcsAR { get; set; }

        [Key]
        [Column(Order = 16)]
        public float BOPcsAR { get; set; }
    }
}
