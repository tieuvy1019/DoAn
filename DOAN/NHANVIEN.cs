namespace DOAN
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            CTHDs = new HashSet<CTHD>();
        }

        [Key]
        [StringLength(10)]
        public string MANV { get; set; }

        [StringLength(50)]
        public string TENNV { get; set; }

        public DateTime? NGAYSINH { get; set; }

        [StringLength(50)]
        public string DIACHI { get; set; }

        [StringLength(12)]
        public string SDT { get; set; }

        [StringLength(20)]
        public string TENDANGNHAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHD> CTHDs { get; set; }

        public virtual TAIKHOAN TAIKHOAN { get; set; }
    }
}
