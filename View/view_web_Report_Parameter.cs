using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class view_web_Report_Parameter
    {
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string ID_REPORT { get; set; }

        [StringLength(50)]
        public string ID_PARAMETER { get; set; }

        public bool ISACTIVE { get; set; }

        public int STT { get; set; }

        public string NAME_REPORT { get; set; }

        public string NAME_PARAMETER { get; set; }

        public string NAME { get; set; }

        public string VALUE { get; set; }
        public string TYPE { get; set; }

        public string MA_PARAMETER { get; set; }
        public string VALUE_REPORT { get; set; }
    }
}