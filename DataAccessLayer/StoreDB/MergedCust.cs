namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MergedCust
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FromStoreID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FromCustomerID { get; set; }

        [StringLength(30)]
        public string FromLName { get; set; }

        [StringLength(20)]
        public string FromFName { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ToStoreID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ToCustomerID { get; set; }

        [StringLength(30)]
        public string ToLName { get; set; }

        [StringLength(20)]
        public string ToFName { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool CanBill { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool BillToOffice { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool SOFInStore { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeID { get; set; }

        public DateTime? MergeDate { get; set; }
    }
}
