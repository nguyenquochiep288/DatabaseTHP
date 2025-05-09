namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ct_PhieuDatHangNCC
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string LOC_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ID { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_LOAIPHIEUNHAP { get; set; }

        public string MAPHIEU { get; set; }

        public int SOPHIEU { get; set; }
        [Required]
        [StringLength(50)]
        public string ID_KHO { get; set; }
        public DateTime NGAYLAP { get; set; }

        [StringLength(50)]
        public string ID_NHACUNGCAP { get; set; }


        [StringLength(50)]
        public string ID_NHANVIEN { get; set; }

        [StringLength(350)]
        public string GHICHU { get; set; }

        public double TONGTHANHTIEN { get; set; }

        public double TONGTIENGIAMGIA { get; set; }

        public double TONGTIENVAT { get; set; }

        public double TONGTIEN { get; set; }

        public DateTime? THOIGIANSUA { get; set; }

        [StringLength(50)]
        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }

        [StringLength(50)]
        public string ID_NGUOITAO { get; set; }

        public string CHUNGTUKEMTHEO { get; set; }
        public bool ISHOANTAT { get; set; }
    }
}
