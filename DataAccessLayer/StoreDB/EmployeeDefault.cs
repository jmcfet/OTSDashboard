namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EmployeeDefault
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SecurityLevelID { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool CanAdjustAccounts { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool CanEditInvoices { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool CanPrintDailyReport { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool CanCloseDay { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool CanVoidInvoices { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool EditCustDisc { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool EditInvoicePrices { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool EditCustAccData { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool CashOutAccounts { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool LogTransactions { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool CannotViewTimeCard { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool NoCouponAdj { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DrawerNumber { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DrawerStation { get; set; }

        [Key]
        [Column(Order = 15)]
        public bool NoDrawer { get; set; }

        [Key]
        [Column(Order = 16)]
        public bool CannotAddCash { get; set; }

        [Key]
        [Column(Order = 17)]
        public bool CannotDisburseCash { get; set; }

        [Key]
        [Column(Order = 18)]
        public bool CannotCashCheck { get; set; }

        [Key]
        [Column(Order = 19)]
        public bool CannotMakeChange { get; set; }

        [Key]
        [Column(Order = 20)]
        public bool CannotPrintDrawer { get; set; }

        [Key]
        [Column(Order = 21)]
        public bool CannotPrintAudit { get; set; }

        [Key]
        [Column(Order = 22)]
        public bool CannotCloseDrawers { get; set; }

        [Key]
        [Column(Order = 23)]
        public bool CannotEditEmployees { get; set; }

        [Key]
        [Column(Order = 24)]
        public bool CannotDeleteEmployees { get; set; }

        [Key]
        [Column(Order = 25)]
        public bool CannotEditTimeCards { get; set; }

        [Key]
        [Column(Order = 26)]
        public bool CannotEditEmpAccess { get; set; }

        [Key]
        [Column(Order = 27)]
        public bool CannotEditEmpCashDrawer { get; set; }

        [Key]
        [Column(Order = 28)]
        public bool CannotEditPriceList { get; set; }

        [Key]
        [Column(Order = 29)]
        public bool CannotEditDepartments { get; set; }

        [Key]
        [Column(Order = 30)]
        public bool CannotEditCategories { get; set; }

        [Key]
        [Column(Order = 31)]
        public bool CannotEditGarments { get; set; }

        [Key]
        [Column(Order = 32)]
        public bool CannotEditUpcharges { get; set; }

        [Key]
        [Column(Order = 33)]
        public bool CannotEditDiscountsFees { get; set; }

        [Key]
        [Column(Order = 34)]
        public bool CannotEditMerchandise { get; set; }

        [Key]
        [Column(Order = 35)]
        public bool CannotPrintManagerRpts { get; set; }

        [Key]
        [Column(Order = 36)]
        public bool CannotPrintEmpLog { get; set; }

        [Key]
        [Column(Order = 37)]
        public bool CannotPrintSales { get; set; }

        [Key]
        [Column(Order = 38)]
        public bool CannotPrintFinancials { get; set; }

        [Key]
        [Column(Order = 39)]
        public bool CannotPrintTracking { get; set; }

        [Key]
        [Column(Order = 40)]
        public bool CannotPrintDrawers { get; set; }

        [Key]
        [Column(Order = 41)]
        public bool CannotDoPhysical { get; set; }

        [Key]
        [Column(Order = 42)]
        public bool CannotSetupEmail { get; set; }

        [Key]
        [Column(Order = 43)]
        public bool CanLowerPricesOnEdit { get; set; }

        [Key]
        [Column(Order = 44)]
        public bool EditCustSalesTax { get; set; }

        [Key]
        [Column(Order = 45)]
        public bool EditCustCheckWrite { get; set; }

        [Key]
        [Column(Order = 46)]
        public bool CanInventoryBillOut { get; set; }

        [Key]
        [Column(Order = 47)]
        public bool CanAddRemoveGarmentsOnEdit { get; set; }

        [Key]
        [Column(Order = 48)]
        public bool CanAssignCustPLevels { get; set; }

        [Key]
        [Column(Order = 49)]
        public bool CanSelectPLevelsInvoicing { get; set; }

        [Key]
        [Column(Order = 50)]
        public bool CanSelectPLevelsEditing { get; set; }

        [Key]
        [Column(Order = 51)]
        public bool CanEditCCOnFile { get; set; }

        [Key]
        [Column(Order = 52)]
        public bool CanMPSBrowse { get; set; }

        [Key]
        [Column(Order = 53)]
        public bool CanIssueVoidCCDebitsCredits { get; set; }

        [Key]
        [Column(Order = 54)]
        public bool CanDeleteCustomers { get; set; }

        [Key]
        [Column(Order = 55)]
        public bool CanEditCustEmail { get; set; }

        [Key]
        [Column(Order = 56)]
        public bool CanSendACustomerEmail { get; set; }

        [Key]
        [Column(Order = 57)]
        public bool CanEditLoyaltyPts { get; set; }

        [Key]
        [Column(Order = 58)]
        public bool CanEditCustInvoiceSettings { get; set; }

        [Key]
        [Column(Order = 59)]
        public bool CanViewCustActivity { get; set; }

        [Key]
        [Column(Order = 60)]
        public bool CanIssueAwardCards { get; set; }

        [Key]
        [Column(Order = 61)]
        public bool CanReloadAwardCards { get; set; }

        [Key]
        [Column(Order = 62)]
        public bool CanReloadPurchaseCards { get; set; }

        [Key]
        [Column(Order = 63)]
        public bool CanVoidGiftTransactions { get; set; }

        [Key]
        [Column(Order = 64)]
        public bool CannotViewLocations { get; set; }

        [Key]
        [Column(Order = 65)]
        public bool CanAddGarmentsOnEdit { get; set; }

        [Key]
        [Column(Order = 66)]
        public bool CanRemoveGarmentsOnEdit { get; set; }

        [Key]
        [Column(Order = 67)]
        public bool CanAddUpcharge { get; set; }

        [Key]
        [Column(Order = 68)]
        public bool CanEditUpcharge { get; set; }

        [Key]
        [Column(Order = 69)]
        public bool CanPriceUpcharge { get; set; }

        [Key]
        [Column(Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FPMLanguage { get; set; }

        [Key]
        [Column(Order = 71)]
        public bool CannotPrintFPMManageReports { get; set; }

        [Key]
        [Column(Order = 72)]
        public bool MayViewFPMMyReports { get; set; }

        [Key]
        [Column(Order = 73)]
        public bool MayPrintFPMMyReports { get; set; }

        [Key]
        [Column(Order = 74)]
        public bool MayAccessCCUtility { get; set; }

        [Key]
        [Column(Order = 75)]
        public bool MayIssueCCRefunds { get; set; }

        [Key]
        [Column(Order = 76)]
        public bool MayIssueCCVoidSales { get; set; }
    }
}
