using System;
using AppSkill.Model.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
namespace AppSkill.DAL.Data
{
    public interface IMockProjectDbContext
    {
        DbSet<Sku> Skus { get; set; }
        DbSet<Location> Location { get; set; }
        DbSet<SalesChannel> SalesChannel { get; set; }
    }

    public class MockProjectDbContext : DbContext, IMockProjectDbContext
    {

        public MockProjectDbContext(DbContextOptions<MockProjectDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Sku> Skus { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<SalesChannel> SalesChannel { get; set; }

    }
}
