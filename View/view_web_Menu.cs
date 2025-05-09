namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_web_Menu
    {
        public string ID { get; set; }

        public string NAME { get; set; }

        public string ACTIONNAME { get; set; }

        public string CONTROLLERNAME { get; set; }

        public string ID_QUYENCHA { get; set; }

        public string ICON { get; set; }

        public int STT { get; set; }

        public bool ISACTIVE { get; set; }

        public DateTime? THOIGIANSUA { get; set; }

        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }

        public string ID_NGUOITAO { get; set; }

        public string NAME_QUYENCHA { get; set; }
        public string NAME_ORDERBY { get; set; }
        public string ID_REPORT { get; set; }
        
    }
}
