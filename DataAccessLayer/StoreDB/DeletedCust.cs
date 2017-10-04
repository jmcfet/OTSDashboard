namespace DataAccessLayer.StoreDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DeletedCust
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        [StringLength(30)]
        public string LastName { get; set; }

        [StringLength(20)]
        public string FirstName { get; set; }

        [StringLength(30)]
        public string Addr1 { get; set; }

        [StringLength(20)]
        public string Addr2 { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(3)]
        public string State { get; set; }

        [StringLength(10)]
        public string Zip { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeID { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool CanBill { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool BillToOffice { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool SOFInStore { get; set; }

        public DateTime? LastOrder { get; set; }

        public DateTime? LastCashOut { get; set; }

        public DateTime? OpenDate { get; set; }

        public DateTime? DeleteDate { get; set; }
    }
}
