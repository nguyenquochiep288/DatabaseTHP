using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class v_ct_PhieuGiaoHang : ct_PhieuGiaoHang
    {
        public string NAME_XE { get; set; }
        public List<v_ct_PhieuGiaoHang_ChiTiet> lstct_PhieuGiaoHang_ChiTiet { get; set; }
        public List<v_ct_PhieuGiaoHang_NhanVienGiao> lstct_PhieuGiaoHang_NhanVienGiao { get; set; }
        public List<v_dm_LoaiPhieuChi> lstdm_LoaiPhieuChi { get; set; }
        public List<v_dm_LoaiPhieuThu> lstdm_LoaiPhieuThu { get; set; }
        public string QR_CODE { get; set; }

        public int SOLAN { get; set; }
    }
}