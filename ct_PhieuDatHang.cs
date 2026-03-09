// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.ct_PhieuDatHang
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTHP
{

    public class ct_PhieuDatHang
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
        public string MAPHIEU { get; set; }

        public int SOPHIEU { get; set; }

        [Required]
        public DateTime NGAYLAP { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_KHACHHANG { get; set; }

        [StringLength(500)]
        public string ADDRESS { get; set; }

        [StringLength(20)]
        public string TEL { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_KHO { get; set; }

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

        public bool ISKHUYENMAI { get; set; }

        public string ID_PHIEUXUAT { get; set; }
    }
}
