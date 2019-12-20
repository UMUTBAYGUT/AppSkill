using System;
using System.Collections.Generic;
using AppSkill.Core;
using AppSkill.Model.Database;
using AppSkill.Core.Paging;

namespace AppSkill.Operation.Operation
{
    public class LocationOperation
    {
        public IUnitOfWork IAppDb { get; set; }

        public LocationOperation() : this(null)
        {

        }

        public LocationOperation(IUnitOfWork db)
        {
            IAppDb = db;
        }

        public IPaginate<Location> GetAllLocations()
        {
           return IAppDb.GetRepository<Location>().GetList();
        }
    }
}
