namespace Ravenclaw.IkinciElArac.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TramerDetay")]
    public partial class TramerDetay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TramerDetay()
        {
            Aracs = new HashSet<Arac>();
        }

        public int TramerDetayID { get; set; }

        [StringLength(10)]
        public string SagArkaCamurluk { get; set; }

        [StringLength(10)]
        public string ArkaKaput { get; set; }

        [StringLength(10)]
        public string SolArkaKapi { get; set; }

        [StringLength(10)]
        public string SagOnKapi { get; set; }

        [StringLength(10)]
        public string Tavan { get; set; }

        [StringLength(10)]
        public string SolOnKapi { get; set; }

        [StringLength(10)]
        public string SagOnCamurluk { get; set; }

        [StringLength(10)]
        public string MotorKaputu { get; set; }

        [StringLength(10)]
        public string SolOnCamurluk { get; set; }

        [StringLength(10)]
        public string OnTampon { get; set; }

        [StringLength(10)]
        public string ArkaTampon { get; set; }

        [Column(TypeName = "money")]
        public decimal? TramerUcret { get; set; }

        public DateTime? CreateDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string ModifiedBy { get; set; }

        public bool? isActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Arac> Aracs { get; set; }
    }
}
