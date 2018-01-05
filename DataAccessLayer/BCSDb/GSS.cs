namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GSS")]
    public partial class GSS
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string barcode { get; set; }

        public int bin { get; set; }

        public DateTime time { get; set; }

        [StringLength(10)]
        public string temp { get; set; }

        [StringLength(10)]
        public string temp1 { get; set; }

        [StringLength(10)]
        public string temp2 { get; set; }

        [StringLength(10)]
        public string temp3 { get; set; }
    }
}
