using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class v_dm_BangLuong : dm_BangLuong
    {
        public string NAME_PHONGBAN { get; set; }
        public string MA_PHONGBAN { get; set; }

        public List<v_dm_BangLuong_ChiTiet> lstdm_BangLuong_ChiTiet { get; set; }
    }
}