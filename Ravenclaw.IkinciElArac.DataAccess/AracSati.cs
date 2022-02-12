namespace Ravenclaw.IkinciElArac.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AracSati
    {
        [Key]
        public int AracSatisID { get; set; }

        public int? AracID { get; set; }

        public int? KullaniciID { get; set; }

        public bool? SatisOnay { get; set; }

        public int? NoterUcretID { get; set; }

        public int? KomisyonUcretID { get; set; }

        public DateTime? CreateDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string ModifiedBy { get; set; }

        public bool? isActive { get; set; }

        public virtual Arac Arac { get; set; }

        public virtual KomisyonUcret KomisyonUcret { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        public virtual NoterUcret NoterUcret { get; set; }
    }
}
