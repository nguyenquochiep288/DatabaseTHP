using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class v_dm_ChuongTrinhKhuyenMai_Tang : dm_ChuongTrinhKhuyenMai_Tang
    {
       public List<v_dm_ChuongTrinhKhuyenMai> lstdm_ChuongTrinhKhuyenMai { get; set; }

        public string MA { get; set; }

        public string NAME { get; set; }

        public string NAME_DVT { get; set; }
    }
}