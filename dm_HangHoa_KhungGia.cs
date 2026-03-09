// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.dm_HangHoa_KhungGia
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTHP
{

    public class dm_HangHoa_KhungGia
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
        public double TU { get; set; }

        [Required]
        public double DEN { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_DVT { get; set; }

        [Required]
        public double DONGIA { get; set; }

        [Required]
        public bool ISACTIVE { get; set; }

        [Required]
        public double TIEN_KPI { get; set; }

        [Required]
        public int HINHTHUC_TINHKPI { get; set; }

        [Required]
        public double CK_KPI { get; set; }

        public string ID_HANGHOA_KHUNGGIA_MASTER { get; set; }
    }
}
