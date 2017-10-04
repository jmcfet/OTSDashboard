namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Preference
    {
        public int? StoreID { get; set; }

        [StringLength(25)]
        public string Preference1 { get; set; }

        [StringLength(25)]
        public string Preference2 { get; set; }

        [StringLength(25)]
        public string Preference3 { get; set; }

        [StringLength(25)]
        public string Preference4 { get; set; }

        [StringLength(25)]
        public string Preference5 { get; set; }

        [StringLength(25)]
        public string Preference6 { get; set; }

        [StringLength(25)]
        public string Preference7 { get; set; }

        [StringLength(1000)]
        public string Disclaimer1 { get; set; }

        [StringLength(1000)]
        public string NewCustMessage { get; set; }

        [StringLength(25)]
        public string Preference8 { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HeatsealStyleID { get; set; }

        [StringLength(200)]
        public string ReceiptMessage { get; set; }

        [StringLength(250)]
        public string BlankOnWrite { get; set; }

        [StringLength(250)]
        public string BlankOnCashOut { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AllDrawerStationID { get; set; }

        [StringLength(25)]
        public string Preference9 { get; set; }

        [StringLength(400)]
        public string ScrollMarquee { get; set; }

        [StringLength(20)]
        public string TotalDueMarquee { get; set; }

        [StringLength(20)]
        public string ChangeMarquee { get; set; }

        [StringLength(25)]
        public string Preference10 { get; set; }

        [StringLength(1000)]
        public string WODisclaimer { get; set; }

        [StringLength(25)]
        public string Preference11 { get; set; }

        [StringLength(250)]
        public string BlankEmail { get; set; }

        [StringLength(25)]
        public string Preference12 { get; set; }

        [StringLength(1000)]
        public string CTDisclaimer { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "money")]
        public decimal PrintCardAgreeOver { get; set; }

        [StringLength(1)]
        public string DefaultCardBillBatch { get; set; }
    }
}
