using System;
using System.Collections.Generic;
using AppSkill.Core;
using AppSkill.Model.Database;
using AppSkill.Core.Paging;

namespace AppSkill.Operation.Operation
{
    public class LocationOperation
    {

        public LocationOperation()
        {
        }

        public IPaginate<Location> GetAllLocations(IUnitOfWork uow)
        {
           return uow.GetRepository<Location>().GetList();
        }

        public void AddLocation(IUnitOfWork uow,Location entity)
        {
             uow.GetRepository<Location>().Add(entity);
        }
    }
}
