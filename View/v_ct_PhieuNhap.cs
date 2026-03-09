// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.v_ct_PhieuNhap
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.Collections.Generic;


namespace DatabaseTHP
{

    public class v_ct_PhieuNhap : ct_PhieuNhap
    {
        public List<v_ct_PhieuNhap_ChiTiet> lstct_PhieuNhap_ChiTiet { get; set; }

        public string NAME_LOAIPHIEUNHAP { get; set; }

        public string NAME_KHACHHANG_NCC { get; set; }

        public string NAME_KHO { get; set; }

        public string NAME_NHANVIEN { get; set; }

        public string myModalAdd { get; set; }

        public string NAME_NGUOITAO { get; set; }
    }
}
