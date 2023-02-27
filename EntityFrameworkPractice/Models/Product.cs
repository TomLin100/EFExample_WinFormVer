namespace EntityFrameworkPractice.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        [StringLength(50)]
        public string PID { get; set; }

        public string ProductName { get; set; }

        public int? Amount { get; set; }

        public int? Price { get; set; }

        public string ProductType { get; set; }
    }
}
