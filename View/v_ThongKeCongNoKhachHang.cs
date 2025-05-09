using DatabaseTHP;
using DatabaseTHP.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class v_ThongKeCongNoKhachHang : v_dm_KhachHang
    {
        public double TONGTIENCONGNODAUKY { get; set; }
        public double TONGTIENPHIEUXUAT { get; set; }
        public double TONGTIENPHIEUNHAP { get; set; }
        public double TONGTIENPHIEUTHU { get; set; }
        public double TONGTIENPHIEUCHI { get; set; }
        public double TONGTIENCONGNOCUOIKY { get; set; }
        //{
        //    get { return TONGTIENCONGNODAUKY + TONGTIENPHIEUXUAT - TONGTIENPHIEUNHAP - TONGTIENPHIEUTHU + TONGTIENPHIEUCHI; }
        //}

        public bool ISTHEOTHOIGIAN { get; set; }
        public DateTime TUNGAY { get; set; }
        public DateTime DENNGAY { get; set; }

        public string ID_KHACHHANG { get; set; }
        public bool ISPHATSINHCONGNO { get; set; }
        public bool ISPHATSINHCONGNOTRONGKY { get; set; }
        public bool ISCONCONGNO { get; set; }
    }
}