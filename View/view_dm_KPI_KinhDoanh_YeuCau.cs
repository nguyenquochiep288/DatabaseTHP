using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DatabaseTHP.Class;

namespace DatabaseTHP
{
    public class view_dm_KPI_KinhDoanh_YeuCau
    {
        public string MA { get; set; }

        public string NAME { get; set; }

        public string NAME_DVT { get; set; }

        [StringLength(50)]
        public string LOC_ID { get; set; }

        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string ID_KPI_KINHDOANH { get; set; }

        [StringLength(50)]
        public string ID_HANGHOA { get; set; }

        public double SOLUONG { get; set; }

        [StringLength(50)]
        public string ID_DVT { get; set; }

        public double SOTIEN { get; set; }
        public double TYLE_QD { get; set; }

        public double QTY_TOTAL { get; set; }

        public int HINHTHUC { get; set; }

        public string NAME_HINHTHUC
        {
            get { return (API.lstHinhThucKhuyenMai().Where(e => e.ID == HINHTHUC).FirstOrDefault() != null ? API.lstHinhThucKhuyenMai().Where(e => e.ID == HINHTHUC).FirstOrDefault().NAME : ""); }
        }

        public double CHIETKHAU { get; set; }

        public double TIENGIAM { get; set; }

        public int HINHTHUC_TINHKPI { get; set; }

        public string NAME_HINHTHUC_TINHKPI
        {
            get { return (API.lstHinhThucTinhKPI().Where(e => e.ID == HINHTHUC_TINHKPI).FirstOrDefault() != null ? API.lstHinhThucKhuyenMai().Where(e => e.ID == HINHTHUC).FirstOrDefault().NAME : ""); }
        }
    }
}