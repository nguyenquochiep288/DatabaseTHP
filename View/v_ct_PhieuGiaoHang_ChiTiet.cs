using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class v_ct_PhieuGiaoHang_ChiTiet : ct_PhieuGiaoHang_ChiTiet
    {
        public string MAPHIEU { get; set; }
        public string NAME_KHACHHANG_NCC { get; set; }

        public string ID_KHACHHANG_NCC { get; set; }

        public DateTime NGAYLAP { get; set; }

        public bool ISEDIT { get; set; }

        public string MAPHIEUXUAT { get; set; }

        public double TONGTIENTRAHANG { get; set; }
        
    }
}