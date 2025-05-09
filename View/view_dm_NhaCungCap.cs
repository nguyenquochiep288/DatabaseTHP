namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_dm_NhaCungCap
    {
        public string ID { get; set; }

        public string LOC_ID { get; set; }

        public string MA { get; set; }

        public string NAME { get; set; }

        public string ADDRESS { get; set; }

        public string TEL { get; set; }

        public string FAX { get; set; }

        public string EMAIL { get; set; }

        public string ID_NHOMNCC { get; set; }

        public bool ISACTIVE { get; set; }

        public bool ISDEFAULT { get; set; }

        public double CONGNODAUKY { get; set; }

        public DateTime? THOIGIANSUA { get; set; }

        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }

        public string ID_NGUOITAO { get; set; }

        public string NAME_NHOMNCC { get; set; }

        public string MASOTHUE { get; set; }
        public string TENNGANHANG { get; set; }
        public string CHUTAIKHOAN { get; set; }
        public string SOTAIKHOAN { get; set; }
    }
}
