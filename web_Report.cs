// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.web_Report
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.ComponentModel.DataAnnotations;


namespace DatabaseTHP
{

    public class web_Report
    {
        [Key]
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string MA { get; set; }

        [StringLength(200)]
        public string NAME { get; set; }

        [StringLength(200)]
        public string NAME_SP { get; set; }

        [StringLength(50)]
        public string ID_MENU { get; set; }

        public string REPORT { get; set; }

        public string NOTE { get; set; }
    }
}
