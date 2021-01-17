namespace DOAN
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTHD")]
    public partial class CTHD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MACTHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MASP { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string SOHD { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string MANV { get; set; }

        public int? SOLUONG { get; set; }
        public int? DONGIA { get; set; }
        public int? THANHTIEN { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }

        public virtual HOADON HOADON { get; set; }
    }
}
