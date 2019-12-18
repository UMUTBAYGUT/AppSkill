using AppSkill.DAL;
using AppSkill.Model.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AppSkill.Core.Repository
{
    public interface ISalesChannelRepository : IRepository<SalesChannel>
    {

    }
    public class SalesChannelRepository : ISalesChannelRepository
    {
        AppSkillDbContextPostreSql _db;

        public SalesChannelRepository(AppSkillDbContextPostreSql DbContext)
        {
            _db = DbContext;
        }


        public int Count()
        {
            return _db.SalesChannels.Count();
        }

        public bool Delete(int id)
        {
            try

            {

                SalesChannel _obj = _db.SalesChannels.FirstOrDefault(us => us.SalesChannelId == id);

                if (_obj != null)

                {

                    _db.SalesChannels.Remove(_obj);

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

        public SalesChannel Get(Expression<Func<SalesChannel, bool>> expression)
        {
            return _db.SalesChannels.FirstOrDefault(expression);
        }

        public IEnumerable<SalesChannel> GetAll()
        {
            return _db.SalesChannels.Select(a => a);
        }

        public SalesChannel GetById(int id)
        {
            return _db.SalesChannels.FirstOrDefault(a => a.SalesChannelId == id);
        }

        public IQueryable<SalesChannel> GetMany(Expression<Func<SalesChannel, bool>> expression)
        {
            return _db.SalesChannels.Where(expression);
        }

        public bool Insert(SalesChannel obj)
        {
            try

            {

                _db.SalesChannels.Add(obj);

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

        public bool Update(SalesChannel obj)
        {
            try

            {

                _db.SalesChannels.Update(obj);

                return true;

            }

            catch

            {

                return false;

            }
        }
    }
}
