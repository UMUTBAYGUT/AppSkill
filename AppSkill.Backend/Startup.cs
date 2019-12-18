using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using AppSkill.DAL;
using Microsoft.EntityFrameworkCore;
using AppSkill.Core.Repository;

namespace AppSkill.Backend
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddEntityFrameworkNpgsql().AddDbContext<AppSkillDbContextPostreSql>(opt =>
            opt.UseNpgsql(Configuration.GetConnectionString("PostgreConnection")));
            services.AddTransient<ILocationRepository, LocationRepository>();
            services.AddTransient<ILocationSalesChannelRelationRepository, LocationSalesChannelRelationRepository>();
            services.AddTransient<ISalesChannelRepository, SalesChannelRepository>();
            services.AddTransient<ISalesChannelSkuRelationRepository, SalesChannelSkuRelationRepository>();
            services.AddTransient<ISkuRepository, SkuRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
