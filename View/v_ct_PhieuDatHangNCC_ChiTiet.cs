using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class v_ct_PhieuDatHangNCC_ChiTiet : ct_PhieuDatHangNCC_ChiTiet
    {
        public string MA { get; set; }
        public string NAME { get; set; }
        public string NAME_DVT { get; set; }
        public bool ISEDIT { get; set; }
        public string ID_DVT_COMBO { get; set; }
        public double QTY_COMBO { get; set; }
        public double TYLE_QD_COMBO { get; set; }
        public double QTY_TOTAL_COMBO { get; set; }
        public string ID_LOC { get; set; }
        public string TYPE { get; set; }
        public Boolean ISKHUYENMAI { get; set; }
        public string ID_KHO { get; set; }
        public string ID_HANGHOA { get; set; }
        public double QTY { get; set; }
    }
}