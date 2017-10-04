namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Appointment
    {
        public string Subject { get; set; }

        public string Location { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public string Body { get; set; }

        public string temp1 { get; set; }

        [MaxLength(50)]
        public byte[] temp2 { get; set; }

        [MaxLength(50)]
        public byte[] temp3 { get; set; }

        public int ID { get; set; }

        public int? userid { get; set; }
    }
}
