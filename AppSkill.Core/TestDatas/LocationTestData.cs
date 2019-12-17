using AppSkill.Model.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppSkill.Core.TestDatas
{
    public static class LocationTestData
    {
        public static IQueryable <Location> Locations
        {
            get
            {
                return new List<Location>
                {
                    new Location{LocationId=1,LocationName="İstanbul" },
                    new Location{LocationId=1,LocationName="Diyarbakır" }

                }.AsQueryable();
            }
        }
    }
}
