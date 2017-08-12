//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeeDefault
    {
        public int SecurityLevelID { get; set; }
        public bool CanAdjustAccounts { get; set; }
        public bool CanEditInvoices { get; set; }
        public bool CanPrintDailyReport { get; set; }
        public bool CanCloseDay { get; set; }
        public bool CanVoidInvoices { get; set; }
        public bool EditCustDisc { get; set; }
        public bool EditInvoicePrices { get; set; }
        public bool EditCustAccData { get; set; }
        public bool CashOutAccounts { get; set; }
        public bool LogTransactions { get; set; }
        public bool CannotViewTimeCard { get; set; }
        public bool NoCouponAdj { get; set; }
        public int DrawerNumber { get; set; }
        public int DrawerStation { get; set; }
        public bool NoDrawer { get; set; }
        public bool CannotAddCash { get; set; }
        public bool CannotDisburseCash { get; set; }
        public bool CannotCashCheck { get; set; }
        public bool CannotMakeChange { get; set; }
        public bool CannotPrintDrawer { get; set; }
        public bool CannotPrintAudit { get; set; }
        public bool CannotCloseDrawers { get; set; }
        public bool CannotEditEmployees { get; set; }
        public bool CannotDeleteEmployees { get; set; }
        public bool CannotEditTimeCards { get; set; }
        public bool CannotEditEmpAccess { get; set; }
        public bool CannotEditEmpCashDrawer { get; set; }
        public bool CannotEditPriceList { get; set; }
        public bool CannotEditDepartments { get; set; }
        public bool CannotEditCategories { get; set; }
        public bool CannotEditGarments { get; set; }
        public bool CannotEditUpcharges { get; set; }
        public bool CannotEditDiscountsFees { get; set; }
        public bool CannotEditMerchandise { get; set; }
        public bool CannotPrintManagerRpts { get; set; }
        public bool CannotPrintEmpLog { get; set; }
        public bool CannotPrintSales { get; set; }
        public bool CannotPrintFinancials { get; set; }
        public bool CannotPrintTracking { get; set; }
        public bool CannotPrintDrawers { get; set; }
        public bool CannotDoPhysical { get; set; }
        public bool CannotSetupEmail { get; set; }
        public bool CanLowerPricesOnEdit { get; set; }
        public bool EditCustSalesTax { get; set; }
        public bool EditCustCheckWrite { get; set; }
        public bool CanInventoryBillOut { get; set; }
        public bool CanAddRemoveGarmentsOnEdit { get; set; }
        public bool CanAssignCustPLevels { get; set; }
        public bool CanSelectPLevelsInvoicing { get; set; }
        public bool CanSelectPLevelsEditing { get; set; }
        public bool CanEditCCOnFile { get; set; }
        public bool CanMPSBrowse { get; set; }
        public bool CanIssueVoidCCDebitsCredits { get; set; }
        public bool CanDeleteCustomers { get; set; }
        public bool CanEditCustEmail { get; set; }
        public bool CanSendACustomerEmail { get; set; }
        public bool CanEditLoyaltyPts { get; set; }
        public bool CanEditCustInvoiceSettings { get; set; }
        public bool CanViewCustActivity { get; set; }
        public bool CanIssueAwardCards { get; set; }
        public bool CanReloadAwardCards { get; set; }
        public bool CanReloadPurchaseCards { get; set; }
        public bool CanVoidGiftTransactions { get; set; }
        public bool CannotViewLocations { get; set; }
        public bool CanAddGarmentsOnEdit { get; set; }
        public bool CanRemoveGarmentsOnEdit { get; set; }
        public bool CanAddUpcharge { get; set; }
        public bool CanEditUpcharge { get; set; }
        public bool CanPriceUpcharge { get; set; }
        public int FPMLanguage { get; set; }
        public bool CannotPrintFPMManageReports { get; set; }
        public bool MayViewFPMMyReports { get; set; }
        public bool MayPrintFPMMyReports { get; set; }
        public bool MayAccessCCUtility { get; set; }
        public bool MayIssueCCRefunds { get; set; }
        public bool MayIssueCCVoidSales { get; set; }
    }
}
