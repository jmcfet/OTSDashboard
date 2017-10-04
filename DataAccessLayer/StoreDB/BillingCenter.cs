namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BillingCenter
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BillCenterID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        [StringLength(25)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "money")]
        public decimal ChargeLimit { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool Deleted { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool IsInvoiceAddr { get; set; }
    }
}
