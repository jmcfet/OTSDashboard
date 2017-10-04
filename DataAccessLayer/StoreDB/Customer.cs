namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreID { get; set; }

        [StringLength(30)]
        public string LastName { get; set; }

        [StringLength(20)]
        public string FirstName { get; set; }

        [StringLength(30)]
        public string Addr1 { get; set; }

        [StringLength(20)]
        public string Addr2 { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(3)]
        public string State { get; set; }

        [StringLength(10)]
        public string Zip { get; set; }

        [StringLength(18)]
        public string HomePhone { get; set; }

        [StringLength(18)]
        public string WorkPhone { get; set; }

        [StringLength(25)]
        public string Comment { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool IsVIP { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool FccMember { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FccPoints { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool NoChecks { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool CanBill { get; set; }

        [StringLength(20)]
        public string ReportCode { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool IsTaxExempt { get; set; }

        [StringLength(1)]
        public string Starch { get; set; }

        [StringLength(1)]
        public string Package { get; set; }

        [StringLength(500)]
        public string InvReminder { get; set; }

        public DateTime? OpenDate { get; set; }

        public DateTime? LastOrder { get; set; }

        public DateTime? LastCashout { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BillCycleID { get; set; }

        [StringLength(500)]
        public string CashReminder { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AutoDiscount1ID { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool Deleted { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool BillToOffice { get; set; }

        [StringLength(80)]
        public string SOFCardNo { get; set; }

        [StringLength(80)]
        public string SOFExpDate { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool SOFInStore { get; set; }

        [StringLength(1)]
        public string SOFBatch { get; set; }

        [StringLength(500)]
        public string EMail { get; set; }

        [Key]
        [Column(Order = 13)]
        public bool NoHeatseals { get; set; }

        [Key]
        [Column(Order = 14)]
        public bool IsFinCharged { get; set; }

        [StringLength(20)]
        public string ExtraAccount { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BillCenterID { get; set; }

        [Key]
        [Column(Order = 16, TypeName = "money")]
        public decimal CreditLimit { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PriceListID { get; set; }

        [Key]
        [Column(Order = 18)]
        public bool IsPrintName { get; set; }

        [Key]
        [Column(Order = 19)]
        public bool IsHotel { get; set; }

        [Key]
        [Column(Order = 20)]
        public bool PrintIReminder { get; set; }

        [Key]
        [Column(Order = 21)]
        public bool PrintPackingList { get; set; }

        [StringLength(18)]
        public string CellPhone { get; set; }

        [StringLength(40)]
        public string CompanyName { get; set; }

        [Key]
        [Column(Order = 22)]
        public bool IsCompany { get; set; }

        [StringLength(20)]
        public string DLNumber { get; set; }

        public DateTime? Birthday { get; set; }

        [Key]
        [Column(Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Language { get; set; }

        [Key]
        [Column(Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CoupCount { get; set; }

        [Key]
        [Column(Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Designation { get; set; }

        [StringLength(20)]
        public string LoyaltyID { get; set; }

        [Key]
        [Column(Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TaxAuthorityID { get; set; }

        [Key]
        [Column(Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvoicePrintID { get; set; }

        [Key]
        [Column(Order = 28)]
        public bool NoEmailPromos { get; set; }

        [Key]
        [Column(Order = 29)]
        public bool KioskCannotReplaceCard { get; set; }

        [Key]
        [Column(Order = 30)]
        public bool EmailStatements { get; set; }

        [Key]
        [Column(Order = 31)]
        public bool PrintStatements { get; set; }

        [StringLength(60)]
        public string SMSAddress { get; set; }

        [Key]
        [Column(Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AccountType { get; set; }

        [Key]
        [Column(Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PriceLevel { get; set; }

        [Key]
        [Column(Order = 34)]
        public bool RequestsNoEmail { get; set; }

        [StringLength(500)]
        public string ReadyEmail { get; set; }

        [StringLength(500)]
        public string StatementEmail { get; set; }

        [StringLength(500)]
        public string PromoEmail { get; set; }

        [StringLength(500)]
        public string RouteEmail { get; set; }

        public DateTime? DiscExpiration { get; set; }

        [StringLength(30)]
        public string BillLastName { get; set; }

        [StringLength(20)]
        public string BillFirstName { get; set; }

        [StringLength(30)]
        public string BillAddr1 { get; set; }

        [StringLength(20)]
        public string BillAddr2 { get; set; }

        [StringLength(20)]
        public string BillCity { get; set; }

        [StringLength(3)]
        public string BillState { get; set; }

        [StringLength(10)]
        public string BillZip { get; set; }

        [StringLength(500)]
        public string Notes { get; set; }

        [Key]
        [Column(Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvoiceCopies { get; set; }

        [Key]
        [Column(Order = 36)]
        public bool PrintInvoicePrices { get; set; }

        [Key]
        [Column(Order = 37)]
        public bool PrintInvoiceTotals { get; set; }

        [Key]
        [Column(Order = 38)]
        public bool NoPricesOnFirstCopy { get; set; }

        [Key]
        [Column(Order = 39)]
        public bool NoTotalsOnFirstCopy { get; set; }

        [StringLength(25)]
        public string CampaignCode { get; set; }

        [Key]
        [Column(Order = 40)]
        public bool AlwaysEmailReceipts { get; set; }

        [Key]
        [Column(Order = 41)]
        public bool InvoicingRestricted { get; set; }
    }
}
