namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Store
    {
        public int? StoreID { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(30)]
        public string Address1 { get; set; }

        [StringLength(30)]
        public string Address2 { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(3)]
        public string State { get; set; }

        [StringLength(15)]
        public string ZipCode { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [StringLength(20)]
        public string ModemNumber { get; set; }

        [StringLength(20)]
        public string FaxNumber { get; set; }

        [StringLength(60)]
        public string EMailAddress { get; set; }

        public int? MaxDrycleanPieces { get; set; }

        public int? MaxLaundryPieces { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CountryID { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool StretchLogo { get; set; }

        [StringLength(500)]
        public string LogoPath { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PrintFormID { get; set; }

        [StringLength(30)]
        public string RegistrationNo { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PrintSidesID { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool PaymentsFirst { get; set; }

        [StringLength(30)]
        public string StName { get; set; }

        [StringLength(30)]
        public string StAddress1 { get; set; }

        [StringLength(30)]
        public string StAddress2 { get; set; }

        [StringLength(20)]
        public string StCity { get; set; }

        [StringLength(3)]
        public string StState { get; set; }

        [StringLength(15)]
        public string StZipCode { get; set; }

        [StringLength(20)]
        public string StPhoneNumber { get; set; }

        [StringLength(20)]
        public string StFaxNumber { get; set; }

        [StringLength(30)]
        public string StRegistrationNo { get; set; }

        [StringLength(100)]
        public string StoreHours { get; set; }

        [StringLength(100)]
        public string StStoreHours { get; set; }

        [StringLength(100)]
        public string CardMerchant { get; set; }

        [StringLength(100)]
        public string CardBillMerchant { get; set; }

        [StringLength(100)]
        public string DebitMerchant { get; set; }

        [StringLength(100)]
        public string GiftMerchant { get; set; }

        [StringLength(100)]
        public string CardProcessor { get; set; }

        [StringLength(100)]
        public string DebitProcessor { get; set; }

        [StringLength(100)]
        public string GiftProcessor { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreColor { get; set; }

        [StringLength(100)]
        public string WebSite { get; set; }

        [StringLength(100)]
        public string WebSiteText { get; set; }

        [StringLength(50)]
        public string WebSiteTitle { get; set; }

        [StringLength(500)]
        public string ImageFolder { get; set; }

        [StringLength(500)]
        public string WebSiteImageFolder { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvoiceImageID { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StatementImageID { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CAIntegrationType { get; set; }

        [StringLength(100)]
        public string CAIPAddress { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CAPort { get; set; }
    }
}
