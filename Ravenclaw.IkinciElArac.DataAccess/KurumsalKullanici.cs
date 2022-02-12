namespace Ravenclaw.IkinciElArac.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KurumsalKullanici")]
    public partial class KurumsalKullanici
    {
        public int KurumsalKullaniciID { get; set; }

        public int? KullaniciID { get; set; }

        public string AdSoyad { get; set; }

        public string FirmaAdi { get; set; }

        public string FirmaBilgisi { get; set; }

        public int? KullaniciIletisimID { get; set; }

        public int? KullaniciTipiID { get; set; }

        public int? ilID { get; set; }

        public string Adres { get; set; }

        public int? PaketID { get; set; }

        public DateTime? CreateDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string ModifiedBy { get; set; }

        public bool? isActive { get; set; }

        public virtual il il { get; set; }

        public virtual KullaniciIletisim KullaniciIletisim { get; set; }

        public virtual KullaniciTipi KullaniciTipi { get; set; }

        public virtual Paket Paket { get; set; }
    }
}
