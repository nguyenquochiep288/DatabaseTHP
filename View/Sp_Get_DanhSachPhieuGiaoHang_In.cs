using DatabaseTHP;
using DatabaseTHP.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class Sp_Get_DanhSachPhieuGiaoHang_In : v_ct_PhieuXuat_ChiTiet
    {
        public string ID_KHACHHANG_NCC { get; set; }

        public string ID_PHIEUGIAOHANG { get; set; }

        public string NAME_NCC { get; set; }

        public string NAME_DVT_QD { get; set; }

        public string NAME_NHOMHANGHOA { get; set; }

        public bool STATUS_QD { get; set; }

        public double TYLE_QD_HH { get; set; }

        public decimal TONGSOLUONGHH { get; set; }
        
        public string NAME_SOLUONG
        {
            get {
                try
                {
                    int PhanNguyen = 0;
                    PhanNguyen = Convert.ToInt32(TONGSOLUONGHH) / Convert.ToInt32(TYLE_QD_HH);
                    return (PhanNguyen > 0 ? PhanNguyen.ToString("N0") + " " + NAME_DVT : "") + ((TONGSOLUONGHH - Convert.ToDecimal(PhanNguyen * TYLE_QD_HH)) > 0 ? " " + (TONGSOLUONGHH - Convert.ToDecimal(PhanNguyen * TYLE_QD_HH)).ToString("N0") + " " + NAME_DVT_QD : "");
                }
                catch
                {
                    return "";
                }

            }
            set { }
        }

        public string NAME_KHACHHANG_NCC { get; set; }
        public string DIACHI_KHACHHANG_NCC { get; set; }
        public string TEL_KHACHHANG_NCC { get; set; }
        public string MAPHIEU { get; set; }
        public double TONGTIENTINHTHUE { get; set; }
        public string NAME_KHUVUC { get; set; }
        public string BIENSOXE { get; set; }
    }
}