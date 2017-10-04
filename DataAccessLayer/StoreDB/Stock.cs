namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Stock")]
    public partial class Stock
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MerchandiseID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SortBy { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TaxAuthorityID { get; set; }

        [StringLength(80)]
        public string Description { get; set; }

        [StringLength(30)]
        public string SKU { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "money")]
        public decimal Price { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "money")]
        public decimal Cost { get; set; }

        [Key]
        [Column(Order = 6)]
        public float ReorderPoint { get; set; }

        [Key]
        [Column(Order = 7)]
        public float OnHand { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GiftClassID { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool IsDiscountable { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool Deleted { get; set; }
    }
}
