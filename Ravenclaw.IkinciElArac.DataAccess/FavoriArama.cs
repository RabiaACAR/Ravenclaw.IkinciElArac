namespace Ravenclaw.IkinciElArac.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FavoriArama")]
    public partial class FavoriArama
    {
        public int FavoriAramaID { get; set; }

        [StringLength(50)]
        public string FavoriAramaAd { get; set; }

        public int? KullaniciID { get; set; }

        [StringLength(50)]
        public string Marka { get; set; }

        [StringLength(50)]
        public string Model { get; set; }

        [StringLength(50)]
        public string GovdeTipi { get; set; }

        [StringLength(4)]
        public string Yil { get; set; }

        [StringLength(50)]
        public string YakitTipi { get; set; }

        [StringLength(50)]
        public string VitesTipi { get; set; }

        [StringLength(50)]
        public string Versiyon { get; set; }

        public string KM { get; set; }

        [StringLength(50)]
        public string Renk { get; set; }

        [StringLength(50)]
        public string OpsiyonelDonanim { get; set; }

        public DateTime? CreateDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string ModifiedBy { get; set; }

        public bool? isActive { get; set; }

        public virtual Kullanici Kullanici { get; set; }
    }
}
