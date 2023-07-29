namespace version1._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Company")]
    public partial class Company
    {
        public int companyId { get; set; }

        [Required]
        public string companyName { get; set; }

        [Required]
        public string companyAddress { get; set; }

        [Required]
        [StringLength(100)]
        public string companyGstin { get; set; }

        [Required]
        [StringLength(20)]
        public string companyPanNo { get; set; }
    }
}
