using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class v_ct_PhieuChi : ct_PhieuChi
    {
        public string NAME_KHACHHANG_NCC_NHANVIEN { get; set; }

        public string NAME_LOAIPHIEUCHI { get; set; }

        public string NAME_TAIKHOANNGANHANG { get; set; }

        public string myModalAdd { get; set; }

        public string NAME_NGUOITAO { get; set; }
    }
}