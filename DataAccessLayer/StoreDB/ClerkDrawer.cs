namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClerkDrawer
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ClerkDrawerID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StationID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreID { get; set; }

        [StringLength(25)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CloseEmpID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OpenEmpID { get; set; }

        public DateTime? Opened { get; set; }

        public DateTime? Closed { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "money")]
        public decimal StartingCash { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "money")]
        public decimal Cash { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal Checks { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "money")]
        public decimal Cards { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "money")]
        public decimal Coupons { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "money")]
        public decimal CountedCash { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "money")]
        public decimal CountedChecks { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "money")]
        public decimal CountedCards { get; set; }

        [Key]
        [Column(Order = 13, TypeName = "money")]
        public decimal CountedCoupons { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DrawerNumber { get; set; }

        [Key]
        [Column(Order = 15, TypeName = "money")]
        public decimal RemovedCash { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OwnerEmpID { get; set; }

        [Key]
        [Column(Order = 17)]
        public bool IsPhysicalDrawer { get; set; }

        [Key]
        [Column(Order = 18, TypeName = "money")]
        public decimal CashCount0 { get; set; }

        [Key]
        [Column(Order = 19, TypeName = "money")]
        public decimal CashCount1 { get; set; }

        [Key]
        [Column(Order = 20, TypeName = "money")]
        public decimal CashCount2 { get; set; }

        [Key]
        [Column(Order = 21, TypeName = "money")]
        public decimal CashCount3 { get; set; }

        [Key]
        [Column(Order = 22, TypeName = "money")]
        public decimal CashCount4 { get; set; }

        [Key]
        [Column(Order = 23, TypeName = "money")]
        public decimal CashCount5 { get; set; }

        [Key]
        [Column(Order = 24, TypeName = "money")]
        public decimal CashCount6 { get; set; }

        [Key]
        [Column(Order = 25, TypeName = "money")]
        public decimal CashCount7 { get; set; }

        [Key]
        [Column(Order = 26, TypeName = "money")]
        public decimal CashCount8 { get; set; }

        [Key]
        [Column(Order = 27, TypeName = "money")]
        public decimal CashCount9 { get; set; }

        [Key]
        [Column(Order = 28, TypeName = "money")]
        public decimal CashCount10 { get; set; }

        [Key]
        [Column(Order = 29, TypeName = "money")]
        public decimal CashCount11 { get; set; }

        [Key]
        [Column(Order = 30, TypeName = "money")]
        public decimal CashCount12 { get; set; }

        [Key]
        [Column(Order = 31, TypeName = "money")]
        public decimal CashCount13 { get; set; }

        [Key]
        [Column(Order = 32, TypeName = "money")]
        public decimal CashCount14 { get; set; }

        [Key]
        [Column(Order = 33, TypeName = "money")]
        public decimal CashCount15 { get; set; }

        [Key]
        [Column(Order = 34, TypeName = "money")]
        public decimal CashCount16 { get; set; }

        [Key]
        [Column(Order = 35, TypeName = "money")]
        public decimal Gift { get; set; }

        [Key]
        [Column(Order = 36, TypeName = "money")]
        public decimal CountedGift { get; set; }
    }
}
