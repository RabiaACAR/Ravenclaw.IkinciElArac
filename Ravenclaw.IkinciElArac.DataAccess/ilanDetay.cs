namespace Ravenclaw.IkinciElArac.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ilanDetay")]
    public partial class ilanDetay
    {
        public int ilanDetayID { get; set; }

        public int? AracOzellikID { get; set; }

        [StringLength(50)]
        public string MotorGucu { get; set; }

        [StringLength(50)]
        public string MotorHacmi { get; set; }

        [StringLength(50)]
        public string GarantiDurumu { get; set; }

        [StringLength(50)]
        public string Plaka { get; set; }

        public int? ilanID { get; set; }

        public string TeknikOzellikler { get; set; }

        public DateTime? CreateDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string ModifiedBy { get; set; }

        public bool? isActive { get; set; }

        public virtual AracOzellik AracOzellik { get; set; }

        public virtual AracOzellik AracOzellik1 { get; set; }

        public virtual ilan ilan { get; set; }
    }
}
