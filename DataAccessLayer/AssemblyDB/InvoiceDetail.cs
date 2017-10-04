namespace DataAccessLayer.AssemblyDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvoiceDetail")]
    public partial class InvoiceDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvoiceID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GarmentID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DetailType { get; set; }

        [StringLength(104)]
        public string DetailDesc { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Quantity { get; set; }

        [Key]
        [Column(Order = 6)]
        public float Pieces { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal Amount { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool Deleted { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvDetailID { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool Voided { get; set; }

        [Key]
        [Column(Order = 11)]
        public float AssemblyPieces { get; set; }

        [StringLength(20)]
        public string ArticleCode { get; set; }

        [StringLength(200)]
        public string FlagTag { get; set; }

        [StringLength(32)]
        public string DetailGuid { get; set; }
    }
}
