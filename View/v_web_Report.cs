using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class v_web_Report : web_Report
    {
        public string NAME_MENU { get; set; }

        public List<v_web_Report_Parameter> lstweb_Report_Parameter { get; set;}

    }
}