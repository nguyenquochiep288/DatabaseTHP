using DatabaseTHP;
using DatabaseTHP.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class v_ct_PhieuXuat : ct_PhieuXuat
    {
        public List<v_ct_PhieuXuat_ChiTiet> lstct_PhieuXuat_ChiTiet { get; set; }

        public string NAME_KHACHHANG_NCC { get; set; }

        public string DIACHI_KHACHHANG_NCC { get; set; }

        public string NAME_KHO { get; set; }

        public string NAME_NHANVIEN { get; set; }

        public string NAME_LOAIPHIEUXUAT { get; set; }

        public string MAPHIEUXUAT { get; set; }

        public string TONGTIENNO { get; set; }
        public string NAME_NGUOITAO { get; set; }
    }
}