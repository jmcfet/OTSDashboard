namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RouteStop
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StopID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RouteID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StopNo { get; set; }

        public DateTime? AddDate { get; set; }

        public DateTime? StopExpiration { get; set; }

        [StringLength(150)]
        public string Directions { get; set; }

        [StringLength(150)]
        public string Notes { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool Deleted { get; set; }

        [StringLength(30)]
        public string DeliveryName { get; set; }

        [StringLength(30)]
        public string DeliveryAddr1 { get; set; }

        [StringLength(20)]
        public string DeliveryAddr2 { get; set; }

        [StringLength(15)]
        public string DeliveryCity { get; set; }

        [StringLength(3)]
        public string DeliveryState { get; set; }

        [StringLength(15)]
        public string DeliveryZip { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool DMon { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool DTue { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool DWed { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool DThu { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool DFri { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool DSat { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool DSun { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool PMon { get; set; }

        [Key]
        [Column(Order = 13)]
        public bool PTue { get; set; }

        [Key]
        [Column(Order = 14)]
        public bool PWed { get; set; }

        [Key]
        [Column(Order = 15)]
        public bool PThu { get; set; }

        [Key]
        [Column(Order = 16)]
        public bool PFri { get; set; }

        [Key]
        [Column(Order = 17)]
        public bool PSat { get; set; }

        [Key]
        [Column(Order = 18)]
        public bool PSun { get; set; }
    }
}
