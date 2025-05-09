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
    public class view_dm_ChuongTrinhKhuyenMai_YeuCau
    {
        public string MA { get; set; }

        public string NAME { get; set; }

        public string NAME_DVT { get; set; }

        [StringLength(50)]
        public string LOC_ID { get; set; }

        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string ID_CHUONGTRINHKHUYENMAI { get; set; }

        [StringLength(50)]
        public string ID_HANGHOA { get; set; }

        public double SOLUONG { get; set; }

        [StringLength(50)]
        public string ID_DVT { get; set; }

        public double SOTIEN { get; set; }
        public double TYLE_QD { get; set; }

        public double QTY_TOTAL { get; set; }

        public int HINHTHUC { get; set; }

        public double CHIETKHAU { get; set; }
        public double TIENGIAM { get; set; }
        public string NAME_HINHTHUC
        {
            get { return (API.lstHinhThucKhuyenMai().Where(e => e.ID == HINHTHUC).FirstOrDefault() != null ? API.lstHinhThucKhuyenMai().Where(e => e.ID == HINHTHUC).FirstOrDefault().NAME : ""); }
        }

        public bool ISBATBUOC { get; set; }
        public double SOLUONG_BATBUOC { get; set; }
    }
}