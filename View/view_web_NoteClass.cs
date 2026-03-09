// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.view_web_NoteClass
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTHP
{

    public class view_web_NoteClass
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(150)]
        public string NAMESPACE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(150)]
        public string NAMECLASS { get; set; }

        public bool? ISPRIMARYKEY { get; set; }

        [StringLength(150)]
        public string DISPLAYNAME { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string NAMECOLUMN { get; set; }

        public bool? ISREQUIRED { get; set; }

        [StringLength(500)]
        public string NOTE { get; set; }

        [StringLength(150)]
        public string FOREIGNKEY { get; set; }

        [StringLength(50)]
        public string FOREIGNKEY_COLUMNID { get; set; }

        [StringLength(50)]
        public string FOREIGNKEY_COLUMNNAME { get; set; }

        public string VIEWFOREIGNKEY_COLUMNNAME { get; set; }

        public bool ISVIEW { get; set; }

        public bool ISEDIT { get; set; }

        public bool ISCREATE { get; set; }

        public bool ISSEARCH { get; set; }

        public bool ISSORT { get; set; }

        [StringLength(150)]
        public string CONTROLLER { get; set; }

        [StringLength(50)]
        public string ID_TYPE { get; set; }

        [StringLength(150)]
        public string NAMEHEADER { get; set; }

        public int? STT { get; set; }

        public string REPLACESEARCH { get; set; }
    }
}
