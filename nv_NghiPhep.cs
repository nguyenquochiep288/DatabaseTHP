namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nv_NghiPhep
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
        public string ID_NHANVIEN { get; set; }

        [StringLength(50)]
        public string ID_THANGLUONG { get; set; }

        public DateTime THOIGIANVAO { get; set; }

        public DateTime THOIGIANRA { get; set; }

        public string GHICHU { get; set; }

        public DateTime? THOIGIANSUA { get; set; }

        [StringLength(50)]
        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }

        [StringLength(50)]
        public string ID_NGUOITAO { get; set; }

        public bool ISNGHIPHEP { get; set; }

        public double SOLUONG { get; set; }

        public bool ISDUYETPHEP { get; set; }

        public DateTime? THOIGIANDUYETPHEP { get; set; }

        [StringLength(50)]
        public string ID_NGUOIDUYETPHEP { get; set; }
        public int HINHTHUCNGHIPHEP { get; set; }
        public string ID_PHEPNAM { get; set; }
    }
}
