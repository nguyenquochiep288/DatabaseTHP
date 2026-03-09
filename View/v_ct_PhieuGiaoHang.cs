// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.v_ct_PhieuGiaoHang
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.Collections.Generic;


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
