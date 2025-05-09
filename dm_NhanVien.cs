namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class dm_NhanVien
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string LOC_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ID { get; set; }

        [Required]
        [StringLength(50)]
        public string MA { get; set; }

        [Required]
        [StringLength(100)]
        public string NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_CHUCVU { get; set; }

        [Required]
        [StringLength(1)]
        public string GIOITINH { get; set; }

        [StringLength(200)]
        public string ADDRESS { get; set; }

        [StringLength(25)]
        public string TEL { get; set; }

        [StringLength(25)]
        public string ID_NUMBER { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATEOFBIRTH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATEJOIN { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_PHONGBAN { get; set; }

        [StringLength(50)]
        public string LOAINHANVIEN { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        [StringLength(500)]
        public string GHICHU { get; set; }

        public DateTime? THOIGIANSUA { get; set; }

        [StringLength(50)]
        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }

        [StringLength(50)]
        public string ID_NGUOITAO { get; set; }

        public bool ISACTIVE { get; set; }
        public string ID_TAIKHOAN { get; set; }
        public double CONGNODAUKY { get; set; }
        public double LUONGCOBAN { get; set; }
        public double SONGAYPHEP { get; set; }
    }
}
