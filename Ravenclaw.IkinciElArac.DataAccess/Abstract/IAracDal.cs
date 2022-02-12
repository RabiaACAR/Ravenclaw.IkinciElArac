using Ravenclaw.IkinciElArac.DataAccess.Repository.IRepo;
using Ravenclaw.IkinciElArac.DataAccess.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ravenclaw.IkinciElArac.DataAccess.Abstract
{
    public interface IAracDal:IRepository<Arac>
    {
        List<SatisAracListeleVM> satisdakiAraclariGetir();
    }
}
