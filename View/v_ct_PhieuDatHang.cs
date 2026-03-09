// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.v_ct_PhieuDatHang
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.Collections.Generic;


namespace DatabaseTHP
{

    public class v_ct_PhieuDatHang : ct_PhieuDatHang
    {
        public List<v_ct_PhieuDatHang_ChiTiet> lstct_PhieuDatHang_ChiTiet { get; set; }

        public string DIACHI_KHACHHANG { get; set; }

        public string MA_KHACHHANG { get; set; }

        public string NAME_KHACHHANG { get; set; }

        public string NAME_KHO { get; set; }

        public string NAME_NHANVIEN { get; set; }

        public string MAPHIEUXUAT { get; set; }

        public bool CHON { get; set; }

        public string NAME_NGUOITAO { get; set; }
    }
}
