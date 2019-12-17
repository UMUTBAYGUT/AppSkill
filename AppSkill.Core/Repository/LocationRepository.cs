using AppSkill.DAL.Data;
using AppSkill.Model.Database;
using Moq;
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


        private IMockProjectDbContext _db;

        List<Location> location;

        Mock<IMockProjectDbContext> _db2;


        public LocationRepository(IMockProjectDbContext DbContext)
        {
            _db = DbContext;
            _db2 = new Mock<IMockProjectDbContext>();
            _db2.SetupGet(a => a.Location);

        
        }


        public int Count()
        {
            return _db.Location.Count();
        }

        public bool Delete(int id)
        {
            try

            {

                Location _obj = _db.Location.FirstOrDefault(us => us.LocationId == id);

                if (_obj != null)

                {

                    _db.Location.Remove(_obj);

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
            return _db.Location.FirstOrDefault(expression);
        }

        public IEnumerable<Location> GetAll()
        {
            return _db.Location.Select(a => a);
        }

        public Location GetById(int id)
        {
            return _db.Location.FirstOrDefault(a => a.LocationId == id);
        }

        public IQueryable<Location> GetMany(Expression<Func<Location, bool>> expression)
        {
            return _db.Location.Where(expression);
        }

        public bool Insert(Location obj)
        {
            try

            {

                _db.Location.Add(obj);

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
                
                //_db.SaveChanges();

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

                _db.Location.Update(obj);

                return true;

            }

            catch

            {

                return false;

            }
        }
    }
}
