using System;
using System.Data.Common;
using AppSkill.Model.Database;
using Microsoft.EntityFrameworkCore;

namespace AppSkill.DAL
{
    public  class AppSkillDbContextPostreSql : DbContext
    {

        public AppSkillDbContextPostreSql(DbContextOptions<AppSkillDbContextPostreSql> options) : base(options) {}

        /*  public static void Configure(DbContextOptionsBuilder<AppSkillDbContextPostreSql> builder, string connectionString)
          {
              builder.UseNpgsql(connectionString);
          }

          public static void Configure(DbContextOptionsBuilder<AppSkillDbContextPostreSql> builder, DbConnection connection)
          {
              builder.UseNpgsql(connection);
          }*/

        public virtual DbSet<Sku> Skus { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<SalesChannel> SalesChannels { get; set; }
        public virtual DbSet<LocationSalesChannelRelation> LocationSalesChannelRelations { get; set; }
        public virtual DbSet<SalesChannelSkuRelation> SalesChannelSkuRelations { get; set; }
    }
}
