namespace DataAccessLayer.AssemblyDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AutoSort")]
    public partial class AutoSort
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvoiceID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        [StringLength(20)]
        public string StoreInvoiceID { get; set; }

        [StringLength(2)]
        public string PieceTotal { get; set; }

        [StringLength(2)]
        public string ItemNumber { get; set; }

        [StringLength(20)]
        public string ArticleCode { get; set; }

        [StringLength(104)]
        public string Description { get; set; }

        [StringLength(3)]
        public string OccPercent { get; set; }

        [StringLength(1)]
        public string Hung { get; set; }

        [StringLength(1)]
        public string Status { get; set; }

        [StringLength(2)]
        public string Conveyor { get; set; }

        [StringLength(5)]
        public string Slot { get; set; }

        [StringLength(5)]
        public string Out { get; set; }

        [StringLength(60)]
        public string Customer { get; set; }

        [StringLength(20)]
        public string RFID { get; set; }

        [StringLength(3)]
        public string Arm { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Queue { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int State { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Remaining { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public DateTime? DueDate { get; set; }

        [StringLength(18)]
        public string HomePhone { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BaySection { get; set; }

        [StringLength(30)]
        public string BagLabel1 { get; set; }

        [StringLength(30)]
        public string BagLabel2 { get; set; }

        [StringLength(30)]
        public string BagLabel3 { get; set; }

        [StringLength(30)]
        public string BagLabel4 { get; set; }

        [StringLength(30)]
        public string BagLabel5 { get; set; }

        [StringLength(30)]
        public string BagLabel6 { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool UseBAMStorage { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SubOut { get; set; }

        [StringLength(200)]
        public string FlagTag { get; set; }

        [StringLength(30)]
        public string BagLabel7 { get; set; }

        [StringLength(30)]
        public string BagLabel8 { get; set; }

        [StringLength(30)]
        public string BagLabel9 { get; set; }

        [StringLength(30)]
        public string BagLabel10 { get; set; }

        [StringLength(30)]
        public string BagLabel11 { get; set; }

        [StringLength(30)]
        public string BagLabel12 { get; set; }
    }
}
