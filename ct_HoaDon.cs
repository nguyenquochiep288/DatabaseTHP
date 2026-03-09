// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.ct_HoaDon
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTHP
{

    public class ct_HoaDon
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string LOC_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string ID_LOAIHOADON { get; set; }

        public string MAPHIEU { get; set; }

        public int SOPHIEU { get; set; }

        [Required]
        public DateTime NGAYLAP { get; set; }

        [StringLength(50)]
        public string ID_KHACHHANG { get; set; }

        [StringLength(100)]
        public string TENKHACHHANG { get; set; }

        [StringLength(500)]
        public string TENDONVI { get; set; }

        [StringLength(500)]
        public string DIACHI { get; set; }

        [StringLength(20)]
        public string CCCD { get; set; }

        [StringLength(20)]
        public string SOHOCHIEU { get; set; }

        [StringLength(20)]
        public string MASOTHUE { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [StringLength(20)]
        public string DIENTHOAI { get; set; }

        [StringLength(50)]
        public string HTTT { get; set; }

        [StringLength(50)]
        public string LOAITIEN { get; set; }

        public double? TYGIA { get; set; }

        [StringLength(350)]
        public string GHICHU { get; set; }

        [Required]
        public double TONGTHANHTIEN { get; set; }

        [Required]
        public double TONGTIENGIAMGIA { get; set; }

        [Required]
        public double TONGTIENVAT { get; set; }

        [Required]
        public double TONGTIEN { get; set; }

        public DateTime? THOIGIANSUA { get; set; }

        [StringLength(50)]
        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }

        [StringLength(50)]
        public string ID_NGUOITAO { get; set; }

        [StringLength(250)]
        public string CHUNGTUKEMTHEO { get; set; }

        [StringLength(50)]
        public string SOTAIKHOAN { get; set; }

        [StringLength(250)]
        public string TENNGANHANG { get; set; }

        [StringLength(10)]
        public string MASODONVINGANSACH { get; set; }

        [StringLength(250)]
        public string ID_PHIEUXUAT { get; set; }

        public bool ISXUATHOADON { get; set; }

        public string ERROR { get; set; }

        public string MACQT { get; set; }

        public string MATRACUU_MISA { get; set; }

        public string SOHOADON { get; set; }

        public string KYHIEUHOADON { get; set; }

        public DateTime? NGAYLAYKETQUA { get; set; }

        public DateTime? NGAYDAYHOADON { get; set; }

        public DateTime NGAYHOADON { get; set; }
    }
}
