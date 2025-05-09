using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class v_view_dm_ChuongTrinhKhuyenMai : view_dm_ChuongTrinhKhuyenMai
    {
        public List<v_dm_ChuongTrinhKhuyenMai_Tang> lstdm_ChuongTrinhKhuyenMai_Tang { get; set; }

        public List<v_dm_ChuongTrinhKhuyenMai_YeuCau> lstdm_ChuongTrinhKhuyenMai_YeuCau { get; set; }
    }
}