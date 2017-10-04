namespace DataAccessLayer.AssemblyDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AssemblySetting
    {
        [Key]
        [Column(Order = 0)]
        public bool MakeSuborders { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool UnloadNoWait { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool SaveOutfiles { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool ShowAllExtractions { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool UsePercentOnly { get; set; }

        [StringLength(4)]
        public string MaxPerc { get; set; }

        [StringLength(3)]
        public string MaxItems { get; set; }

        [StringLength(100)]
        public string LogFilesFolder { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PollingDelay { get; set; }
    }
}
