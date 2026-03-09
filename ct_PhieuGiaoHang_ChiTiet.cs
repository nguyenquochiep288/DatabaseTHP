// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.ct_PhieuGiaoHang_ChiTiet
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTHP
{

    public class ct_PhieuGiaoHang_ChiTiet
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
        public string ID_PHIEUGIAOHANG { get; set; }

        [StringLength(50)]
        public string ID_PHIEUXUAT { get; set; }

        public bool ISDAGIAOHANG { get; set; }

        public bool ISTRAHANG { get; set; }

        public double SOTIENGIAOHANG { get; set; }

        public double SOTIENDATHU { get; set; }

        public string GHICHU { get; set; }

        public int INTPRINT { get; set; }

        public double TONGSOLUONG { get; set; }

        public double TONGKHOILUONG { get; set; }

        public int SOLAN { get; set; }

        public bool ISCHUYENCONGNOCHONHANVIEN { get; set; }

        public string ID_PHIEUCHI { get; set; }
    }
}
