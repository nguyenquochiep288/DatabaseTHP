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
    public class view_dm_KPI_KinhDoanh_NhanVien
    {
        public string MA { get; set; }

        public string NAME { get; set; }

        [StringLength(50)]
        public string LOC_ID { get; set; }

        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string ID_KPI_KINHDOANH { get; set; }

        [StringLength(50)]
        public string ID_NHANVIEN { get; set; }

        public int HINHTHUC { get; set; }

        public string NAME_HINHTHUC
        {
            get { return (API.lstHinhThucKhuyenMai().Where(e => e.ID == HINHTHUC).FirstOrDefault() != null ? API.lstHinhThucKhuyenMai().Where(e => e.ID == HINHTHUC).FirstOrDefault().NAME : ""); }
        }
        public string ID_TAIKHOAN { get; set; }
    }
}