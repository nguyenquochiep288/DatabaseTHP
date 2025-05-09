namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class dm_ThangLuong
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string LOC_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ID { get; set; }
        public string MA { get; set; }
        public string NAME { get; set; }
        public double THANG { get; set; }

        public double NAM { get; set; }

        public double SONGAY { get; set; }

        public double SONGAYCONG { get; set; }

        public string GHICHU { get; set; }
        public DateTime NGAYBATDAU { get; set; }
        public DateTime NGAYKETTHUC { get; set; }
        public string ID_PHONGBAN { get; set; }
        public Boolean ISCHAMCONG { get; set; }
        public bool ISACTIVE { get; set; }
        public TimeSpan GIOBATDAU { get; set; }
        public TimeSpan GIOBATDAU_NGHITRUA { get; set; }
        public TimeSpan GIOKETTHUC_NGHITRUA { get; set; }
        public TimeSpan GIOKETTHUC { get; set; }
        public double SOGIONGHITRUA { get; set; }
        public string DANHSACHNGAYNGHI { get; set; }
    }
}
