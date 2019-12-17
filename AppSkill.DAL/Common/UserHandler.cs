using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using AppSkill.DAL.Data;
using AppSkill.Model.Database;


namespace AppSkill.DAL.Common
{
    public class UserHandler
    {
        private IMockProjectDbContext _DbContext;

        public UserHandler(IMockProjectDbContext DbContext)
        {
            _DbContext = DbContext;
        }

        public async Task<Sku> GetSkusByLocation(string location)
        {
            var sku = await _DbContext.Skus.Where(x => x.Location.Equals(location)).FirstOrDefaultAsync();
            if (sku != null)
                return sku;
            return null;
        }

        public async Task<Sku> GetAvailablity(SalesChannel salesChannel, List<Sku> Skus)
        {
            var sku = await _DbContext.Skus.Where(x => x.SalesChannels.Contains(salesChannel)).FirstOrDefaultAsync();
            if (sku != null)
                return sku;
            return null;
        }
    }
}
