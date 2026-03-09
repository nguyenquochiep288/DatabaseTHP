// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.v_ct_HoaDon
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.Collections.Generic;


namespace DatabaseTHP
{

    public class v_ct_HoaDon : ct_HoaDon
    {
        public List<v_ct_HoaDon_ChiTiet> lstct_HoaDon_ChiTiet { get; set; }

        public List<Product_Detail> lstct_HoaDon_ChiTiet_TraVe { get; set; }

        public string NAME_LOAIHOADON { get; set; }

        public string NAME_NGUOITAO { get; set; }

        public bool CHON { get; set; }

        public string THONGTINTHEM { get; set; }
    }
}