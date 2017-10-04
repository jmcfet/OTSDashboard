namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BillingCycle
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BillCycleID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PrintFormID { get; set; }

        [StringLength(25)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 2)]
        public float FinApr { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "money")]
        public decimal MinCharge { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "money")]
        public decimal MinBalance { get; set; }

        [StringLength(105)]
        public string Message1 { get; set; }

        [StringLength(105)]
        public string Message2 { get; set; }

        [StringLength(105)]
        public string Message3 { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool Deleted { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool CustomStatements { get; set; }
    }
}
