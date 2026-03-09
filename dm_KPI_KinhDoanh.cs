// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.dm_KPI_KinhDoanh
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTHP
{

    public class dm_KPI_KinhDoanh
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
        public string MA { get; set; }

        [Required]
        [StringLength(150)]
        public string NAME { get; set; }

        public DateTime TUNGAY { get; set; }

        public DateTime DENNGAY { get; set; }

        public double CHIETKHAU { get; set; }

        public double TIENGIAM { get; set; }

        public bool IS_YEUCAUCHITIET { get; set; }

        public double TONGTIEN_DATKM { get; set; }

        public double SOLUONG_DATKM { get; set; }

        [StringLength(50)]
        public string ID_DVT_DATKM { get; set; }

        public bool ISACTIVE { get; set; }

        public DateTime? THOIGIANSUA { get; set; }

        [StringLength(50)]
        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }

        [StringLength(50)]
        public string ID_NGUOITAO { get; set; }

        public int CAPDO { get; set; }
    }
}
