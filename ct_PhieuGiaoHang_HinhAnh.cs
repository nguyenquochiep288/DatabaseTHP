// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.ct_PhieuGiaoHang_HinhAnh
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTHP
{

    public class ct_PhieuGiaoHang_HinhAnh
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

        [StringLength(250)]
        public string URL_IMAGE { get; set; }

        public string GHICHU { get; set; }

        public DateTime NGAYTAO { get; set; }

        public string ID_NGUOITAO { get; set; }

        public DateTime THOIGIANTHEM { get; set; }
    }
}
