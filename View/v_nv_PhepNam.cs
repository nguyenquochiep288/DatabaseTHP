using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class v_nv_PhepNam : nv_PhepNam
    {
        public string MA_NHANVIEN { get; set; }
        public string NAME_NHANVIEN { get; set; }

        public Boolean ISALL { get; set; }
    }
}