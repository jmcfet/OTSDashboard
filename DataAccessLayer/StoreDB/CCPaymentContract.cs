namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CCPaymentContract
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CCPaymentContractID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        [StringLength(80)]
        public string CardNo { get; set; }

        [StringLength(25)]
        public string CardMasked { get; set; }

        [StringLength(80)]
        public string CardExpDate { get; set; }

        [StringLength(30)]
        public string AVSStreet { get; set; }

        [StringLength(10)]
        public string AVSZip { get; set; }

        public DateTime? LastBatchRunDate { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "money")]
        public decimal LastBatchRunTotal { get; set; }

        public DateTime? LastTokenDate { get; set; }

        [StringLength(100)]
        public string CardToken { get; set; }

        [StringLength(224)]
        public string EcBlock { get; set; }

        [StringLength(20)]
        public string EcKey { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool EcSwiped { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CCKeyID { get; set; }

        public DateTime? ResetDate { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool Locked { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool Deleted { get; set; }
    }
}
