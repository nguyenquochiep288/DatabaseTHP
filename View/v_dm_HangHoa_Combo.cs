using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class v_dm_HangHoa_Combo : dm_HangHoa_Combo
    {
        public string MA { get; set; }
        public string NAME { get; set; }
        public string NAME_DVT { get; set; }
        public bool ISEDIT { get; set; }
    }
}