namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_dm_KhachHang
    {
        public string LOC_ID { get; set; }

        public string ID { get; set; }

        public string MA { get; set; }

        public string NAME { get; set; }

        public string ADDRESS { get; set; }

        public string TEL { get; set; }

        public string FAX { get; set; }

        public string EMAIL { get; set; }

        public DateTime? NGAYSINH { get; set; }

        public double DIS { get; set; }

        public double RATE { get; set; }

        public string ID_NHOMKHACHHANG { get; set; }

        public string NAME_NHOMKHACHHANG { get; set; }

        public double MAX_CONGNO { get; set; }

        public int SONGAY { get; set; }

        public int LEVEL_PRICE { get; set; }

        public string ID_KHUVUC { get; set; }

        public string NAME_KHUVUC { get; set; }

        public bool ISACTIVE { get; set; }

        public bool ISDEFAULT { get; set; }

        public double CONGNODAUKY { get; set; }

        public DateTime? THOIGIANSUA { get; set; }

        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }
        public string ID_NGUOITAO { get; set; }

        public Double? LATITUDE { get; set; }

        public Double? LONGITUDE { get; set; }

        public string CONTENT_MAP { get; set; }
    }
}
