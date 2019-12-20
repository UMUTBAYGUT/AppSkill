using System;
using AppSkill.Core.Paging;
using AppSkill.Model.Database;

namespace AppSkill.Operation
{
    public partial interface IAppSkillService
    {
        IPaginate<Location> GetAllLocations();
    }
}
