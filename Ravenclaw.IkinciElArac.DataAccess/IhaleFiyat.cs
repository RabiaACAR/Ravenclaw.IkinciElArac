namespace Ravenclaw.IkinciElArac.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IhaleFiyat")]
    public partial class IhaleFiyat
    {
        public int IhaleFiyatID { get; set; }

        [Column(TypeName = "money")]
        public decimal? IhaleBaslangicFiyat { get; set; }

        [Column(TypeName = "money")]
        public decimal? IhaleMinAlimFiyat { get; set; }

        public int? IhaleID { get; set; }

        public DateTime? CreateDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string ModifiedBy { get; set; }

        public bool? isActive { get; set; }

        public virtual Ihale Ihale { get; set; }
    }
}
