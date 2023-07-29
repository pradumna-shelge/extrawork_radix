namespace version1._0.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DatabaseContex : DbContext
    {
        public DatabaseContex()
            : base("name=DatabaseContex")
        {
        }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<DeliveryMethod> DeliveryMethods { get; set; }
        public virtual DbSet<OrderData> OrderDatas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
