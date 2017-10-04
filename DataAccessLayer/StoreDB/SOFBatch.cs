namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SOFBatch
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SOFBatchID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        [StringLength(1)]
        public string BatchDWM { get; set; }

        public DateTime? BatchRunDate { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TransType { get; set; }

        [StringLength(80)]
        public string CardNo { get; set; }

        [StringLength(4)]
        public string ExpDate { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "money")]
        public decimal Amount { get; set; }

        [StringLength(20)]
        public string Member { get; set; }

        [StringLength(20)]
        public string Street { get; set; }

        [StringLength(9)]
        public string Zip { get; set; }

        [StringLength(20)]
        public string AuthNo { get; set; }

        [StringLength(16)]
        public string AuthRef { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool Approved { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool Deleted { get; set; }

        [StringLength(25)]
        public string CardMasked { get; set; }

        public DateTime? ApprovalDate { get; set; }

        [StringLength(100)]
        public string DeclineTextResponse { get; set; }

        [StringLength(10)]
        public string DeclineErrorCode { get; set; }
    }
}
