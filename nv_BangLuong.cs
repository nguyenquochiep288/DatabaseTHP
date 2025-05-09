namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.CompilerServices;

    public partial class nv_BangLuong
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string LOC_ID { get; set; }
        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ID { get; set; }
        public string MAPHIEU { get; set; }
        public int SOPHIEU { get; set; }
        [Required]
        public string ID_THANGLUONG { get; set; }
        [Required]
        public string ID_NHANVIEN { get; set; }
        public double SONGAYCONG { get; set; }
        public double MUCLUONG { get; set; }
        public double SONGAYLAMVIEC { get; set; }
        public double SONGAYNGHIPHEP { get; set; }
        public double TIENLUONG { get; set; }
        public double TIENLUONGKHAC { get; set; }
        public double TIENGIAM { get; set; }
        public double TIENTHUCNHAN { get; set; }
        public string GHICHU { get; set; }
        public DateTime NGAYLAP { get; set; }
        public Boolean ISTINHLUONG { get; set; }
        public DateTime? THOIGIANSUA { get; set; }

        [StringLength(50)]
        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }

        [StringLength(50)]
        public string ID_NGUOITAO { get; set; }
        public double SONGAYNGHIKHONGPHEP { get; set; }
        public double TIENDAUKY { get; set; }
    }
}
