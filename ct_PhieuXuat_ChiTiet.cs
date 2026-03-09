// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.ct_PhieuXuat_ChiTiet
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTHP
{

    public class ct_PhieuXuat_ChiTiet
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
        public string ID_PHIEUXUAT { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_HANGHOAKHO { get; set; }

        public double SOLUONG { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_DVT { get; set; }

        public double TYLE_QD { get; set; }

        public double TONGSOLUONG { get; set; }

        public double DONGIA { get; set; }

        public double GIAVON { get; set; }

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

        public string ID_COMBO { get; set; }

        public bool ISCOMBO { get; set; }

        public bool ISKHUYENMAI { get; set; }

        public string ID_KHUYENMAI { get; set; }

        public int STT { get; set; }

        public string ID_PHIEUDIEUHANG_CHITIET { get; set; }
    }
}
