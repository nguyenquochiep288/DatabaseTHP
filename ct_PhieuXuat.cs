// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.ct_PhieuXuat
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTHP
{

    public class ct_PhieuXuat
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
        public string ID_LOAIPHIEUXUAT { get; set; }

        public string MAPHIEU { get; set; }

        public int SOPHIEU { get; set; }

        public DateTime NGAYLAP { get; set; }

        [StringLength(50)]
        public string ID_KHACHHANG { get; set; }

        [StringLength(50)]
        public string ID_NHACUNGCAP { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_KHO { get; set; }

        [StringLength(50)]
        public string ID_NHANVIEN { get; set; }

        [StringLength(350)]
        public string GHICHU { get; set; }

        public string CHUNGTUKEMTHEO { get; set; }

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

        public bool ISKHUYENMAI { get; set; }

        public bool ISPHIEUDIEUHANG { get; set; }

        public bool ISHOANTAT { get; set; }

        public string ID_HOADON { get; set; }
    }
}
