namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GLAccount
    {
        public int? GLAccountID { get; set; }

        [StringLength(30)]
        public string Description { get; set; }

        public float? SortOrder { get; set; }

        public int? TypeID { get; set; }

        [StringLength(30)]
        public string TypeDescription { get; set; }

        [Key]
        [Column(Order = 0)]
        public bool DebitBalance { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool IsSysAccount { get; set; }

        public int? ParentID { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool IsSubAccount { get; set; }

        public int? GovTaxTypeID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Balance { get; set; }

        [StringLength(6)]
        public string GLNumber { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool Deleted { get; set; }
    }
}
