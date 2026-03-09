// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.dm_KPI_KinhDoanh_YeuCau
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTHP
{

    public class dm_KPI_KinhDoanh_YeuCau
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
        public string ID_KPI_KINHDOANH { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_HANGHOA { get; set; }

        public double SOLUONG { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_DVT { get; set; }

        public double SOTIEN { get; set; }

        public double TYLE_QD { get; set; }

        public double QTY_TOTAL { get; set; }

        public int HINHTHUC_TINHKPI { get; set; }

        public int HINHTHUC { get; set; }

        public double CHIETKHAU { get; set; }

        public double TIENGIAM { get; set; }
    }
}
