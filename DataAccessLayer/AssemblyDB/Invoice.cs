namespace DataAccessLayer.AssemblyDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Invoice
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvoiceID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepartmentID { get; set; }

        [StringLength(20)]
        public string Department { get; set; }

        [StringLength(6)]
        public string Rack { get; set; }

        [StringLength(25)]
        public string LotInfo { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvoiceEmpID { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RackEmpID { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PickupEmpID { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public DateTime? DueDate { get; set; }

        public DateTime? RackDate { get; set; }

        public DateTime? PickupDate { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool IsMissingAmount { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WorkPhase { get; set; }

        [Key]
        [Column(Order = 10)]
        public float Pieces { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Tax1ID { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "money")]
        public decimal Taxable { get; set; }

        [Key]
        [Column(Order = 13, TypeName = "money")]
        public decimal TaxTotal { get; set; }

        [Key]
        [Column(Order = 14, TypeName = "money")]
        public decimal SubTotal { get; set; }

        [Key]
        [Column(Order = 15, TypeName = "money")]
        public decimal Total { get; set; }

        [Key]
        [Column(Order = 16, TypeName = "money")]
        public decimal PaidAmount { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PaymentID { get; set; }

        [Key]
        [Column(Order = 18, TypeName = "money")]
        public decimal CoupTotal { get; set; }

        [Key]
        [Column(Order = 19, TypeName = "money")]
        public decimal DiscTotal { get; set; }

        [Key]
        [Column(Order = 20)]
        public bool Deleted { get; set; }

        [Key]
        [Column(Order = 21, TypeName = "money")]
        public decimal CoupDiscable { get; set; }

        [Key]
        [Column(Order = 22, TypeName = "money")]
        public decimal SrvFeeable { get; set; }

        [Key]
        [Column(Order = 23, TypeName = "money")]
        public decimal SrvFeeTotal { get; set; }

        public DateTime? PaymentDate { get; set; }

        [StringLength(10)]
        public string HotelRoom { get; set; }

        [StringLength(30)]
        public string GuestName { get; set; }

        [Key]
        [Column(Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ValetTicketID { get; set; }

        [Key]
        [Column(Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BillCustomerID { get; set; }

        [Key]
        [Column(Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Tax2ID { get; set; }

        [Key]
        [Column(Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Tax3ID { get; set; }

        [Key]
        [Column(Order = 28, TypeName = "money")]
        public decimal Taxable1 { get; set; }

        [Key]
        [Column(Order = 29, TypeName = "money")]
        public decimal Taxable2 { get; set; }

        [Key]
        [Column(Order = 30, TypeName = "money")]
        public decimal Taxable3 { get; set; }

        [Key]
        [Column(Order = 31, TypeName = "money")]
        public decimal TaxTotal1 { get; set; }

        [Key]
        [Column(Order = 32, TypeName = "money")]
        public decimal TaxTotal2 { get; set; }

        [Key]
        [Column(Order = 33, TypeName = "money")]
        public decimal TaxTotal3 { get; set; }

        [Key]
        [Column(Order = 34, TypeName = "money")]
        public decimal OriginalTotal { get; set; }

        [Key]
        [Column(Order = 35)]
        public bool IsRedo { get; set; }

        [Key]
        [Column(Order = 36)]
        public bool IsSplit { get; set; }

        [Key]
        [Column(Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TaxAuthorityID { get; set; }

        [StringLength(100)]
        public string BaggerMemo { get; set; }

        [Key]
        [Column(Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PayCode { get; set; }

        public DateTime? AssemblyDate { get; set; }

        public DateTime? MarkInDate { get; set; }

        [Key]
        [Column(Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MarkInEmpID { get; set; }
    }
}
