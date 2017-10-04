namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lot
    {
        public int? LotID { get; set; }

        [StringLength(16)]
        public string Name { get; set; }

        public int? StartLot { get; set; }

        public int? EndLot { get; set; }

        public int? CurrentLot { get; set; }

        public int? StartCount { get; set; }

        public int? EndCount { get; set; }

        public int? CurrentCount { get; set; }

        [StringLength(10)]
        public string LotColor { get; set; }

        public int? CountType { get; set; }

        [Key]
        [Column(Order = 0)]
        public bool Deleted { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TagStyleID { get; set; }

        [StringLength(80)]
        public string ForcedStations { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool ForceNewLot { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CurrentColor { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool EnableLotControlRails { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool RotateLotColor { get; set; }

        [StringLength(10)]
        public string Color1 { get; set; }

        [StringLength(10)]
        public string Color2 { get; set; }

        [StringLength(10)]
        public string Color3 { get; set; }

        [StringLength(10)]
        public string Color4 { get; set; }

        [StringLength(10)]
        public string Color5 { get; set; }

        [StringLength(10)]
        public string Color6 { get; set; }

        [StringLength(10)]
        public string Color7 { get; set; }

        [StringLength(10)]
        public string Color8 { get; set; }

        [StringLength(10)]
        public string Color9 { get; set; }

        [StringLength(10)]
        public string Color10 { get; set; }

        [StringLength(10)]
        public string Color11 { get; set; }

        [StringLength(10)]
        public string Color12 { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool ChangeTagRollColor { get; set; }
    }
}
