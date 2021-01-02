namespace DOAN
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            CTHDs = new HashSet<CTHD>();
        }

        [Key]
        [StringLength(10)]
        public string MASP { get; set; }

        [StringLength(50)]
        public string TENSP { get; set; }

        [StringLength(20)]
        public string DONVITINH { get; set; }

        [StringLength(20)]
        public string LOAI { get; set; }

        [StringLength(20)]
        public string XUATXU { get; set; }

        public DateTime? NGAYSANXUAT { get; set; }

        public DateTime? HANSUDUNG { get; set; }

        public int? DONGIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHD> CTHDs { get; set; }
    }
}
