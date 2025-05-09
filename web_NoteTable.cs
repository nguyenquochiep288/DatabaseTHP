namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Table("web_NoteTable")]
    public partial class web_NoteTable
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
        public Boolean CHON { get; set; }
        [NotMapped]
        public Boolean ISCHANGE { get; set; }
    }
}
