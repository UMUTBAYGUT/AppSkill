using System;
using System.Collections.Generic;
using AppSkill.Core;
using AppSkill.Model.Database;
using AppSkill.Operation.Operation;

namespace AppSkill.Operation.Service
{
    public interface ILocationService
    {


    }

    public class LocationService
    {
        private readonly IUnitOfWork _UOW;
        public LocationService(IUnitOfWork uow)
        {
            _UOW = uow;
        }

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
