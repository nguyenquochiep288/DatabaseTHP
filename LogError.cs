namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogError")]
    public partial class LogError
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
