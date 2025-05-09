using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class v_ct_PhieuNhap : ct_PhieuNhap
    {
        public List<v_ct_PhieuNhap_ChiTiet> lstct_PhieuNhap_ChiTiet { get; set; }

        public string NAME_LOAIPHIEUNHAP { get; set; }

        public string NAME_KHACHHANG_NCC { get; set; }

        public string NAME_KHO { get; set; }

        public string NAME_NHANVIEN { get; set; }

        public string myModalAdd { get; set; }
        public string NAME_NGUOITAO { get; set; }

    }
}