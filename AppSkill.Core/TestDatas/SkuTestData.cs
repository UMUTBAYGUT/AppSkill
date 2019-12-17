using AppSkill.Model.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppSkill.Core.TestDatas
{
    public static class SkuTestData
    {
        public static IQueryable<Sku> Skus
        {
            
            get
            {
                return new List<Sku>
                {
                    new Sku{SkuId=1,Title="Mouse", LocationId=1,SalesChannels=new List<SalesChannel>{ new SalesChannel { ChannelName="Mobil",SalesChannelId=1} },Quantity=10 },
                    new Sku{SkuId=2,Title="Keyboard",LocationId=2,SalesChannels=new List<SalesChannel>{ new SalesChannel { ChannelName="Mobil",SalesChannelId=1} },Quantity=10  },
                    new Sku{SkuId=3,Title="Mouse", LocationId=2,SalesChannels=new List<SalesChannel>{ new SalesChannel { ChannelName="Mobil",SalesChannelId=1} },Quantity=10  },
                    new Sku{SkuId=4,Title="Keyboard",LocationId=1,SalesChannels=new List<SalesChannel>{ new SalesChannel { ChannelName="Internet",SalesChannelId=2} },Quantity=10  }

                }.AsQueryable();
            }
        }
    }
}
