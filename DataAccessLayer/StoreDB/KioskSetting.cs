namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KioskSetting
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KioskID { get; set; }

        [StringLength(12)]
        public string ComSettings { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComPort { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TimeOut { get; set; }

        [StringLength(100)]
        public string IPAddress { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Port { get; set; }

        [StringLength(100)]
        public string HomeTitle { get; set; }

        [StringLength(1000)]
        public string Home1 { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool UseSignup { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool UseRegistration { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool UsePrivacy { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool UseAgreement { get; set; }

        [StringLength(100)]
        public string RegistrationTitle { get; set; }

        [StringLength(100)]
        public string SignupTitle { get; set; }

        [StringLength(1000)]
        public string Signup1 { get; set; }

        [StringLength(100)]
        public string PrivacyTitle { get; set; }

        [StringLength(5000)]
        public string Privacy { get; set; }

        [StringLength(100)]
        public string AgreementTitle { get; set; }

        [StringLength(5000)]
        public string Agreement { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreColor { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PanelColor { get; set; }

        [StringLength(50)]
        public string TitleFont { get; set; }

        [StringLength(50)]
        public string PanelFont { get; set; }

        [StringLength(50)]
        public string LegalFont { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool UseWebHomePage { get; set; }

        [StringLength(500)]
        public string HomeURL { get; set; }

        [StringLength(500)]
        public string HomeHtmlFilePath { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool UseWebSignupPage { get; set; }

        [StringLength(500)]
        public string SignupURL { get; set; }

        [StringLength(500)]
        public string SignupHtmlFilePath { get; set; }

        [StringLength(12)]
        public string Reload { get; set; }

        [StringLength(12)]
        public string AppOOS { get; set; }

        [StringLength(12)]
        public string ScanTest { get; set; }

        [StringLength(12)]
        public string AppClose { get; set; }
    }
}
