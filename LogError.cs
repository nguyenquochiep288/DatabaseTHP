// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.LogError
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTHP
{

    [Table("LogError")]
    public class LogError
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string LOC_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ID { get; set; }

        public string METHODNAME { get; set; }

        public string FULLNAME { get; set; }

        [Column(TypeName = "text")]
        public string DATA { get; set; }

        [Column(TypeName = "text")]
        public string MESSAGE { get; set; }

        [StringLength(50)]
        public string ID_USER { get; set; }

        public DateTime TIME { get; set; }

        public string IP { get; set; }
    }
}
