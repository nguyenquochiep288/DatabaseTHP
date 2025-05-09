using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class v_nv_ChamCong : nv_ChamCong
    {
        public string MA_NHANVIEN { get; set; }
        public string NAME_NHANVIEN { get; set; }
        public string NAME_THANGLUONG { get; set; }
        public string LATITUDELONGITUDE { get; set; }
        public string MYPUBLICIPV4 { get; set; }

        public string BUTTONTYPE { get; set; }
    }
}