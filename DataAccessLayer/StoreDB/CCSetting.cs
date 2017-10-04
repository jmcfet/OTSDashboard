namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CCSetting
    {
        [Key]
        [Column(Order = 0)]
        public bool EnableDebitCards { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool EnableGiftCards { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool EnableCardBillContracts { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool EnableCardBillOnPickup { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool EnableStatementContracts { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool EnableCashContracts { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool EnableOfficeContracts { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool EnableSkipExpiredCards { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool AcceptAmex { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool AcceptDiscover { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool AcceptJCB { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool EnablePcCharge { get; set; }

        [StringLength(120)]
        public string PcChargeIPAddress { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PcChargePort { get; set; }

        [StringLength(10)]
        public string CardProcessor { get; set; }

        [StringLength(80)]
        public string CardMerchant { get; set; }

        [StringLength(80)]
        public string CardBillMerchant { get; set; }

        [Key]
        [Column(Order = 13)]
        public bool EnablePaymentGateway { get; set; }

        [StringLength(20)]
        public string PaymentGatewayCardProcessor { get; set; }

        [StringLength(120)]
        public string PaymentGatewayDNSPrimary { get; set; }

        [StringLength(120)]
        public string PaymentGatewayDNSBackup { get; set; }

        [StringLength(120)]
        public string PaymentGatewayDNSGiftPrimary { get; set; }

        [StringLength(120)]
        public string PaymentGatewayDNSGiftBackup { get; set; }

        [StringLength(120)]
        public string PaymentGatewayURLPrimary { get; set; }

        [StringLength(120)]
        public string PaymentGatewayURLBackup { get; set; }

        [StringLength(80)]
        public string PaymentGatewayURLCardPassword { get; set; }

        [StringLength(80)]
        public string PaymentGatewayURLCardBillPassword { get; set; }

        [StringLength(80)]
        public string PaymentGatewayCardMerchant { get; set; }

        [StringLength(80)]
        public string PaymentGatewayCardBillMerchant { get; set; }

        [Key]
        [Column(Order = 14)]
        public bool EnableBatchClose { get; set; }

        [Key]
        [Column(Order = 15)]
        public bool EnableBatchSummary { get; set; }

        [Key]
        [Column(Order = 16)]
        public bool EnableMPSBrowse { get; set; }

        [Key]
        [Column(Order = 17)]
        public bool EnableE2E { get; set; }

        [Key]
        [Column(Order = 18)]
        public bool EnableTokenization { get; set; }

        [Key]
        [Column(Order = 19)]
        public bool EnableVoiceAuth { get; set; }

        [StringLength(30)]
        public string VoiceAuthPhoneMcVisaDisc { get; set; }

        [StringLength(30)]
        public string VoiceAuthPhoneAmex { get; set; }

        [Key]
        [Column(Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ApprovalBatchStationID { get; set; }

        [StringLength(50)]
        public string DeploymentID { get; set; }

        [StringLength(50)]
        public string NETePayIPAddress { get; set; }
    }
}
