namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Credit
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CreditID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CreditTypeID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AddedEmpID { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AppliedEmpID { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PaymentID { get; set; }

        public DateTime? CreditDate { get; set; }

        public DateTime? AppliedDate { get; set; }

        [StringLength(80)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal Total { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "money")]
        public decimal PaidAmount { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool Deleted { get; set; }

        [StringLength(25)]
        public string CardMasked { get; set; }

        [StringLength(16)]
        public string CardAuthNo { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AutoCreditID { get; set; }
    }
}
