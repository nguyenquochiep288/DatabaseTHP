namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class web_Quyen
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string LOC_ID { get; set; }

        [Key]
        [StringLength(50)]
        public string ID { get; set; }

        [Required]
        [StringLength(50)]
        public string MAQUYEN { get; set; }

        [Required]
        [StringLength(50)]
        public string TENQUYEN { get; set; }

        [StringLength(50)]
        public string ID_MENU { get; set; }

        [StringLength(250)]
        public string MOTA { get; set; }
    }
}
