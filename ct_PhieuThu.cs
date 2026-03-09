// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.ct_PhieuThu
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTHP
{

    public class ct_PhieuThu
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

        [Required]
        [StringLength(250)]
        public string TENNGUOINOPTIEN { get; set; }

        [StringLength(350)]
        public string DIACHI { get; set; }

        [StringLength(350)]
        public string LYDO { get; set; }

        public double SOTIEN { get; set; }

        public string CHUNGTUKEMTHEO { get; set; }

        public int SOPHIEU { get; set; }

        public DateTime NGAYLAP { get; set; }

        [StringLength(250)]
        public string NGUOINHANTIEN { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_LOAIPHIEUTHU { get; set; }

        [StringLength(50)]
        public string ID_KHACHHANG { get; set; }

        [StringLength(50)]
        public string ID_NHACUNGCAP { get; set; }

        [StringLength(50)]
        public string ID_NHANVIEN { get; set; }

        public DateTime? THOIGIANSUA { get; set; }

        [StringLength(50)]
        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }

        [StringLength(50)]
        public string ID_NGUOITAO { get; set; }

        public string ID_TAIKHOANNGANHANG { get; set; }

        public bool ISCHUYENCONGNOCHONHANVIEN { get; set; }
    }
}
