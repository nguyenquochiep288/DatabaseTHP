using DatabaseTHP;
using DatabaseTHP.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace DatabaseTHP
{
    public class v_dm_KhachHang : dm_KhachHang
    {
        public string NAME_NHOMKHACHHANG { get; set; }
        public string NAME_KHUVUC { get; set; }

        public string CONGNOTHONGBAO { get; set; }

        public bool KHONGDUOCPHEPTAO { get; set; }

        public Double? LATITUDE { get; set; }

        public Double? LONGITUDE { get; set; }

        public string CONTENT_MAP { get; set; }
        
    }
}