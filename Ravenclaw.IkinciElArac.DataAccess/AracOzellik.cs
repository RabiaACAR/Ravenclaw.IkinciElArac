namespace Ravenclaw.IkinciElArac.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AracOzellik")]
    public partial class AracOzellik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AracOzellik()
        {
            ilanDetays = new HashSet<ilanDetay>();
            ilanDetays1 = new HashSet<ilanDetay>();
        }

        public int AracOzellikID { get; set; }

        public int? AracID { get; set; }

        public int? ModelID { get; set; }

        [StringLength(50)]
        public string GovdeTipi { get; set; }

        [StringLength(50)]
        public string YakitTipi { get; set; }

        [StringLength(50)]
        public string VitesTipi { get; set; }

        [StringLength(50)]
        public string Versiyon { get; set; }

        [StringLength(50)]
        public string Renk { get; set; }

        [StringLength(50)]
        public string OpsiyonelDonanim { get; set; }

        public DateTime? CreateDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string ModifiedBy { get; set; }

        public bool? isActive { get; set; }

        public virtual Arac Arac { get; set; }

        public virtual Model Model { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ilanDetay> ilanDetays { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ilanDetay> ilanDetays1 { get; set; }
    }
}
