namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class web_Report_Parameter
    {
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string ID_REPORT { get; set; }

        [StringLength(50)]
        public string ID_PARAMETER { get; set; }

        public bool ISACTIVE { get; set; }

        public int STT { get; set; }

        public string VALUE_REPORT { get; set; }
    }
}
