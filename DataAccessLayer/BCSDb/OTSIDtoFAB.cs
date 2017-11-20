namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OTSIDtoFAB")]
    public partial class OTSIDtoFAB
    {
        public int id { get; set; }

        public int CatID { get; set; }

        public int FabID { get; set; }

        public string Description { get; set; }
    }
}
