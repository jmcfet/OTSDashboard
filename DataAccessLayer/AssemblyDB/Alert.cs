namespace DataAccessLayer.AssemblyDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Alert
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AlertID { get; set; }

        [StringLength(50)]
        public string AlertWord { get; set; }
    }
}
