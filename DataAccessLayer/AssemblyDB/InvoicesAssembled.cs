namespace DataAccessLayer.AssemblyDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvoicesAssembled")]
    public partial class InvoicesAssembled
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvAssembledID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvoiceID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AssemblyInvoiceID { get; set; }

        public DateTime? LogDate { get; set; }

        public DateTime? DueDate { get; set; }

        [StringLength(50)]
        public string CustomerName { get; set; }

        [StringLength(20)]
        public string Department { get; set; }

        [StringLength(5)]
        public string SlotUsed { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool Deleted { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConveyorID { get; set; }
    }
}
