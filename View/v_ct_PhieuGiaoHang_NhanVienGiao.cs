using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class v_ct_PhieuGiaoHang_NhanVienGiao : ct_PhieuGiaoHang_NhanVienGiao
    {
       public string NAME_NHANVIEN { get; set; }
        public string MA_NHANVIEN { get; set; }
        public bool ISEDIT { get; set; }
    }
}