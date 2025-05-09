using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class v_Tinh_KPI_KinhDoanh
    {
        public string ID_NHANVIEN { get; set; }

        public string NAME_NHANVIEN { get; set; }

        public List<v_Tinh_KPI_KinhDoanh_ChiTiet> lstTinh_KPI_KinhDoanh_ChiTiet { get; set; }

        public double SOTIEN_KPI { get; set; }


    }

    public class v_Tinh_KPI_KinhDoanh_ChiTiet
    {
        public string ID_KPI_KINHDOANH { get; set; }

        public string NAME_KPI_KINHDOANH { get; set; }

        public int HINHTHUC { get; set; }

        public string NAME_HINHTHUC { get; set; }

        public string ID_HANGHOA { get; set; }

        public string NAME_HANGHOA { get; set; }
        public double TONGTIEN_KPI { get; set; }
        public double TONGTIEN { get; set; }
        public double TONGTIEN_TRAHANG { get; set; }
        public string TONGSOLUONG_KPI { get; set; }
        public string NAME_DVT { get; set; }
        public string NAME_DVT_QD { get; set; }
        public double TYLE_QD { get; set; }
        public double TONGSOLUONG { get; set; }
        public double TONGSOLUONG_TRAHANG { get; set; }

        public double CHIETKHAU { get; set; }

        public double TIENTHUONG { get; set; }

        public double SOTIEN_KPI { get; set; }
        public int STT { get; set; }
    }
}