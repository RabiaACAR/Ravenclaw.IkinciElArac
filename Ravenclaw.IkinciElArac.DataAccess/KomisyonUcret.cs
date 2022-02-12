namespace Ravenclaw.IkinciElArac.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KomisyonUcret")]
    public partial class KomisyonUcret
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KomisyonUcret()
        {
            AracSatis = new HashSet<AracSati>();
        }

        public int KomisyonUcretID { get; set; }

        [Column("KomisyonUcret", TypeName = "money")]
        public decimal? KomisyonUcret1 { get; set; }

        public DateTime? BaslangicTarih { get; set; }

        public DateTime? BitisTarih { get; set; }

        [Column(TypeName = "money")]
        public decimal? MinFiyat { get; set; }

        [Column(TypeName = "money")]
        public decimal? MaxFiyat { get; set; }

        public DateTime? CreateDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string ModifiedBy { get; set; }

        public bool? isActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AracSati> AracSatis { get; set; }
    }
}
