namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ct_PhieuGiaoHang
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string LOC_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ID { get; set; }

        public string MAPHIEU { get; set; }
        public int SOPHIEU { get; set; }

        public DateTime NGAYLAP { get; set; }

        [StringLength(50)]
        public string ID_XEGIAOHANG { get; set; }

        public string GHICHU { get; set; }

        public bool ISHOANTAT { get; set; }

        public DateTime? THOIGIANSUA { get; set; }

        [StringLength(50)]
        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }

        [StringLength(50)]
        public string ID_NGUOITAO { get; set; }

        public double SOLUONG_DONHANG { get; set; }

        public double SOTIENGIAOHANG { get; set; }
    }
}
