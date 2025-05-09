using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class v_dm_KPI_KinhDoanh : dm_KPI_KinhDoanh
    {
        public List<v_dm_KPI_KinhDoanh_YeuCau> lstdm_KPI_KinhDoanh_YeuCau { get; set; }

        public List<v_dm_KPI_KinhDoanh_NhanVien> lstdm_KPI_KinhDoanh_NhanVien { get; set; }

        public string NAME_DVT { get; set; }
        public bool CHON { get; set; }
    }
}