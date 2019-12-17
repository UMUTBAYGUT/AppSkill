using AppSkill.Model.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppSkill.Core.TestDatas
{
    public static class SalesChannelTestData
    {
        public static IQueryable<SalesChannel> Locations
        {
            get
            {
                return new List<SalesChannel>
                {
                    new SalesChannel{SalesChannelId=1,ChannelName="Mobil" },
                    new SalesChannel{SalesChannelId=2,ChannelName="Internet" }

                }.AsQueryable();
            }
        }
    }
}
