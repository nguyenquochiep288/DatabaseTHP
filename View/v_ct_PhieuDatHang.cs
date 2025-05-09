using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class v_ct_PhieuDatHang : ct_PhieuDatHang
    {
        public List<v_ct_PhieuDatHang_ChiTiet> lstct_PhieuDatHang_ChiTiet { get; set; }

        public string NAME_KHACHHANG { get; set; }

        public string NAME_KHO { get; set; }

        public string NAME_NHANVIEN { get; set; }

        public string MAPHIEUXUAT { get; set; }

        public bool CHON { get; set; }

        public string NAME_NGUOITAO { get; set; }
    }
}