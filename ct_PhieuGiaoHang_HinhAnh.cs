namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ct_PhieuGiaoHang_HinhAnh
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string LOC_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string ID_PHIEUGIAOHANG { get; set; }

        [StringLength(50)]
        public string ID_PHIEUXUAT { get; set; }

        [StringLength(250)]
        public string URL_IMAGE { get; set; }

        public string GHICHU { get; set; }

        public DateTime NGAYTAO { get; set; }

        public string ID_NGUOITAO { get; set; }

        public DateTime THOIGIANTHEM { get; set; }
    }
}
