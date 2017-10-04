namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class InvoiceAdjust
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AdjustID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvoiceID { get; set; }

        [StringLength(80)]
        public string AdjDescription { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AdjType { get; set; }

        public DateTime? AdjustDate { get; set; }

        [Key]
        [Column(Order = 6)]
        public float Pieces { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal AdjAmount { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "money")]
        public decimal AdjTax { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool Deleted { get; set; }
    }
}
