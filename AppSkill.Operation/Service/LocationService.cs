using System;
using System.Collections.Generic;
using AppSkill.Core;
using AppSkill.Core.Paging;
using AppSkill.Model.Database;
using AppSkill.Operation.Operation;

namespace AppSkill.Operation
{

    public partial class AppSkillService : IAppSkillService
    {
        public IPaginate<Location> GetAllLocations()
        {
            LocationOperation op = new LocationOperation(AppDb);
            return op.GetAllLocations();
        }
    }
}
