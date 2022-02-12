using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ravenclaw.IkinciElArac.DataAccess.VM
{
    public class SatisAracListeleVM
    {
        //arac, model, marka, statu, kullanıcı, statü degisiklik, arac özellik
        public int AracID { get; set; }
        public string KullaniciAdi { get; set; }//KaydedenKullanıcı
        public string MarkaAdi { get; set; }
        public string ModelAdi { get; set; }
        public string Statu { get; set; }       
        public DateTime KaydetmeZamani{ get; set; }
       
    }
}
