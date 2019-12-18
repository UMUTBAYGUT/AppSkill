using AppSkill.DAL;
using AppSkill.Model.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AppSkill.Core.Repository
{
    public interface ISalesChannelSkuRelationRepository : IRepository<SalesChannelSkuRelation>
    {

    }
    public class SalesChannelSkuRelationRepository : ISalesChannelSkuRelationRepository
    {
        AppSkillDbContextPostreSql _db;

        public SalesChannelSkuRelationRepository(AppSkillDbContextPostreSql DbContext)
        {
            _db = DbContext;
        }


        public int Count()
        {
            return _db.SalesChannelSkuRelations.Count();
        }

        public bool Delete(int id)
        {
            try

            {

                SalesChannelSkuRelation _obj = _db.SalesChannelSkuRelations.FirstOrDefault(us => us.SalesChannelSkuRelationId == id);

                if (_obj != null)

                {

                    _db.SalesChannelSkuRelations.Remove(_obj);

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

        public SalesChannelSkuRelation Get(Expression<Func<SalesChannelSkuRelation, bool>> expression)
        {
            return _db.SalesChannelSkuRelations.FirstOrDefault(expression);
        }

        public IEnumerable<SalesChannelSkuRelation> GetAll()
        {
            return _db.SalesChannelSkuRelations.Select(a => a);
        }

        public SalesChannelSkuRelation GetById(int id)
        {
            return _db.SalesChannelSkuRelations.FirstOrDefault(a => a.SalesChannelSkuRelationId == id);
        }

        public IQueryable<SalesChannelSkuRelation> GetMany(Expression<Func<SalesChannelSkuRelation, bool>> expression)
        {
            return _db.SalesChannelSkuRelations.Where(expression);
        }

        public bool Insert(SalesChannelSkuRelation obj)
        {
            try

            {

                _db.SalesChannelSkuRelations.Add(obj);

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

        public bool Update(SalesChannelSkuRelation obj)
        {
            try

            {

                _db.SalesChannelSkuRelations.Update(obj);

                return true;

            }

            catch

            {

                return false;

            }
        }
    }
}
