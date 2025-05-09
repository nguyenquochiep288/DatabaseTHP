namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class dm_TaiKhoanNganHang
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string LOC_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string MA { get; set; }

        [Required]
        [StringLength(50)]
        public string NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string SOTAIKHOAN { get; set; }

        [StringLength(50)]
        public string MANGANHANG { get; set; }

        [StringLength(250)]
        public string TENNGANHANG { get; set; }

        [StringLength(250)]
        public string CHINHANH { get; set; }

        [StringLength(50)]
        public string TINHTP { get; set; }

        [StringLength(150)]
        public string CHUTAIKHOAN { get; set; }

        public bool ISDEFAULT { get; set; }

        public bool ISACTIVE { get; set; }

        public DateTime? THOIGIANSUA { get; set; }

        [StringLength(50)]
        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }

        [StringLength(50)]
        public string ID_NGUOITAO { get; set; }

        public double CONGNODAUKY { get; set; }
    }
}
