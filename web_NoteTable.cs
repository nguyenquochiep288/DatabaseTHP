// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.web_NoteTable
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTHP
{

    [Table("web_NoteTable")]
    public class web_NoteTable
    {
        [Key]
        [StringLength(150)]
        public string NAMECLASS { get; set; }

        [StringLength(500)]
        public string NOTE { get; set; }

        [StringLength(50)]
        public string ID_TYPE { get; set; }

        [StringLength(150)]
        public string CONTROLLER { get; set; }

        [StringLength(150)]
        public string NAMEHEADER { get; set; }

        [NotMapped]
        public bool CHON { get; set; }

        [NotMapped]
        public bool ISCHANGE { get; set; }
    }
}
