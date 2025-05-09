namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class web_Menu
    {
        [StringLength(50)]
        public string ID { get; set; }

        [Required]
        [StringLength(200)]
        public string NAME { get; set; }

        [StringLength(100)]
        public string ACTIONNAME { get; set; }

        [StringLength(100)]
        public string CONTROLLERNAME { get; set; }

        [StringLength(50)]
        public string ID_QUYENCHA { get; set; }

        [StringLength(150)]
        public string ICON { get; set; }

        public int STT { get; set; }

        public bool ISACTIVE { get; set; }

        public DateTime? THOIGIANSUA { get; set; }

        [StringLength(50)]
        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }

        [StringLength(50)]
        public string ID_NGUOITAO { get; set; }
    }
}
