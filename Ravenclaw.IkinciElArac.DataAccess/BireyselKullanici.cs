namespace Ravenclaw.IkinciElArac.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BireyselKullanici")]
    public partial class BireyselKullanici
    {
        public int BireyselKullaniciID { get; set; }

        public int? KullaniciID { get; set; }

        public string AdSoyad { get; set; }

        public string Sifre { get; set; }

        public int? KullaniciIletisimID { get; set; }

        public int? KullaniciTipiID { get; set; }

        public DateTime? CreateDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string ModifiedBy { get; set; }

        public bool? isActive { get; set; }

        public virtual KullaniciTipi KullaniciTipi { get; set; }
    }
}
