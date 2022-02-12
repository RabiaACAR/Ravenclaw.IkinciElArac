using Ravenclaw.IkinciElArac.DataAccess.Repository.IRepo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ravenclaw.IkinciElArac.DataAccess.Repository.Repo
{
    public class Repository<T> : IRepository<T> where T : class
    {
        IkinciElAracEntities _db;
        DbSet<T> _table;

        public Repository()
        {
            _db = new IkinciElAracEntities();
            _table = _db.Set<T>();
        }
        public int Delete(int ID)
        {
            _table.Remove(_table.Find(ID));
            return _db.SaveChanges();
        }

        public int Insert(T addEntity)
        {
            _table.Add(addEntity);
            return _db.SaveChanges();
        }

        public List<T> Select()
        {
            return _table.ToList();
        }

        public List<T> Select(Expression<Func<T, bool>> kosul)
        {
            return _table.Where(kosul).ToList();
        }



        public T SelectByID(int ID)
        {
            return _table.Find(ID);
        }

        public int SoftDelete(T deleteEntity)
        {
            deleteEntity.GetType().GetProperty("isActive").SetValue(deleteEntity, false);
            return Update(deleteEntity);
        }

        public int Update(T updateEntity)
        {
            _table.Attach(updateEntity);
            _db.Entry(updateEntity).State = EntityState.Modified;
            return _db.SaveChanges();
        }
    }
}
