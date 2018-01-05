namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Configuration")]
    public partial class Configuration
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string POSWindow { get; set; }

        public int? ShowPass { get; set; }
    }
}
