namespace DatabaseTHP
{
    using DatabaseTHP.Class;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Diagnostics.SymbolStore;
    using System.Linq;

    public partial class view_nv_PhepNam
    {
        public string LOC_ID { get; set; }

        public string ID { get; set; }
        public string ID_NHANVIEN { get; set; }
        public double NAM { get; set; }
        public DateTime NGAYBATDAU { get; set; }
        public DateTime NGAYKETTHUC { get; set; }
        public double SONGAYPHEP { get; set; }
        public double SONGAYPHEPDADUNG { get; set; }

        public DateTime? THOIGIANSUA { get; set; }

        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }

        public string ID_NGUOITAO { get; set; }

        public string MA_NHANVIEN { get; set; }
        public string NAME_NHANVIEN { get; set; }
    }
}
