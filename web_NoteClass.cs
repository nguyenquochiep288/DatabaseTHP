namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Table("web_NoteClass")]
    public partial class web_NoteClass
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
        public Boolean CHON { get; set; }
        [NotMapped]
        public Boolean ISCHANGE { get; set; }

        [StringLength(50)]
        public string REPLACESEARCH { get; set; }
    }
}
