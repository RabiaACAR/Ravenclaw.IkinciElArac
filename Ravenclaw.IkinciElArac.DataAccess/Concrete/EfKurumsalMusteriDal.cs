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
    public class EfKurumsalMusteriDal : Repository<KurumsalKullanici>, IKurumsalMusteriDal
    {
        List<KurumsalMusteriListeleVM> getirilecekKurumsalMusteriler = null;
        public List<KurumsalMusteriListeleVM> KurumsalMusterileriGetir()
        {
            using (IkinciElAracEntities db = new IkinciElAracEntities())
            {
                getirilecekKurumsalMusteriler = (from k in db.KurumsalKullanicis
                                                 join m in db.Kullanicis on k.KullaniciID
                                                 equals m.KullaniciID
                                                 join ilce in db.ilces on k.ilID equals ilce.ilID
                                                 where m.AktifMi == false
                                                 select new
                                                 {
                                                     AdSoyad = k.AdSoyad,
                                                     FirmaAdi = k.FirmaAdi,
                                                     FirmaBilgisi = k.FirmaBilgisi,
                                                     KullaniciID = k.KullaniciID,
                                                     KurumsalKullaniciID = k.KurumsalKullaniciID,
                                                     //AktifMi = (bool)m.AktifMi,
                                                     ilAdi = ilce.il.ilAdi,
                                                     ilceAdi = ilce.ilceAdi,
                                                 }).Select(s => new KurumsalMusteriListeleVM
                                                 {
                                                     KullaniciID = s.KullaniciID,
                                                     AdSoyad = s.AdSoyad,
                                                     FirmaAdi = s.FirmaAdi,
                                                     FirmaBilgisi = s.FirmaBilgisi,
                                                     /// AktifMi = s.AktifMi,
                                                     ilAdi = s.ilAdi,
                                                     ilceAdi = s.ilceAdi

                                                 }).ToList();
            }
            return getirilecekKurumsalMusteriler;
        }
    }
    
}
