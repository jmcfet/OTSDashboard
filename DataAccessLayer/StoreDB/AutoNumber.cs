namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AutoNumber")]
    public partial class AutoNumber
    {
        public int? NextStoreID { get; set; }

        public int? NextGLAccountID { get; set; }

        public int? NextTaxID { get; set; }

        public int? NextOrderID { get; set; }

        public int? NextInvoiceID { get; set; }

        public int? NextPaymentID { get; set; }

        public int? NextClerkDrawerID { get; set; }

        public int? NextNoSaleID { get; set; }

        public int? NextCreditID { get; set; }

        public int? NextCustID { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NextHeatSealID { get; set; }

        public int? NextControl1 { get; set; }

        public int? NextControl2 { get; set; }

        public int? NextControl3 { get; set; }

        public int? NextControl4 { get; set; }

        public int? NextLotID { get; set; }

        public int? NextLogId { get; set; }

        public int? NextTimeCardID { get; set; }

        public int? NextBilledID { get; set; }

        public int? NextInvDetailID { get; set; }

        public int? NextSOFBatchID { get; set; }

        public int? NextStopID { get; set; }

        public int? NextDeliveryLogID { get; set; }

        public int? NextRouteID { get; set; }

        public int? NextAdjustID { get; set; }

        public int? NextReasonID { get; set; }

        public int? NextOverdueID { get; set; }

        public int? NextPostalCodeID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NextStatementID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NextBillCycleID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NextBillCenterID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NextDeliveryGroupID { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NextInvPaidID { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NextAppliedCrID { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NextContactID { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NextTaxAuthorityID { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NextRecurringID { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NextRecurringGroupID { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NextEmailLogID { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NextImageID { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NextPasswordHistoryID { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NextCCKeyID { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NextCCAuditID { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NextCCPaymentContractID { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NextGiftTransID { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NextReceiptID { get; set; }

        [Key]
        [Column(Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NextScanLogID { get; set; }

        [Key]
        [Column(Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NextMerchID { get; set; }

        [Key]
        [Column(Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NextGiftCardTypeID { get; set; }

        [Key]
        [Column(Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NextCampaignID { get; set; }

        [Key]
        [Column(Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NextCardBillAutoCreditID { get; set; }

        [Key]
        [Column(Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NextClockInAccountID { get; set; }
    }
}
