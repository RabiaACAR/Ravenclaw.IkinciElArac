namespace Ravenclaw.IkinciElArac.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StatuDegisiklik")]
    public partial class StatuDegisiklik
    {
        public int StatuDegisiklikID { get; set; }

        public int? AracStatuID { get; set; }

        public int? AracID { get; set; }

        public DateTime? Tarih { get; set; }

        public DateTime? CreateDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string ModifiedBy { get; set; }

        public bool? isActive { get; set; }

        public virtual Arac Arac { get; set; }

        public virtual AracStatu AracStatu { get; set; }
    }
}
