namespace version1._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderData")]
    public partial class OrderData
    {
        [StringLength(100)]
        public string id { get; set; }

        [Column("orderData")]
        public string orderData1 { get; set; }
    }
}
