namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class web_Parameter
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
