namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NoSale
    {
        public int? NoSaleID { get; set; }

        public int? StoreID { get; set; }

        public int? NoSaleTypeID { get; set; }

        public int? EmployeeID { get; set; }

        public int? ClerkDrawerID { get; set; }

        public DateTime? NoSaleDate { get; set; }

        [StringLength(80)]
        public string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal? Total { get; set; }

        public int? DrawerNumber { get; set; }

        [Key]
        [Column(Order = 0)]
        public bool Deleted { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AccountType { get; set; }

        [StringLength(25)]
        public string CardMasked { get; set; }

        [StringLength(16)]
        public string AuthNo { get; set; }
    }
}
