using System;
using AppSkill.Core;
using AppSkill.DAL;
using AppSkill.Operation.Service;
using Microsoft.EntityFrameworkCore;

namespace AppSkill.Operation
{
    public interface IAppSkillService<IUnitOfWork>
    {
        ILocationService<IUnitOfWork> LocationService { get; }

    }
    public class AppSkillService : IAppSkillService<IUnitOfWork>
    {
        public AppSkillService()
        {
            
        }

        private IUnitOfWork _unit;
        private ILocationService<IUnitOfWork> _locationService;
        public ILocationService<IUnitOfWork> LocationService
        {
            get
            {
                if (_locationService == null)
                    _locationService = new LocationService();
                return _locationService;
            }
        }

    }
}
