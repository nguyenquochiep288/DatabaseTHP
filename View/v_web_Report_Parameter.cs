using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class v_web_Report_Parameter : web_Report_Parameter
    {
        public string NAME_REPORT { get; set; }

        public string NAME_PARAMETER { get; set; }

        public string NAME { get; set; }

        public string VALUE { get; set; }

        public string TYPE { get; set; }

        public string MA_PARAMETER { get; set; }
    }
}