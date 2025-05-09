namespace DatabaseTHP
{
    using DatabaseTHP;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Diagnostics.SymbolStore;

    public partial class view_dm_HangHoa_Combo
    {
        public string ID { get; set; }

        public string LOC_ID { get; set; }

        public string ID_HANGHOACOMBO { get; set; }

        public string ID_HANGHOA { get; set; }

        public string ID_DVT { get; set; }

        public double QTY { get; set; }
        public double TYLE_QD { get; set; }
        public double QTY_TOTAL { get; set; }

        public bool ISACTIVE { get; set; }

        public DateTime? THOIGIANSUA { get; set; }

        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }

        public string ID_NGUOITAO { get; set; }

        public string MA { get; set; }
        public string NAME { get; set; }
        public string NAME_DVT { get; set; }
    }
}
