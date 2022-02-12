using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ravenclaw.IkinciElArac.DataAccess.VM
{
   public  class KurumsalMusteriListeleVM
    {
        //public int KurumsalKullaniciID { get; set; }
        public int? KullaniciID { get; set; }
        public string AdSoyad { get; set; }
        public string FirmaAdi { get; set; }
        public string FirmaBilgisi { get; set; }
       // public bool AktifMi { get; set; }
        public string  ilAdi { get; set; }
        public string ilceAdi { get; set; }
    }
}
