// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.web_Quyen
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.ComponentModel.DataAnnotations;


namespace DatabaseTHP
{

    public class web_Quyen
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string LOC_ID { get; set; }

        [Key]
        [StringLength(50)]
        public string ID { get; set; }

        [Required]
        [StringLength(50)]
        public string MAQUYEN { get; set; }

        [Required]
        [StringLength(50)]
        public string TENQUYEN { get; set; }

        [StringLength(50)]
        public string ID_MENU { get; set; }

        [StringLength(250)]
        public string MOTA { get; set; }
    }
}
