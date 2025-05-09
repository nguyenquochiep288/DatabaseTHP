using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class v_dm_ChuongTrinhKhuyenMai : dm_ChuongTrinhKhuyenMai
    {
        public List<v_dm_ChuongTrinhKhuyenMai_Tang> lstdm_ChuongTrinhKhuyenMai_Tang { get; set; }

        public List<v_dm_ChuongTrinhKhuyenMai_YeuCau> lstdm_ChuongTrinhKhuyenMai_YeuCau { get; set; }

        public string NAME_DVT { get; set; }
    }
}