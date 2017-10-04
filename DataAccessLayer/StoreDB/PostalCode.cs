namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PostalCode
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PostalCodeID { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(3)]
        public string State { get; set; }

        [Column("PostalCode")]
        [StringLength(15)]
        public string PostalCode1 { get; set; }

        public int? CountryCode { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool Deleted { get; set; }
    }
}
