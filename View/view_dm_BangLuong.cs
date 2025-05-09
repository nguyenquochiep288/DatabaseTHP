namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_dm_BangLuong
    {
        public string LOC_ID { get; set; }

        public string ID { get; set; }

        public string ID_PHONGBAN { get; set; }

        public string MA { get; set; }
        public string NAME { get; set; }

        public DateTime? THOIGIANSUA { get; set; }

        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }

        public string ID_NGUOITAO { get; set; }

        public bool ISACTIVE { get; set; }

        public List<v_dm_BangLuong_ChiTiet> lstdm_BangLuong_ChiTiet { get; set; }

        public string NAME_PHONGBAN { get; set; }
        public string MA_PHONGBAN { get; set; }

    }
}
