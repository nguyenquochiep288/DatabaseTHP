// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.ct_PhieuChuyen_ChiTiet
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTHP
{

    public class ct_PhieuChuyen_ChiTiet
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
        public string ID_PHIEUCHUYEN { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_HANGHOA { get; set; }

        public double SOLUONG { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_DVT { get; set; }

        public double TYLE_QD { get; set; }

        public double TONGSOLUONG { get; set; }

        public double DONGIA { get; set; }

        public double GIAVON { get; set; }

        [Required]
        [StringLength(200)]
        public string GHICHU { get; set; }
    }
}
