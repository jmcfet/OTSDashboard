namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DeliveryCenter
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeliveryCustomerID { get; set; }

        [StringLength(40)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool Deleted { get; set; }
    }
}
