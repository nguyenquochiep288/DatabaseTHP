// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.v_ct_PhieuXuat
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.Collections.Generic;


namespace DatabaseTHP
{

    public class v_ct_PhieuXuat : ct_PhieuXuat
    {
        public List<v_ct_PhieuXuat_ChiTiet> lstct_PhieuXuat_ChiTiet { get; set; }

        public string NAME_KHACHHANG_NCC { get; set; }

        public string DIACHI_KHACHHANG_NCC { get; set; }

        public string NAME_KHO { get; set; }

        public string NAME_NHANVIEN { get; set; }

        public string NAME_LOAIPHIEUXUAT { get; set; }

        public string MAPHIEUXUAT { get; set; }

        public string TONGTIENNO { get; set; }

        public string NAME_NGUOITAO { get; set; }

        public string MAPHIEU_HOADON { get; set; }

        public bool CHON { get; set; }

        public string DANHSACHPHIEUTRAHANG { get; set; }
    }
}