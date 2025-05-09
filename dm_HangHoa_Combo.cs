namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class dm_HangHoa_Combo
    {
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string LOC_ID { get; set; }

        [StringLength(50)]
        public string ID_HANGHOACOMBO { get; set; }

        [StringLength(50)]
        public string ID_HANGHOA { get; set; }

        public string ID_DVT { get; set; }

        public double QTY { get; set; }
        public double TYLE_QD { get; set; }
        public double QTY_TOTAL { get; set; }

        public bool ISACTIVE { get; set; }

        public DateTime? THOIGIANSUA { get; set; }

        [StringLength(50)]
        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }

        [StringLength(50)]
        public string ID_NGUOITAO { get; set; }
    }
}
