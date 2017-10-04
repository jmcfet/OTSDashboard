namespace DataAccessLayer.AssemblyDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;  

    public partial class Assembly : DbContext
    {
        public Assembly()
            : base("name=Assembly1")
        {
        }

        public virtual DbSet<Alert> Alerts { get; set; }
        public virtual DbSet<AssemAutoNumber> AssemAutoNumbers { get; set; }
        public virtual DbSet<AssemblyBay> AssemblyBays { get; set; }
        public virtual DbSet<AssemblySetting> AssemblySettings { get; set; }
        public virtual DbSet<AutoSort> AutoSorts { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoicesAssembled> InvoicesAssembleds { get; set; }
        public virtual DbSet<InvoicesTest> InvoicesTests { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<StorageInvoice> StorageInvoices { get; set; }
        public virtual DbSet<Version> Versions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alert>()
                .Property(e => e.AlertWord)
                .IsUnicode(false);

            modelBuilder.Entity<AssemblySetting>()
                .Property(e => e.MaxPerc)
                .IsUnicode(false);

            modelBuilder.Entity<AssemblySetting>()
                .Property(e => e.MaxItems)
                .IsUnicode(false);

            modelBuilder.Entity<AssemblySetting>()
                .Property(e => e.LogFilesFolder)
                .IsUnicode(false);

            modelBuilder.Entity<AutoSort>()
                .Property(e => e.StoreInvoiceID)
                .IsUnicode(false);

            modelBuilder.Entity<AutoSort>()
                .Property(e => e.PieceTotal)
                .IsUnicode(false);

            modelBuilder.Entity<AutoSort>()
                .Property(e => e.ItemNumber)
                .IsUnicode(false);

            modelBuilder.Entity<AutoSort>()
                .Property(e => e.ArticleCode)
                .IsUnicode(false);

            modelBuilder.Entity<AutoSort>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<AutoSort>()
                .Property(e => e.OccPercent)
                .IsUnicode(false);

            modelBuilder.Entity<AutoSort>()
                .Property(e => e.Hung)
                .IsUnicode(false);

            modelBuilder.Entity<AutoSort>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<AutoSort>()
                .Property(e => e.Conveyor)
                .IsUnicode(false);

            modelBuilder.Entity<AutoSort>()
                .Property(e => e.Slot)
                .IsUnicode(false);

            modelBuilder.Entity<AutoSort>()
                .Property(e => e.Out)
                .IsUnicode(false);

            modelBuilder.Entity<AutoSort>()
                .Property(e => e.Customer)
                .IsUnicode(false);

            modelBuilder.Entity<AutoSort>()
                .Property(e => e.RFID)
                .IsUnicode(false);

            modelBuilder.Entity<AutoSort>()
                .Property(e => e.Arm)
                .IsUnicode(false);

            modelBuilder.Entity<AutoSort>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<AutoSort>()
                .Property(e => e.BagLabel1)
                .IsUnicode(false);

            modelBuilder.Entity<AutoSort>()
                .Property(e => e.BagLabel2)
                .IsUnicode(false);

            modelBuilder.Entity<AutoSort>()
                .Property(e => e.BagLabel3)
                .IsUnicode(false);

            modelBuilder.Entity<AutoSort>()
                .Property(e => e.BagLabel4)
                .IsUnicode(false);

            modelBuilder.Entity<AutoSort>()
                .Property(e => e.BagLabel5)
                .IsUnicode(false);

            modelBuilder.Entity<AutoSort>()
                .Property(e => e.BagLabel6)
                .IsUnicode(false);

            modelBuilder.Entity<AutoSort>()
                .Property(e => e.FlagTag)
                .IsUnicode(false);

            modelBuilder.Entity<AutoSort>()
                .Property(e => e.BagLabel7)
                .IsUnicode(false);

            modelBuilder.Entity<AutoSort>()
                .Property(e => e.BagLabel8)
                .IsUnicode(false);

            modelBuilder.Entity<AutoSort>()
                .Property(e => e.BagLabel9)
                .IsUnicode(false);

            modelBuilder.Entity<AutoSort>()
                .Property(e => e.BagLabel10)
                .IsUnicode(false);

            modelBuilder.Entity<AutoSort>()
                .Property(e => e.BagLabel11)
                .IsUnicode(false);

            modelBuilder.Entity<AutoSort>()
                .Property(e => e.BagLabel12)
                .IsUnicode(false);

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
                .Property(e => e.SubTotal)
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

            modelBuilder.Entity<InvoicesAssembled>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<InvoicesAssembled>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<InvoicesAssembled>()
                .Property(e => e.SlotUsed)
                .IsUnicode(false);

            modelBuilder.Entity<InvoicesTest>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<InvoicesTest>()
                .Property(e => e.Rack)
                .IsUnicode(false);

            modelBuilder.Entity<InvoicesTest>()
                .Property(e => e.LotInfo)
                .IsUnicode(false);

            modelBuilder.Entity<InvoicesTest>()
                .Property(e => e.Taxable)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoicesTest>()
                .Property(e => e.TaxTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoicesTest>()
                .Property(e => e.SubTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoicesTest>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoicesTest>()
                .Property(e => e.PaidAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoicesTest>()
                .Property(e => e.CoupTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoicesTest>()
                .Property(e => e.DiscTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoicesTest>()
                .Property(e => e.CoupDiscable)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoicesTest>()
                .Property(e => e.SrvFeeable)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoicesTest>()
                .Property(e => e.SrvFeeTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoicesTest>()
                .Property(e => e.HotelRoom)
                .IsUnicode(false);

            modelBuilder.Entity<InvoicesTest>()
                .Property(e => e.GuestName)
                .IsUnicode(false);

            modelBuilder.Entity<InvoicesTest>()
                .Property(e => e.Taxable1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoicesTest>()
                .Property(e => e.Taxable2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoicesTest>()
                .Property(e => e.Taxable3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoicesTest>()
                .Property(e => e.TaxTotal1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoicesTest>()
                .Property(e => e.TaxTotal2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoicesTest>()
                .Property(e => e.TaxTotal3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoicesTest>()
                .Property(e => e.OriginalTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoicesTest>()
                .Property(e => e.BaggerMemo)
                .IsUnicode(false);

            modelBuilder.Entity<StorageInvoice>()
                .Property(e => e.Slot)
                .IsUnicode(false);

            modelBuilder.Entity<Version>()
                .Property(e => e.VersionName)
                .IsUnicode(false);
        }
    }
}
