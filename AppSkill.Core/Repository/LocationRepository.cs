﻿using AppSkill.DAL;
using AppSkill.Model.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AppSkill.Core.Repository
{
    public interface ILocationRepository : IRepository<Location>
    {

    }
    public class LocationRepository : ILocationRepository
    {
        AppSkillDbContextPostreSql _db;

        public LocationRepository(AppSkillDbContextPostreSql DbContext)
        {
            _db = DbContext;
        }


        public int Count()
        {
            return _db.Locations.Count();
        }

        public bool Delete(int id)
        {
            try

            {

                Location _obj = _db.Locations.FirstOrDefault(us => us.LocationId == id);

                if (_obj != null)

                {

                    _db.Locations.Remove(_obj);

                }

                else

                {

                    return false;

                }

                return true;

            }

            catch

            {

                return false;

            }
        }

        public Location Get(Expression<Func<Location, bool>> expression)
        {
            return _db.Locations.FirstOrDefault(expression);
        }

        public IEnumerable<Location> GetAll()
        {
            return _db.Locations.Select(a => a);
        }

        public Location GetById(int id)
        {
            return _db.Locations.FirstOrDefault(a => a.LocationId == id);
        }

        public IQueryable<Location> GetMany(Expression<Func<Location, bool>> expression)
        {
            return _db.Locations.Where(expression);
        }

        public bool Insert(Location obj)
        {
            try

            {

                _db.Locations.Add(obj);

                return true;

            }

            catch

            {

                return false;

            }
        }

        public bool Save()
        {
            try

            {
                
                _db.SaveChanges();

                return true;

            }

            catch (Exception e)

            {

                var a = e.Message;

                return false;

            }
        }

        public bool Update(Location obj)
        {
            try

            {

                _db.Locations.Update(obj);

                return true;

            }

            catch

            {

                return false;

            }
        }
    }
}
