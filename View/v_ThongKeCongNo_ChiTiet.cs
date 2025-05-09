using DatabaseTHP;
using DatabaseTHP.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class v_ThongKeCongNo_ChiTiet
    {
        public string LOAIPHIEU { get; set; }
        public DateTime NGAY { get; set; }
        public string ID_PHIEU { get; set; }
        public string MAPHIEU { get; set; }
        public double THU { get; set; }
        public double CHI { get; set; }
        public double HIENTAI { get; set; }
        public string DIENGIAI { get; set; }
        public Int32 STT { get; set; }
    }
}