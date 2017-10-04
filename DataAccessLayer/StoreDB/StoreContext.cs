namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StoreContext : DbContext
    {
        public StoreContext()
            : base("name=StoreContext")
        {
        }

        public StoreContext(string conn)
            : base(conn)
        {
        }

        public virtual DbSet<dtproperty> dtproperties { get; set; }
        public virtual DbSet<AppliedCr> AppliedCrs { get; set; }
        public virtual DbSet<AutoNumber> AutoNumbers { get; set; }
        public virtual DbSet<BillCyclePeriod> BillCyclePeriods { get; set; }
        public virtual DbSet<BillingCenter> BillingCenters { get; set; }
        public virtual DbSet<BillingCycle> BillingCycles { get; set; }
        public virtual DbSet<Campaign> Campaigns { get; set; }
        public virtual DbSet<CardBillAutoCredit> CardBillAutoCredits { get; set; }
        public virtual DbSet<CardBilling> CardBillings { get; set; }
        public virtual DbSet<CCAudit> CCAudits { get; set; }
        public virtual DbSet<CCKey> CCKeys { get; set; }
        public virtual DbSet<CCPaymentContract> CCPaymentContracts { get; set; }
        public virtual DbSet<CCSetting> CCSettings { get; set; }
        public virtual DbSet<CCStationSetting> CCStationSettings { get; set; }
        public virtual DbSet<ClerkDrawer> ClerkDrawers { get; set; }
        public virtual DbSet<ClockInAccount> ClockInAccounts { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Credit> Credits { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<DeletedCust> DeletedCusts { get; set; }
        public virtual DbSet<DeliveryCenter> DeliveryCenters { get; set; }
        public virtual DbSet<DeliveryGroup> DeliveryGroups { get; set; }
        public virtual DbSet<DeliveryLog> DeliveryLogs { get; set; }
        public virtual DbSet<EditedCust> EditedCusts { get; set; }
        public virtual DbSet<EmailLog> EmailLogs { get; set; }
        public virtual DbSet<EmployeeDefault> EmployeeDefaults { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<GiftCardType> GiftCardTypes { get; set; }
        public virtual DbSet<GiftTransaction> GiftTransactions { get; set; }
        public virtual DbSet<GLAccount> GLAccounts { get; set; }
        public virtual DbSet<GLJournal> GLJournals { get; set; }
        public virtual DbSet<Heatseal> Heatseals { get; set; }
        public virtual DbSet<ImageLibrary> ImageLibraries { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<InvoiceAdjust> InvoiceAdjusts { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvPaid> InvPaids { get; set; }
        public virtual DbSet<KioskSetting> KioskSettings { get; set; }
        public virtual DbSet<Lot> Lots { get; set; }
        public virtual DbSet<MerchantQTY> MerchantQTies { get; set; }
        public virtual DbSet<MergedCust> MergedCusts { get; set; }
        public virtual DbSet<NoSale> NoSales { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<OrderProcess> OrderProcesses { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Original> Originals { get; set; }
        public virtual DbSet<OverdueStat> OverdueStats { get; set; }
        public virtual DbSet<PasswordHistory> PasswordHistories { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Physical> Physicals { get; set; }
        public virtual DbSet<PostalCode> PostalCodes { get; set; }
        public virtual DbSet<Preference> Preferences { get; set; }
        public virtual DbSet<PurgedCust> PurgedCusts { get; set; }
        public virtual DbSet<Reason> Reasons { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<RecurringGroup> RecurringGroups { get; set; }
        public virtual DbSet<Recurring> Recurrings { get; set; }
        public virtual DbSet<RouteItem> RouteItems { get; set; }
        public virtual DbSet<RouteStop> RouteStops { get; set; }
        public virtual DbSet<SalesTax> SalesTaxes { get; set; }
        public virtual DbSet<ScanLog> ScanLogs { get; set; }
        public virtual DbSet<SOFBatch> SOFBatches { get; set; }
        public virtual DbSet<StatementBalance> StatementBalances { get; set; }
        public virtual DbSet<StatementHistory> StatementHistories { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<TaxAuthority> TaxAuthorities { get; set; }
        public virtual DbSet<TimeCard> TimeCards { get; set; }
        public virtual DbSet<Version> Versions { get; set; }
        public virtual DbSet<WirelessCarrier> WirelessCarriers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<dtproperty>()
                .Property(e => e.property)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperty>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<AppliedCr>()
                .Property(e => e.PaidAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BillingCenter>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<BillingCenter>()
                .Property(e => e.ChargeLimit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BillingCycle>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<BillingCycle>()
                .Property(e => e.MinCharge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BillingCycle>()
                .Property(e => e.MinBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BillingCycle>()
                .Property(e => e.Message1)
                .IsUnicode(false);

            modelBuilder.Entity<BillingCycle>()
                .Property(e => e.Message2)
                .IsUnicode(false);

            modelBuilder.Entity<BillingCycle>()
                .Property(e => e.Message3)
                .IsUnicode(false);

            modelBuilder.Entity<Campaign>()
                .Property(e => e.CampaignCode)
                .IsUnicode(false);

            modelBuilder.Entity<Campaign>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CardBillAutoCredit>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CardBillAutoCredit>()
                .Property(e => e.OrigBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CardBillAutoCredit>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CardBilling>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CCAudit>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<CCAudit>()
                .Property(e => e.EventType)
                .IsUnicode(false);

            modelBuilder.Entity<CCAudit>()
                .Property(e => e.EventOrigination)
                .IsUnicode(false);

            modelBuilder.Entity<CCAudit>()
                .Property(e => e.DataResource)
                .IsUnicode(false);

            modelBuilder.Entity<CCAudit>()
                .Property(e => e.Result)
                .IsUnicode(false);

            modelBuilder.Entity<CCKey>()
                .Property(e => e.CCKey1)
                .IsUnicode(false);

            modelBuilder.Entity<CCPaymentContract>()
                .Property(e => e.CardNo)
                .IsUnicode(false);

            modelBuilder.Entity<CCPaymentContract>()
                .Property(e => e.CardMasked)
                .IsUnicode(false);

            modelBuilder.Entity<CCPaymentContract>()
                .Property(e => e.CardExpDate)
                .IsUnicode(false);

            modelBuilder.Entity<CCPaymentContract>()
                .Property(e => e.AVSStreet)
                .IsUnicode(false);

            modelBuilder.Entity<CCPaymentContract>()
                .Property(e => e.AVSZip)
                .IsUnicode(false);

            modelBuilder.Entity<CCPaymentContract>()
                .Property(e => e.LastBatchRunTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CCPaymentContract>()
                .Property(e => e.CardToken)
                .IsUnicode(false);

            modelBuilder.Entity<CCPaymentContract>()
                .Property(e => e.EcBlock)
                .IsUnicode(false);

            modelBuilder.Entity<CCPaymentContract>()
                .Property(e => e.EcKey)
                .IsUnicode(false);

            modelBuilder.Entity<CCSetting>()
                .Property(e => e.PcChargeIPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<CCSetting>()
                .Property(e => e.CardProcessor)
                .IsUnicode(false);

            modelBuilder.Entity<CCSetting>()
                .Property(e => e.CardMerchant)
                .IsUnicode(false);

            modelBuilder.Entity<CCSetting>()
                .Property(e => e.CardBillMerchant)
                .IsUnicode(false);

            modelBuilder.Entity<CCSetting>()
                .Property(e => e.PaymentGatewayCardProcessor)
                .IsUnicode(false);

            modelBuilder.Entity<CCSetting>()
                .Property(e => e.PaymentGatewayDNSPrimary)
                .IsUnicode(false);

            modelBuilder.Entity<CCSetting>()
                .Property(e => e.PaymentGatewayDNSBackup)
                .IsUnicode(false);

            modelBuilder.Entity<CCSetting>()
                .Property(e => e.PaymentGatewayDNSGiftPrimary)
                .IsUnicode(false);

            modelBuilder.Entity<CCSetting>()
                .Property(e => e.PaymentGatewayDNSGiftBackup)
                .IsUnicode(false);

            modelBuilder.Entity<CCSetting>()
                .Property(e => e.PaymentGatewayURLPrimary)
                .IsUnicode(false);

            modelBuilder.Entity<CCSetting>()
                .Property(e => e.PaymentGatewayURLBackup)
                .IsUnicode(false);

            modelBuilder.Entity<CCSetting>()
                .Property(e => e.PaymentGatewayURLCardPassword)
                .IsUnicode(false);

            modelBuilder.Entity<CCSetting>()
                .Property(e => e.PaymentGatewayURLCardBillPassword)
                .IsUnicode(false);

            modelBuilder.Entity<CCSetting>()
                .Property(e => e.PaymentGatewayCardMerchant)
                .IsUnicode(false);

            modelBuilder.Entity<CCSetting>()
                .Property(e => e.PaymentGatewayCardBillMerchant)
                .IsUnicode(false);

            modelBuilder.Entity<CCSetting>()
                .Property(e => e.VoiceAuthPhoneMcVisaDisc)
                .IsUnicode(false);

            modelBuilder.Entity<CCSetting>()
                .Property(e => e.VoiceAuthPhoneAmex)
                .IsUnicode(false);

            modelBuilder.Entity<CCSetting>()
                .Property(e => e.DeploymentID)
                .IsUnicode(false);

            modelBuilder.Entity<CCSetting>()
                .Property(e => e.NETePayIPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<ClerkDrawer>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ClerkDrawer>()
                .Property(e => e.StartingCash)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClerkDrawer>()
                .Property(e => e.Cash)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClerkDrawer>()
                .Property(e => e.Checks)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClerkDrawer>()
                .Property(e => e.Cards)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClerkDrawer>()
                .Property(e => e.Coupons)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClerkDrawer>()
                .Property(e => e.CountedCash)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClerkDrawer>()
                .Property(e => e.CountedChecks)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClerkDrawer>()
                .Property(e => e.CountedCards)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClerkDrawer>()
                .Property(e => e.CountedCoupons)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClerkDrawer>()
                .Property(e => e.RemovedCash)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClerkDrawer>()
                .Property(e => e.CashCount0)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClerkDrawer>()
                .Property(e => e.CashCount1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClerkDrawer>()
                .Property(e => e.CashCount2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClerkDrawer>()
                .Property(e => e.CashCount3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClerkDrawer>()
                .Property(e => e.CashCount4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClerkDrawer>()
                .Property(e => e.CashCount5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClerkDrawer>()
                .Property(e => e.CashCount6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClerkDrawer>()
                .Property(e => e.CashCount7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClerkDrawer>()
                .Property(e => e.CashCount8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClerkDrawer>()
                .Property(e => e.CashCount9)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClerkDrawer>()
                .Property(e => e.CashCount10)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClerkDrawer>()
                .Property(e => e.CashCount11)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClerkDrawer>()
                .Property(e => e.CashCount12)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClerkDrawer>()
                .Property(e => e.CashCount13)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClerkDrawer>()
                .Property(e => e.CashCount14)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClerkDrawer>()
                .Property(e => e.CashCount15)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClerkDrawer>()
                .Property(e => e.CashCount16)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClerkDrawer>()
                .Property(e => e.Gift)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClerkDrawer>()
                .Property(e => e.CountedGift)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClockInAccount>()
                .Property(e => e.AccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<ClockInAccount>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.ContactTypeDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Issue)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Resolution)
                .IsUnicode(false);

            modelBuilder.Entity<Credit>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Credit>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Credit>()
                .Property(e => e.PaidAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Credit>()
                .Property(e => e.CardMasked)
                .IsUnicode(false);

            modelBuilder.Entity<Credit>()
                .Property(e => e.CardAuthNo)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Addr1)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Addr2)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Zip)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.WorkPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.ReportCode)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Starch)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Package)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.InvReminder)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CashReminder)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.SOFCardNo)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.SOFExpDate)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.SOFBatch)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.EMail)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.ExtraAccount)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CreditLimit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.DLNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.LoyaltyID)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.SMSAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.ReadyEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.StatementEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.PromoEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.RouteEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.BillLastName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.BillFirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.BillAddr1)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.BillAddr2)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.BillCity)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.BillState)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.BillZip)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CampaignCode)
                .IsUnicode(false);

            modelBuilder.Entity<DeletedCust>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<DeletedCust>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<DeletedCust>()
                .Property(e => e.Addr1)
                .IsUnicode(false);

            modelBuilder.Entity<DeletedCust>()
                .Property(e => e.Addr2)
                .IsUnicode(false);

            modelBuilder.Entity<DeletedCust>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<DeletedCust>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<DeletedCust>()
                .Property(e => e.Zip)
                .IsUnicode(false);

            modelBuilder.Entity<DeliveryCenter>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<EditedCust>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<EditedCust>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<EditedCust>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<EmailLog>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.SalaryRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.PieceRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Employee>()
                .Property(e => e.PieceRateLaundry)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Employee>()
                .Property(e => e.PieceRateDryclean)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.UserPIN)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.UserPassword)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.UserSalt)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.SecretQuestion)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.SecretAnswer)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Domain)
                .IsUnicode(false);

            modelBuilder.Entity<GiftCardType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<GiftCardType>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GiftCardType>()
                .Property(e => e.Maximum)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GiftTransaction>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<GiftTransaction>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GiftTransaction>()
                .Property(e => e.AuthNo)
                .IsUnicode(false);

            modelBuilder.Entity<GiftTransaction>()
                .Property(e => e.RefNo)
                .IsUnicode(false);

            modelBuilder.Entity<GiftTransaction>()
                .Property(e => e.GiftNo)
                .IsUnicode(false);

            modelBuilder.Entity<GiftTransaction>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GLAccount>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<GLAccount>()
                .Property(e => e.TypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<GLAccount>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GLAccount>()
                .Property(e => e.GLNumber)
                .IsUnicode(false);

            modelBuilder.Entity<GLJournal>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Heatseal>()
                .Property(e => e.TotalSales)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Heatseal>()
                .Property(e => e.Message)
                .IsUnicode(false);

            modelBuilder.Entity<ImageLibrary>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ImageLibrary>()
                .Property(e => e.ImageFileName)
                .IsUnicode(false);

            modelBuilder.Entity<ImageLibrary>()
                .Property(e => e.LinkText)
                .IsUnicode(false);

            modelBuilder.Entity<ImageLibrary>()
                .Property(e => e.LinkTitle)
                .IsUnicode(false);

            modelBuilder.Entity<ImageLibrary>()
                .Property(e => e.MergeImageName)
                .IsUnicode(false);

            modelBuilder.Entity<Inventory>()
                .Property(e => e.CSTotalInv)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Inventory>()
                .Property(e => e.STTotalInv)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Inventory>()
                .Property(e => e.ISTotalInv)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Inventory>()
                .Property(e => e.BOTotalInv)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Inventory>()
                .Property(e => e.CSTotalAR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Inventory>()
                .Property(e => e.STTotalAR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Inventory>()
                .Property(e => e.ISTotalAR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Inventory>()
                .Property(e => e.BOTotalAR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceAdjust>()
                .Property(e => e.AdjDescription)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceAdjust>()
                .Property(e => e.AdjAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceAdjust>()
                .Property(e => e.AdjTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.DetailDesc)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.ArticleCode)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.FlagTag)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.DetailGuid)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.Rack)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.LotInfo)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.Taxable)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.TaxTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.Subtotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.PaidAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.CoupTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.DiscTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.CoupDiscable)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.SrvFeeable)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.SrvFeeTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.HotelRoom)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.GuestName)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.Taxable1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.Taxable2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.Taxable3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.TaxTotal1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.TaxTotal2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.TaxTotal3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.OriginalTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.BaggerMemo)
                .IsUnicode(false);

            modelBuilder.Entity<InvPaid>()
                .Property(e => e.PaidAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<KioskSetting>()
                .Property(e => e.ComSettings)
                .IsUnicode(false);

            modelBuilder.Entity<KioskSetting>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<KioskSetting>()
                .Property(e => e.HomeTitle)
                .IsUnicode(false);

            modelBuilder.Entity<KioskSetting>()
                .Property(e => e.Home1)
                .IsUnicode(false);

            modelBuilder.Entity<KioskSetting>()
                .Property(e => e.RegistrationTitle)
                .IsUnicode(false);

            modelBuilder.Entity<KioskSetting>()
                .Property(e => e.SignupTitle)
                .IsUnicode(false);

            modelBuilder.Entity<KioskSetting>()
                .Property(e => e.Signup1)
                .IsUnicode(false);

            modelBuilder.Entity<KioskSetting>()
                .Property(e => e.PrivacyTitle)
                .IsUnicode(false);

            modelBuilder.Entity<KioskSetting>()
                .Property(e => e.Privacy)
                .IsUnicode(false);

            modelBuilder.Entity<KioskSetting>()
                .Property(e => e.AgreementTitle)
                .IsUnicode(false);

            modelBuilder.Entity<KioskSetting>()
                .Property(e => e.Agreement)
                .IsUnicode(false);

            modelBuilder.Entity<KioskSetting>()
                .Property(e => e.TitleFont)
                .IsUnicode(false);

            modelBuilder.Entity<KioskSetting>()
                .Property(e => e.PanelFont)
                .IsUnicode(false);

            modelBuilder.Entity<KioskSetting>()
                .Property(e => e.LegalFont)
                .IsUnicode(false);

            modelBuilder.Entity<KioskSetting>()
                .Property(e => e.HomeURL)
                .IsUnicode(false);

            modelBuilder.Entity<KioskSetting>()
                .Property(e => e.HomeHtmlFilePath)
                .IsUnicode(false);

            modelBuilder.Entity<KioskSetting>()
                .Property(e => e.SignupURL)
                .IsUnicode(false);

            modelBuilder.Entity<KioskSetting>()
                .Property(e => e.SignupHtmlFilePath)
                .IsUnicode(false);

            modelBuilder.Entity<KioskSetting>()
                .Property(e => e.Reload)
                .IsUnicode(false);

            modelBuilder.Entity<KioskSetting>()
                .Property(e => e.AppOOS)
                .IsUnicode(false);

            modelBuilder.Entity<KioskSetting>()
                .Property(e => e.ScanTest)
                .IsUnicode(false);

            modelBuilder.Entity<KioskSetting>()
                .Property(e => e.AppClose)
                .IsUnicode(false);

            modelBuilder.Entity<Lot>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Lot>()
                .Property(e => e.LotColor)
                .IsUnicode(false);

            modelBuilder.Entity<Lot>()
                .Property(e => e.ForcedStations)
                .IsUnicode(false);

            modelBuilder.Entity<Lot>()
                .Property(e => e.Color1)
                .IsUnicode(false);

            modelBuilder.Entity<Lot>()
                .Property(e => e.Color2)
                .IsUnicode(false);

            modelBuilder.Entity<Lot>()
                .Property(e => e.Color3)
                .IsUnicode(false);

            modelBuilder.Entity<Lot>()
                .Property(e => e.Color4)
                .IsUnicode(false);

            modelBuilder.Entity<Lot>()
                .Property(e => e.Color5)
                .IsUnicode(false);

            modelBuilder.Entity<Lot>()
                .Property(e => e.Color6)
                .IsUnicode(false);

            modelBuilder.Entity<Lot>()
                .Property(e => e.Color7)
                .IsUnicode(false);

            modelBuilder.Entity<Lot>()
                .Property(e => e.Color8)
                .IsUnicode(false);

            modelBuilder.Entity<Lot>()
                .Property(e => e.Color9)
                .IsUnicode(false);

            modelBuilder.Entity<Lot>()
                .Property(e => e.Color10)
                .IsUnicode(false);

            modelBuilder.Entity<Lot>()
                .Property(e => e.Color11)
                .IsUnicode(false);

            modelBuilder.Entity<Lot>()
                .Property(e => e.Color12)
                .IsUnicode(false);

            modelBuilder.Entity<MergedCust>()
                .Property(e => e.FromLName)
                .IsUnicode(false);

            modelBuilder.Entity<MergedCust>()
                .Property(e => e.FromFName)
                .IsUnicode(false);

            modelBuilder.Entity<MergedCust>()
                .Property(e => e.ToLName)
                .IsUnicode(false);

            modelBuilder.Entity<MergedCust>()
                .Property(e => e.ToFName)
                .IsUnicode(false);

            modelBuilder.Entity<NoSale>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<NoSale>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NoSale>()
                .Property(e => e.CardMasked)
                .IsUnicode(false);

            modelBuilder.Entity<NoSale>()
                .Property(e => e.AuthNo)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.DetailDesc)
                .IsUnicode(false);

            modelBuilder.Entity<OrderProcess>()
                .Property(e => e.PlantName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderProcess>()
                .Property(e => e.PlantLocation)
                .IsUnicode(false);

            modelBuilder.Entity<OrderProcess>()
                .Property(e => e.SBFPath)
                .IsUnicode(false);

            modelBuilder.Entity<OrderProcess>()
                .Property(e => e.CRDNPath)
                .IsUnicode(false);

            modelBuilder.Entity<OrderProcess>()
                .Property(e => e.DCTYDPath)
                .IsUnicode(false);

            modelBuilder.Entity<OrderProcess>()
                .Property(e => e.FranchiseeList)
                .IsUnicode(false);

            modelBuilder.Entity<OrderProcess>()
                .Property(e => e.FranchiseePasswords)
                .IsUnicode(false);

            modelBuilder.Entity<OrderProcess>()
                .Property(e => e.BaggerStoreCode)
                .IsUnicode(false);

            modelBuilder.Entity<Original>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<Original>()
                .Property(e => e.bTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Original>()
                .Property(e => e.bGarmLine)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Original>()
                .Property(e => e.bMerchLine)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Original>()
                .Property(e => e.bSFeeLine)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Original>()
                .Property(e => e.bCoupLine)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Original>()
                .Property(e => e.bDiscLine)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Original>()
                .Property(e => e.bCoupPct)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Original>()
                .Property(e => e.bDiscPct)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Original>()
                .Property(e => e.bSFeePct)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Original>()
                .Property(e => e.bTaxTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Original>()
                .Property(e => e.bTaxTotal1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Original>()
                .Property(e => e.bTaxTotal2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Original>()
                .Property(e => e.bTaxTotal3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Original>()
                .Property(e => e.aTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Original>()
                .Property(e => e.aGarmLine)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Original>()
                .Property(e => e.aMerchLine)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Original>()
                .Property(e => e.aSFeeLine)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Original>()
                .Property(e => e.aCoupLine)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Original>()
                .Property(e => e.aDiscLine)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Original>()
                .Property(e => e.aCoupPct)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Original>()
                .Property(e => e.aDiscPct)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Original>()
                .Property(e => e.aSFeePct)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Original>()
                .Property(e => e.aTaxTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Original>()
                .Property(e => e.aTaxTotal1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Original>()
                .Property(e => e.aTaxTotal2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Original>()
                .Property(e => e.aTaxTotal3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OverdueStat>()
                .Property(e => e.OverdueAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PasswordHistory>()
                .Property(e => e.UserPassword)
                .IsUnicode(false);

            modelBuilder.Entity<PasswordHistory>()
                .Property(e => e.SecretAnswer)
                .IsUnicode(false);

            modelBuilder.Entity<PasswordHistory>()
                .Property(e => e.UserSalt)
                .IsUnicode(false);

            modelBuilder.Entity<Payment>()
                .Property(e => e.CheckNo)
                .IsUnicode(false);

            modelBuilder.Entity<Payment>()
                .Property(e => e.CardNo)
                .IsUnicode(false);

            modelBuilder.Entity<Payment>()
                .Property(e => e.CardExp)
                .IsUnicode(false);

            modelBuilder.Entity<Payment>()
                .Property(e => e.CashAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Payment>()
                .Property(e => e.CheckAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Payment>()
                .Property(e => e.CardAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Payment>()
                .Property(e => e.TenderAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Payment>()
                .Property(e => e.ChangeAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Payment>()
                .Property(e => e.CardAuthNo)
                .IsUnicode(false);

            modelBuilder.Entity<Payment>()
                .Property(e => e.CardTroutD)
                .IsUnicode(false);

            modelBuilder.Entity<Payment>()
                .Property(e => e.GiftAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Payment>()
                .Property(e => e.GiftNo)
                .IsUnicode(false);

            modelBuilder.Entity<Payment>()
                .Property(e => e.GiftAuthNo)
                .IsUnicode(false);

            modelBuilder.Entity<Payment>()
                .Property(e => e.GiftTroutD)
                .IsUnicode(false);

            modelBuilder.Entity<Payment>()
                .Property(e => e.CardMasked)
                .IsUnicode(false);

            modelBuilder.Entity<Payment>()
                .Property(e => e.CardToken)
                .IsUnicode(false);

            modelBuilder.Entity<Payment>()
                .Property(e => e.EcBlock)
                .IsUnicode(false);

            modelBuilder.Entity<Payment>()
                .Property(e => e.EcKey)
                .IsUnicode(false);

            modelBuilder.Entity<Physical>()
                .Property(e => e.Rack)
                .IsUnicode(false);

            modelBuilder.Entity<PostalCode>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<PostalCode>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<PostalCode>()
                .Property(e => e.PostalCode1)
                .IsUnicode(false);

            modelBuilder.Entity<Preference>()
                .Property(e => e.Preference1)
                .IsUnicode(false);

            modelBuilder.Entity<Preference>()
                .Property(e => e.Preference2)
                .IsUnicode(false);

            modelBuilder.Entity<Preference>()
                .Property(e => e.Preference3)
                .IsUnicode(false);

            modelBuilder.Entity<Preference>()
                .Property(e => e.Preference4)
                .IsUnicode(false);

            modelBuilder.Entity<Preference>()
                .Property(e => e.Preference5)
                .IsUnicode(false);

            modelBuilder.Entity<Preference>()
                .Property(e => e.Preference6)
                .IsUnicode(false);

            modelBuilder.Entity<Preference>()
                .Property(e => e.Preference7)
                .IsUnicode(false);

            modelBuilder.Entity<Preference>()
                .Property(e => e.Disclaimer1)
                .IsUnicode(false);

            modelBuilder.Entity<Preference>()
                .Property(e => e.NewCustMessage)
                .IsUnicode(false);

            modelBuilder.Entity<Preference>()
                .Property(e => e.Preference8)
                .IsUnicode(false);

            modelBuilder.Entity<Preference>()
                .Property(e => e.ReceiptMessage)
                .IsUnicode(false);

            modelBuilder.Entity<Preference>()
                .Property(e => e.BlankOnWrite)
                .IsUnicode(false);

            modelBuilder.Entity<Preference>()
                .Property(e => e.BlankOnCashOut)
                .IsUnicode(false);

            modelBuilder.Entity<Preference>()
                .Property(e => e.Preference9)
                .IsUnicode(false);

            modelBuilder.Entity<Preference>()
                .Property(e => e.ScrollMarquee)
                .IsUnicode(false);

            modelBuilder.Entity<Preference>()
                .Property(e => e.TotalDueMarquee)
                .IsUnicode(false);

            modelBuilder.Entity<Preference>()
                .Property(e => e.ChangeMarquee)
                .IsUnicode(false);

            modelBuilder.Entity<Preference>()
                .Property(e => e.Preference10)
                .IsUnicode(false);

            modelBuilder.Entity<Preference>()
                .Property(e => e.WODisclaimer)
                .IsUnicode(false);

            modelBuilder.Entity<Preference>()
                .Property(e => e.Preference11)
                .IsUnicode(false);

            modelBuilder.Entity<Preference>()
                .Property(e => e.BlankEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Preference>()
                .Property(e => e.Preference12)
                .IsUnicode(false);

            modelBuilder.Entity<Preference>()
                .Property(e => e.CTDisclaimer)
                .IsUnicode(false);

            modelBuilder.Entity<Preference>()
                .Property(e => e.PrintCardAgreeOver)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Preference>()
                .Property(e => e.DefaultCardBillBatch)
                .IsUnicode(false);

            modelBuilder.Entity<PurgedCust>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<PurgedCust>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<PurgedCust>()
                .Property(e => e.Addr1)
                .IsUnicode(false);

            modelBuilder.Entity<PurgedCust>()
                .Property(e => e.Addr2)
                .IsUnicode(false);

            modelBuilder.Entity<PurgedCust>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<PurgedCust>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<PurgedCust>()
                .Property(e => e.Zip)
                .IsUnicode(false);

            modelBuilder.Entity<Reason>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Receipt>()
                .Property(e => e.SigString)
                .IsUnicode(false);

            modelBuilder.Entity<Recurring>()
                .Property(e => e.MinimumBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Recurring>()
                .Property(e => e.DollarsOff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Recurring>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Recurring>()
                .Property(e => e.PrintDescription)
                .IsUnicode(false);

            modelBuilder.Entity<RouteItem>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<RouteItem>()
                .Property(e => e.PrintCode)
                .IsUnicode(false);

            modelBuilder.Entity<RouteItem>()
                .Property(e => e.RouteAgent)
                .IsUnicode(false);

            modelBuilder.Entity<RouteItem>()
                .Property(e => e.RouteExportPath)
                .IsUnicode(false);

            modelBuilder.Entity<RouteStop>()
                .Property(e => e.Directions)
                .IsUnicode(false);

            modelBuilder.Entity<RouteStop>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<RouteStop>()
                .Property(e => e.DeliveryName)
                .IsUnicode(false);

            modelBuilder.Entity<RouteStop>()
                .Property(e => e.DeliveryAddr1)
                .IsUnicode(false);

            modelBuilder.Entity<RouteStop>()
                .Property(e => e.DeliveryAddr2)
                .IsUnicode(false);

            modelBuilder.Entity<RouteStop>()
                .Property(e => e.DeliveryCity)
                .IsUnicode(false);

            modelBuilder.Entity<RouteStop>()
                .Property(e => e.DeliveryState)
                .IsUnicode(false);

            modelBuilder.Entity<RouteStop>()
                .Property(e => e.DeliveryZip)
                .IsUnicode(false);

            modelBuilder.Entity<SalesTax>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<SalesTax>()
                .Property(e => e.TaxName)
                .IsUnicode(false);

            modelBuilder.Entity<ScanLog>()
                .Property(e => e.Rack)
                .IsUnicode(false);

            modelBuilder.Entity<ScanLog>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ScanLog>()
                .Property(e => e.EmployeeName)
                .IsUnicode(false);

            modelBuilder.Entity<SOFBatch>()
                .Property(e => e.BatchDWM)
                .IsUnicode(false);

            modelBuilder.Entity<SOFBatch>()
                .Property(e => e.CardNo)
                .IsUnicode(false);

            modelBuilder.Entity<SOFBatch>()
                .Property(e => e.ExpDate)
                .IsUnicode(false);

            modelBuilder.Entity<SOFBatch>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SOFBatch>()
                .Property(e => e.Member)
                .IsUnicode(false);

            modelBuilder.Entity<SOFBatch>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<SOFBatch>()
                .Property(e => e.Zip)
                .IsUnicode(false);

            modelBuilder.Entity<SOFBatch>()
                .Property(e => e.AuthNo)
                .IsUnicode(false);

            modelBuilder.Entity<SOFBatch>()
                .Property(e => e.AuthRef)
                .IsUnicode(false);

            modelBuilder.Entity<SOFBatch>()
                .Property(e => e.CardMasked)
                .IsUnicode(false);

            modelBuilder.Entity<SOFBatch>()
                .Property(e => e.DeclineTextResponse)
                .IsUnicode(false);

            modelBuilder.Entity<SOFBatch>()
                .Property(e => e.DeclineErrorCode)
                .IsUnicode(false);

            modelBuilder.Entity<StatementBalance>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<StatementHistory>()
                .Property(e => e.TransDescription)
                .IsUnicode(false);

            modelBuilder.Entity<StatementHistory>()
                .Property(e => e.TransAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Stock>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Stock>()
                .Property(e => e.SKU)
                .IsUnicode(false);

            modelBuilder.Entity<Stock>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Stock>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Store>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.ZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.ModemNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.FaxNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.EMailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.LogoPath)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.RegistrationNo)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.StName)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.StAddress1)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.StAddress2)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.StCity)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.StState)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.StZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.StPhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.StFaxNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.StRegistrationNo)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.StoreHours)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.StStoreHours)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.CardMerchant)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.CardBillMerchant)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.DebitMerchant)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.GiftMerchant)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.CardProcessor)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.DebitProcessor)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.GiftProcessor)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.WebSite)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.WebSiteText)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.WebSiteTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.ImageFolder)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.WebSiteImageFolder)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.CAIPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<TaxAuthority>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TimeCard>()
                .Property(e => e.WorkType)
                .IsUnicode(false);

            modelBuilder.Entity<TimeCard>()
                .Property(e => e.AccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Version>()
                .Property(e => e.VersionName)
                .IsUnicode(false);

            modelBuilder.Entity<WirelessCarrier>()
                .Property(e => e.Company)
                .IsUnicode(false);

            modelBuilder.Entity<WirelessCarrier>()
                .Property(e => e.TextAddress)
                .IsUnicode(false);
        }
    }
}
