// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.ct_HoaDon_ChiTiet
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTHP
{

    public class ct_HoaDon_ChiTiet
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
        public string ID_HOADON { get; set; }

        [StringLength(50)]
        public string ID_HANGHOAKHO { get; set; }

        [StringLength(100)]
        public string MAHANGHOA { get; set; }

        [StringLength(500)]
        public string TENHANGHOA { get; set; }

        public double SOLUONG { get; set; }

        [StringLength(50)]
        public string ID_DVT { get; set; }

        [StringLength(50)]
        public string DVT { get; set; }

        public double DONGIA { get; set; }

        public double THANHTIEN { get; set; }

        [StringLength(200)]
        public string GHICHU { get; set; }

        public double CHIETKHAU { get; set; }

        public double TONGTIENGIAMGIA { get; set; }

        [StringLength(50)]
        public string ID_THUESUAT { get; set; }

        public double THUESUAT { get; set; }

        public double TONGTIENVAT { get; set; }

        public double TONGCONG { get; set; }

        public int STT { get; set; }

        public int TINHCHAT { get; set; }

        [StringLength(50)]
        public string ID_PHIEUXUAT_CHITIET { get; set; }
    }
}

