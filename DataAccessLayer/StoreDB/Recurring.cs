namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Recurring
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RecurringID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SortBy { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GLAccountID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AccountTypeID { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool IsDiscount { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool IsPercentOff { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal MinimumBalance { get; set; }

        [Key]
        [Column(Order = 8)]
        public float PercentOff { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "money")]
        public decimal DollarsOff { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TaxAuthorityID { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(80)]
        public string PrintDescription { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool Deleted { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool SalesTaxExcluded { get; set; }

        [Key]
        [Column(Order = 13)]
        public bool IssueBelowMinBal { get; set; }
    }
}
