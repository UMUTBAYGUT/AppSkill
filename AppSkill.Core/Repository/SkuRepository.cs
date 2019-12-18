using AppSkill.DAL;
using AppSkill.Model.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AppSkill.Core.Repository
{
    public interface ISkuRepository : IRepository<Sku>
    {

    }
    public class SkuRepository : ISkuRepository
    {
        AppSkillDbContextPostreSql _db;

        public SkuRepository(AppSkillDbContextPostreSql DbContext)
        {
            _db = DbContext;
        }


        public int Count()
        {
            return _db.Skus.Count();
        }

        public bool Delete(int id)
        {
            try

            {

                Sku _obj = _db.Skus.FirstOrDefault(us => us.SkuId == id);

                if (_obj != null)

                {

                    _db.Skus.Remove(_obj);

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

        public Sku Get(Expression<Func<Sku, bool>> expression)
        {
            return _db.Skus.FirstOrDefault(expression);
        }

        public IEnumerable<Sku> GetAll()
        {
            return _db.Skus.Select(a => a);
        }

        public Sku GetById(int id)
        {
            return _db.Skus.FirstOrDefault(a => a.SkuId == id);
        }

        public IQueryable<Sku> GetMany(Expression<Func<Sku, bool>> expression)
        {
            return _db.Skus.Where(expression);
        }

        public bool Insert(Sku obj)
        {
            try

            {

                _db.Skus.Add(obj);

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

        public bool Update(Sku obj)
        {
            try

            {

                _db.Skus.Update(obj);

                return true;

            }

            catch

            {

                return false;

            }
        }
    }
}
