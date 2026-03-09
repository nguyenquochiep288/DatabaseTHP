// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.v_ct_PhieuGiaoHang_ChiTiet
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;


namespace DatabaseTHP
{

    public class v_ct_PhieuGiaoHang_ChiTiet : ct_PhieuGiaoHang_ChiTiet
    {
        public string MAPHIEU { get; set; }

        public string NAME_KHACHHANG_NCC { get; set; }

        public string ID_KHACHHANG_NCC { get; set; }

        public DateTime NGAYLAP { get; set; }

        public bool ISEDIT { get; set; }

        public string MAPHIEUXUAT { get; set; }

        public double TONGTIENTRAHANG { get; set; }
    }
}
