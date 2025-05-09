using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class v_view_dm_KPI_KinhDoanh : view_dm_KPI_KinhDoanh
    {
        public List<v_dm_KPI_KinhDoanh_YeuCau> lstdm_KPI_KinhDoanh_YeuCau { get; set; }

        public List<v_dm_KPI_KinhDoanh_NhanVien> lstdm_KPI_KinhDoanh_NhanVien { get; set; }
    }
}