namespace version1._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DeliveryMethod")]
    public partial class DeliveryMethod
    {
        public int DeliveryMethodID { get; set; }

        [Required]
        [StringLength(100)]
        public string DeliveryMethodType { get; set; }
    }
}
