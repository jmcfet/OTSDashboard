namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Original
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreID { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool OrigInvoice { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvoiceID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepartmentID { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeID { get; set; }

        [StringLength(20)]
        public string Department { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public DateTime? AdjustDate { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool Voided { get; set; }

        [Key]
        [Column(Order = 7)]
        public float bPieces { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "money")]
        public decimal bTotal { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "money")]
        public decimal bGarmLine { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "money")]
        public decimal bMerchLine { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "money")]
        public decimal bSFeeLine { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "money")]
        public decimal bCoupLine { get; set; }

        [Key]
        [Column(Order = 13, TypeName = "money")]
        public decimal bDiscLine { get; set; }

        [Key]
        [Column(Order = 14, TypeName = "money")]
        public decimal bCoupPct { get; set; }

        [Key]
        [Column(Order = 15, TypeName = "money")]
        public decimal bDiscPct { get; set; }

        [Key]
        [Column(Order = 16, TypeName = "money")]
        public decimal bSFeePct { get; set; }

        [Key]
        [Column(Order = 17, TypeName = "money")]
        public decimal bTaxTotal { get; set; }

        [Key]
        [Column(Order = 18, TypeName = "money")]
        public decimal bTaxTotal1 { get; set; }

        [Key]
        [Column(Order = 19, TypeName = "money")]
        public decimal bTaxTotal2 { get; set; }

        [Key]
        [Column(Order = 20, TypeName = "money")]
        public decimal bTaxTotal3 { get; set; }

        [Key]
        [Column(Order = 21)]
        public float aPieces { get; set; }

        [Key]
        [Column(Order = 22, TypeName = "money")]
        public decimal aTotal { get; set; }

        [Key]
        [Column(Order = 23, TypeName = "money")]
        public decimal aGarmLine { get; set; }

        [Key]
        [Column(Order = 24, TypeName = "money")]
        public decimal aMerchLine { get; set; }

        [Key]
        [Column(Order = 25, TypeName = "money")]
        public decimal aSFeeLine { get; set; }

        [Key]
        [Column(Order = 26, TypeName = "money")]
        public decimal aCoupLine { get; set; }

        [Key]
        [Column(Order = 27, TypeName = "money")]
        public decimal aDiscLine { get; set; }

        [Key]
        [Column(Order = 28, TypeName = "money")]
        public decimal aCoupPct { get; set; }

        [Key]
        [Column(Order = 29, TypeName = "money")]
        public decimal aDiscPct { get; set; }

        [Key]
        [Column(Order = 30, TypeName = "money")]
        public decimal aSFeePct { get; set; }

        [Key]
        [Column(Order = 31, TypeName = "money")]
        public decimal aTaxTotal { get; set; }

        [Key]
        [Column(Order = 32, TypeName = "money")]
        public decimal aTaxTotal1 { get; set; }

        [Key]
        [Column(Order = 33, TypeName = "money")]
        public decimal aTaxTotal2 { get; set; }

        [Key]
        [Column(Order = 34, TypeName = "money")]
        public decimal aTaxTotal3 { get; set; }
    }
}
