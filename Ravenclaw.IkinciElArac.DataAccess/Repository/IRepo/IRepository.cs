using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ravenclaw.IkinciElArac.DataAccess.Repository.IRepo
{
    public interface IRepository<T> where T : class
    {
        List<T> Select();
        List<T> Select(Expression<Func<T, bool>> kosul);
        int Insert(T addEntity);
        int Update(T updateEntity);
        int Delete(int ID);
        int SoftDelete(T deleteEntity);
        T SelectByID(int ID);
    }
}
