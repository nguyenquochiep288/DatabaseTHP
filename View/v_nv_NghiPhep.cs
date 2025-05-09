using DatabaseTHP;
using DatabaseTHP.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static DatabaseTHP.Class.API;

namespace DatabaseTHP
{
    public class v_nv_NghiPhep : nv_NghiPhep
    {
        public string MA_NHANVIEN { get; set; }
        public string NAME_NHANVIEN { get; set; }
        public string NAME_THANGLUONG { get; set; }
        public string MA_NHANVIENDUYETPHEP { get; set; }
        public string NAME_NHANVIENDUYETPHEP { get; set; }
        public double NAMPHEP { get; set; }
        public string NAME_HINHTHUC
        {
            get { return (API.lstHinhThucNghiPhep().Where(e => e.ID == HINHTHUCNGHIPHEP).FirstOrDefault() != null ? API.lstHinhThucNghiPhep().Where(e => e.ID == HINHTHUCNGHIPHEP).FirstOrDefault().NAME : ""); }
            set { }
        }

        public string NAME_DUYETPHEP
        {
            get { 
                if(ISDUYETPHEP)
                    return "Đã duyệt phép";
                else
                    return "Chưa phê duyệt";
            }
            set { }
        }
    }
}