// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.web_Parameter
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTHP
{

    public class web_Parameter
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string MA { get; set; }

        [StringLength(250)]
        public string NAME { get; set; }

        [StringLength(100)]
        public string PARAMETER { get; set; }

        [StringLength(50)]
        public string TYPE { get; set; }

        [StringLength(250)]
        public string NOTE { get; set; }

        [StringLength(4000)]
        public string VALUE { get; set; }
    }
}
