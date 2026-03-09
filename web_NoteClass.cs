// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.web_NoteClass
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTHP
{

    [Table("web_NoteClass")]
    public class web_NoteClass
    {
        [Key]
        [StringLength(150)]
        public string NAMESPACE { get; set; }

        [Key]
        [StringLength(150)]
        public string NAMECLASS { get; set; }

        [Key]
        [StringLength(50)]
        public string NAMECOLUMN { get; set; }

        [StringLength(150)]
        public string DISPLAYNAME { get; set; }

        [StringLength(500)]
        public string NOTE { get; set; }

        public bool ISPRIMARYKEY { get; set; }

        public bool ISREQUIRED { get; set; }

        [StringLength(150)]
        public string FOREIGNKEY { get; set; }

        [StringLength(50)]
        public string FOREIGNKEY_COLUMNID { get; set; }

        [StringLength(50)]
        public string FOREIGNKEY_COLUMNNAME { get; set; }

        [StringLength(50)]
        public string VIEWFOREIGNKEY_COLUMNNAME { get; set; }

        public bool ISVIEW { get; set; }

        public bool ISEDIT { get; set; }

        public bool ISCREATE { get; set; }

        public bool ISSEARCH { get; set; }

        public bool ISSORT { get; set; }

        public int? STT { get; set; }

        [NotMapped]
        public bool CHON { get; set; }

        [NotMapped]
        public bool ISCHANGE { get; set; }

        [StringLength(50)]
        public string REPLACESEARCH { get; set; }
    }
}
