namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bin
    {
        public int ID { get; set; }

        public string BarCode { get; set; }

        public string Weight { get; set; }

        public string MaxWeight { get; set; }

        public int Category { get; set; }

        public int PhigidSlot { get; set; }

        public virtual Category Category1 { get; set; }
    }
}
