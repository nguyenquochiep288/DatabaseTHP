using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class v_nv_BangLuong : nv_BangLuong
    {
        public string MA_NHANVIEN { get; set; }
        public string NAME_NHANVIEN { get; set; }
        public string MA_THANGLUONG { get; set; }
        public string NAME_THANGLUONG { get; set; }
        public List<nv_BangLuong_ChiTiet> lstnv_BangLuong_ChiTiet { get; set; }
    }
}