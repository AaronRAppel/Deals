using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Deals.Models.Models;
using Deals.Models.Models.Mapping;

namespace Deals.Data.Models
{
    public partial class BarDealsContext : DbContext
    {
        static BarDealsContext()
        {
            Database.SetInitializer<BarDealsContext>(null);
        }

        public BarDealsContext()
            : base("Name=BarDealsContext")
        {
        }

        public DbSet<Bar> Bars { get; set; }
        public DbSet<Deal> Deals { get; set; }
        public DbSet<Hour> Hours { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BarMap());
            modelBuilder.Configurations.Add(new DealMap());
            modelBuilder.Configurations.Add(new HourMap());
        }
    }
}
