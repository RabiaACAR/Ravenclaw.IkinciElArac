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
    public class EfAracDal : Repository<Arac>, IAracDal
    {
        public List<SatisAracListeleVM> satisdakiAraclariGetir()
        {
            List<SatisAracListeleVM> getirilecekAraclar = null;
            using (IkinciElAracEntities db = new IkinciElAracEntities())
            {
                getirilecekAraclar = (from a in db.Aracs
                                      join so in db.StatuDegisikliks on a.AracID equals so.AracID
                                      join astd in db.AracStatus on so.AracStatuID equals astd.AracStatuID
                                      join ao in db.AracOzelliks on a.AracID equals ao.AracID
                                      join mo in db.Models on ao.ModelID equals mo.ModelID
                                      join m in db.Markas on mo.MarkaID equals m.MarkaID
                                      join ku in db.Kullanicis on a.KullaniciID equals ku.KullaniciID
                                      join kt in db.KullaniciTipis on ku.KullaniciTipiID equals kt.KullaniciTipiID
                                      where ku.KullaniciTipi.KullaniciTipi1 == "BireyselKullanici"
                                      select new SatisAracListeleVM
                                      {
                                          AracID = a.AracID,
                                          MarkaAdi = m.MarkaAdi,
                                          ModelAdi = mo.ModelAdi,
                                          KaydetmeZamani = (DateTime)a.CreateDate,
                                          Statu = astd.StatuDurumu,
                                          KullaniciAdi = ku.KullaniciAdi
                                      }).ToList();

                return getirilecekAraclar;

            }
        }
    }
}
