namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ct_PhieuChi
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
        public DateTime? THOIGIANSUA { get; set; }

        [StringLength(50)]
        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }

        [StringLength(50)]
        public string ID_NGUOITAO { get; set; }

        [Required]
        [StringLength(250)]
        public string TENNGUOINHAN { get; set; }

        [StringLength(350)]
        public string DIACHI { get; set; }

        [StringLength(350)]
        public string LYDO { get; set; }

        public double SOTIEN { get; set; }

        public string CHUNGTUKEMTHEO { get; set; }

        public int SOPHIEU { get; set; }

        public DateTime NGAYLAP { get; set; }

        [StringLength(250)]
        public string NGUOICHITIEN { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_LOAIPHIEUCHI { get; set; }

        [StringLength(50)]
        public string ID_KHACHHANG { get; set; }

        [StringLength(50)]
        public string ID_NHACUNGCAP { get; set; }

        [StringLength(50)]
        public string ID_NHANVIEN { get; set; }

        public string ID_TAIKHOANNGANHANG { get; set; }

        [StringLength(50)]
        public string ID_XE { get; set; }
    }
}
