using System;
using AppSkill.Core;

namespace AppSkill.Operation
{
    public partial class AppSkillService : IAppSkillService
    {
        public IUnitOfWork AppDb { get; set; }
    }
}
