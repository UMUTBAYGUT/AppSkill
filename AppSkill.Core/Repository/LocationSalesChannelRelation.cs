using AppSkill.DAL;
using AppSkill.Model.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AppSkill.Core.Repository
{
    public interface ILocationSalesChannelRelationRepository : IRepository<LocationSalesChannelRelation>
    {

    }
    public class LocationSalesChannelRelationRepository : ILocationSalesChannelRelationRepository
    {
        AppSkillDbContextPostreSql _db;

        public LocationSalesChannelRelationRepository(AppSkillDbContextPostreSql DbContext)
        {
            _db = DbContext;
        }


        public int Count()
        {
            return _db.LocationSalesChannelRelations.Count();
        }

        public bool Delete(int id)
        {
            try

            {

                LocationSalesChannelRelation _obj = _db.LocationSalesChannelRelations.FirstOrDefault(us => us.LocationSalesChannelRelationId == id);

                if (_obj != null)

                {

                    _db.LocationSalesChannelRelations.Remove(_obj);

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

        public LocationSalesChannelRelation Get(Expression<Func<LocationSalesChannelRelation, bool>> expression)
        {
            return _db.LocationSalesChannelRelations.FirstOrDefault(expression);
        }

        public IEnumerable<LocationSalesChannelRelation> GetAll()
        {
            return _db.LocationSalesChannelRelations.Select(a => a);
        }

        public LocationSalesChannelRelation GetById(int id)
        {
            return _db.LocationSalesChannelRelations.FirstOrDefault(a => a.LocationSalesChannelRelationId == id);
        }

        public IQueryable<LocationSalesChannelRelation> GetMany(Expression<Func<LocationSalesChannelRelation, bool>> expression)
        {
            return _db.LocationSalesChannelRelations.Where(expression);
        }

        public bool Insert(LocationSalesChannelRelation obj)
        {
            try

            {

                _db.LocationSalesChannelRelations.Add(obj);

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

        public bool Update(LocationSalesChannelRelation obj)
        {
            try

            {

                _db.LocationSalesChannelRelations.Update(obj);

                return true;

            }

            catch

            {

                return false;

            }
        }
    }
}
