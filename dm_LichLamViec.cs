// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.dm_LichLamViec
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTHP
{

    public class dm_LichLamViec
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

        public bool T2 { get; set; }

        public bool T3 { get; set; }

        public bool T4 { get; set; }

        public bool T5 { get; set; }

        public bool T6 { get; set; }

        public bool T7 { get; set; }

        public bool CN { get; set; }

        public string GHICHU { get; set; }

        public bool ISACTIVE { get; set; }
    }
}
