using AppSkill.Model.Database;
using Microsoft.EntityFrameworkCore;
namespace AppSkill.DAL.Data
{
    public interface IMockProjectDbContext
    {
        DbSet<Sku> Skus { get; set; }
        DbSet<Location> Locations { get; set; }
        DbSet<SalesChannel> SalesChannels { get; set; }
    }

    public class MockProjectDbContext : DbContext, IMockProjectDbContext
    {

        public MockProjectDbContext(DbContextOptions<MockProjectDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Sku> Skus { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<SalesChannel> SalesChannels { get; set; }

    }
}
