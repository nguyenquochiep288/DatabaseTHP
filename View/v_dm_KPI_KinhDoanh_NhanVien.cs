using DatabaseTHP;
using DatabaseTHP.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class v_dm_KPI_KinhDoanh_NhanVien : dm_KPI_KinhDoanh_NhanVien
    {
         public List<v_dm_KPI_KinhDoanh> lstdm_KPI_KinhDoanh { get; set; }

        public string MA { get; set; }

        public string NAME { get; set; }

        public string NAME_HINHTHUC 
        { 
            get { return (API.lstHinhThucNhanVien().Where(e => e.ID == HINHTHUC).FirstOrDefault() != null ? API.lstHinhThucNhanVien().Where(e => e.ID == HINHTHUC).FirstOrDefault().NAME : ""); }
        }
        public string ID_TAIKHOAN { get; set; }
    }
}