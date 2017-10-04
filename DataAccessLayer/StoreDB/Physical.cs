namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Physical")]
    public partial class Physical
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvoiceID { get; set; }

        [StringLength(6)]
        public string Rack { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool Status { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Deleted { get; set; }
    }
}
