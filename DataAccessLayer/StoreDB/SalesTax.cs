namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalesTax")]
    public partial class SalesTax
    {
        public int? TaxID { get; set; }

        [StringLength(16)]
        public string Description { get; set; }

        [StringLength(10)]
        public string TaxName { get; set; }

        public float? TaxPercent { get; set; }

        public int? GLAccountID { get; set; }

        [Key]
        [Column(Order = 0)]
        public bool Deleted { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TaxAuthorityID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TaxTableID { get; set; }
    }
}
