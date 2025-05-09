using DatabaseTHP;
using DatabaseTHP.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class v_dm_ChuongTrinhKhuyenMai_YeuCau : dm_ChuongTrinhKhuyenMai_YeuCau
    {
         public List<v_dm_ChuongTrinhKhuyenMai> lstdm_ChuongTrinhKhuyenMai { get; set; }

        public string MA { get; set; }

        public string NAME { get; set; }

        public string NAME_DVT { get; set; }
        public string NAME_HINHTHUC 
        { 
            get { return (API.lstHinhThucKhuyenMai().Where(e => e.ID == HINHTHUC).FirstOrDefault() != null ? API.lstHinhThucKhuyenMai().Where(e => e.ID == HINHTHUC).FirstOrDefault().NAME : ""); }
        }
    }
}