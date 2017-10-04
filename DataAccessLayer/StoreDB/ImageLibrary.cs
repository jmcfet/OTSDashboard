namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImageLibrary")]
    public partial class ImageLibrary
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ImageID { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(200)]
        public string ImageFileName { get; set; }

        [StringLength(100)]
        public string LinkText { get; set; }

        [StringLength(50)]
        public string LinkTitle { get; set; }

        [StringLength(50)]
        public string MergeImageName { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool Stretch { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PixelWidth { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PixelHeight { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PercentWidth { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PercentHeight { get; set; }
    }
}
