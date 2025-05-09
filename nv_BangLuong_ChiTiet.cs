namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nv_BangLuong_ChiTiet
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string LOC_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ID { get; set; }
        public string ID_BANGLUONG { get; set; }
        public string ID_LOAILUONG { get; set; }
        public string GHICHU { get; set; }
        public double SOTIEN { get; set; }
        public string TYPE { get; set; }
    }
}
