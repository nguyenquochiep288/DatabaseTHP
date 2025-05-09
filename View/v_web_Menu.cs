using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class v_web_Menu : web_Menu
    {

        public string NAME_QUYENCHA { get; set; }

        public string NAME_ORDERBY  { get; set; }

        public string ID_REPORT { get; set; }

        public List<v_web_Report_Parameter> lstweb_Report_Parameter { get; set; }
    }
}