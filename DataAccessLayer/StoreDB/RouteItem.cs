namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RouteItem
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RouteID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DriverEmpID { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(5)]
        public string PrintCode { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Monday { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool Tuesday { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool Wednesday { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool Thursday { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool Friday { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool Saturday { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool Sunday { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool Deleted { get; set; }

        [StringLength(175)]
        public string RouteAgent { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvoiceImageID { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StatementImageID { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PriceLevel { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvoicePrinterID { get; set; }

        [StringLength(200)]
        public string RouteExportPath { get; set; }
    }
}
