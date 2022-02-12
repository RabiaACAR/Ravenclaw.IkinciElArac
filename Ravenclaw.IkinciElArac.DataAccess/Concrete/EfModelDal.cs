using Ravenclaw.IkinciElArac.DataAccess.Abstract;
using Ravenclaw.IkinciElArac.DataAccess.Repository.Repo;
using Ravenclaw.IkinciElArac.DataAccess.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ravenclaw.IkinciElArac.DataAccess.Concrete
{
    public class EfModelDal : Repository<Model>, IModelDal
    {
        List<ModelListeleVM> modelList = null;
        public List<ModelListeleVM> ModelListele(int markaId)
        {
            using (IkinciElAracEntities db=new IkinciElAracEntities())
            {
                modelList = (from mod in db.Models
                             where mod.MarkaID == markaId
                             select new ModelListeleVM()
                             {
                                 MarkaAdi = mod.Marka.MarkaAdi,
                                 ModelAdi = mod.ModelAdi
                             }).ToList();
                return modelList;
            }
        }
    }
}
