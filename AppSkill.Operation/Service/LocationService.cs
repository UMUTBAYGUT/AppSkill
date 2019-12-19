using System;
using System.Collections.Generic;
using AppSkill.Core;
using AppSkill.Model.Database;
using AppSkill.Operation.Operation;

namespace AppSkill.Operation.Service
{
    public interface ILocationService<IUnitOfWork>
    {
        Core.Paging.IPaginate<Location> GetAllLocations();
        void AddLocation(Location entity);
    }

    public class LocationService : ILocationService<IUnitOfWork>
    {
        public LocationService(IUnitOfWork UOW)
        {
            _UOW = UOW;
        }
        private readonly IUnitOfWork _UOW;

        public Core.Paging.IPaginate<Location> GetAllLocations()
        {
            LocationOperation op = new LocationOperation();
            return op.GetAllLocations(_UOW);
        }

        public void AddLocation(Location entity)
        {
            LocationOperation op = new LocationOperation();
             op.AddLocation(_UOW, entity);
        }
    }
}
