namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class web_NoteType
    {
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(150)]
        public string NAME { get; set; }

        [StringLength(500)]
        public string NOTE { get; set; }
    }
}
