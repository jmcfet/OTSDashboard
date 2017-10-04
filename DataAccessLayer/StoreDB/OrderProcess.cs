namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderProcess")]
    public partial class OrderProcess
    {
        [StringLength(30)]
        public string PlantName { get; set; }

        [StringLength(6)]
        public string PlantLocation { get; set; }

        [Key]
        [Column(Order = 0)]
        public bool IsPlantSent { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool IsAlphaRacked { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool CreateSBF { get; set; }

        [StringLength(500)]
        public string SBFPath { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool AutoRecSend { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool EnableAutoAssembly { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool IsPhoneRacked { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool UseCRDN { get; set; }

        [StringLength(500)]
        public string CRDNPath { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool UseDCTYD { get; set; }

        [StringLength(500)]
        public string DCTYDPath { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool UsePressed4T { get; set; }

        [StringLength(200)]
        public string FranchiseeList { get; set; }

        [StringLength(200)]
        public string FranchiseePasswords { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConveyorSelect { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool UseHMCFetch { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool UseKioskAndCounter { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KioskID { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvoicePrinterID { get; set; }

        [Key]
        [Column(Order = 14)]
        public bool UseAutoBagger { get; set; }

        [Key]
        [Column(Order = 15)]
        public bool UseBAMStorage { get; set; }

        [Key]
        [Column(Order = 16)]
        public bool UseBAMStorageRoutes { get; set; }

        [Key]
        [Column(Order = 17)]
        public bool UseBAMStorageCounter { get; set; }

        [Key]
        [Column(Order = 18)]
        public bool UseBAMStorageTransfer { get; set; }

        [Key]
        [Column(Order = 19)]
        public bool IsMAPBAMStore { get; set; }

        [Key]
        [Column(Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BAMCounterArm { get; set; }

        [Key]
        [Column(Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BAMRouteArm { get; set; }

        [Key]
        [Column(Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BAMTransferArm { get; set; }

        [StringLength(10)]
        public string BaggerStoreCode { get; set; }

        [Key]
        [Column(Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Bagline0 { get; set; }

        [Key]
        [Column(Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Bagline1 { get; set; }

        [Key]
        [Column(Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Bagline2 { get; set; }

        [Key]
        [Column(Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Bagline3 { get; set; }

        [Key]
        [Column(Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Bagline4 { get; set; }

        [Key]
        [Column(Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Bagline5 { get; set; }

        [Key]
        [Column(Order = 29)]
        public bool EnableBaggerBypass { get; set; }

        [Key]
        [Column(Order = 30)]
        public bool BypassFoldedShirts { get; set; }

        [Key]
        [Column(Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BaggerBypassArm { get; set; }

        [Key]
        [Column(Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BAMRouteArm2 { get; set; }

        [Key]
        [Column(Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BAMRouteArm3 { get; set; }

        [Key]
        [Column(Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BAMRouteArm4 { get; set; }

        [Key]
        [Column(Order = 35)]
        public bool EnableFPM { get; set; }

        [Key]
        [Column(Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HighestRackLocation { get; set; }

        [Key]
        [Column(Order = 37)]
        public bool EnableDropLocker { get; set; }

        [Key]
        [Column(Order = 38)]
        public bool IsFPMStore { get; set; }

        [Key]
        [Column(Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BagLine6 { get; set; }

        [Key]
        [Column(Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BagLine7 { get; set; }

        [Key]
        [Column(Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BagLine8 { get; set; }

        [Key]
        [Column(Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BagLine9 { get; set; }

        [Key]
        [Column(Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BagLine10 { get; set; }

        [Key]
        [Column(Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BagLine11 { get; set; }

        [Key]
        [Column(Order = 45)]
        public bool UseBAMStorageKiosk { get; set; }

        [Key]
        [Column(Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BAMKioskArm { get; set; }

        [Key]
        [Column(Order = 47)]
        public bool EnableAPIRouteOrders { get; set; }

        [Key]
        [Column(Order = 48)]
        public bool EnableAPIMobileRoute { get; set; }
    }
}
