namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Payment
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PaymentID { get; set; }

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
        public int StationID { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ClerkDrawerID { get; set; }

        public DateTime? PayDate { get; set; }

        [StringLength(16)]
        public string CheckNo { get; set; }

        [StringLength(80)]
        public string CardNo { get; set; }

        [StringLength(8)]
        public string CardExp { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "money")]
        public decimal CashAmount { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal CheckAmount { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "money")]
        public decimal CardAmount { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "money")]
        public decimal TenderAmount { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "money")]
        public decimal ChangeAmount { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DrawerNumber { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool Deleted { get; set; }

        [StringLength(16)]
        public string CardAuthNo { get; set; }

        [Key]
        [Column(Order = 13)]
        public bool IsDebitCard { get; set; }

        [StringLength(16)]
        public string CardTroutD { get; set; }

        [Key]
        [Column(Order = 14, TypeName = "money")]
        public decimal GiftAmount { get; set; }

        [StringLength(25)]
        public string GiftNo { get; set; }

        [StringLength(16)]
        public string GiftAuthNo { get; set; }

        [StringLength(16)]
        public string GiftTroutD { get; set; }

        [StringLength(25)]
        public string CardMasked { get; set; }

        [StringLength(100)]
        public string CardToken { get; set; }

        [StringLength(224)]
        public string EcBlock { get; set; }

        [StringLength(20)]
        public string EcKey { get; set; }

        [Key]
        [Column(Order = 15)]
        public bool EcSwiped { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CCKeyID { get; set; }

        public DateTime? ResetDate { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AccountType { get; set; }
    }
}
