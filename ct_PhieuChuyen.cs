// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.ct_PhieuChuyen
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTHP
{

    public class ct_PhieuChuyen
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

        public int SOPHIEU { get; set; }

        public DateTime NGAYLAP { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_NHANVIEN { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_TUKHO { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_DENKHO { get; set; }

        [StringLength(200)]
        public string GHICHU { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_PHIEUXUATKHAC { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_PHIEUNHAPKHAC { get; set; }
    }
}
