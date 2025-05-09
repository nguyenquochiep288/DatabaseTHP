using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class view_web_Report
    {
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string MA { get; set; }

        [StringLength(200)]
        public string NAME { get; set; }

        [StringLength(200)]
        public string NAME_SP { get; set; }

        [StringLength(50)]
        public string ID_MENU { get; set; }

        [StringLength(200)]
        public string REPORT { get; set; }

        [StringLength(200)]
        public string NOTE { get; set; }

        public string NAME_MENU { get; set; }

        public List<v_web_Report_Parameter> lstweb_Report_Parameter { get; set;}
    }
}