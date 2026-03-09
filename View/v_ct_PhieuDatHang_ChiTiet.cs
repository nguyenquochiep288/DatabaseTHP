// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.v_ct_PhieuDatHang_ChiTiet
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.Collections.Generic;


namespace DatabaseTHP
{

    public class v_ct_PhieuDatHang_ChiTiet : ct_PhieuDatHang_ChiTiet
    {
        public List<v_ct_PhieuDatHang_ChiTiet> lstct_PhieuDatHang_ChiTiet { get; set; }

        public string MA { get; set; }

        public string NAME { get; set; }

        public string NAME_DVT { get; set; }

        public bool ISEDIT { get; set; }

        public string ID_DVT_COMBO { get; set; }

        public double QTY_COMBO { get; set; }

        public double TYLE_QD_COMBO { get; set; }

        public double QTY_TOTAL_COMBO { get; set; }

        public string ID_LOC { get; set; }

        public string TYPE { get; set; }

        public string ID_KHO { get; set; }

        public string ID_HANGHOA { get; set; }

        public double QTY { get; set; }

        public string ID_NHOMHANGHOA { get; set; }

        public string NAME_KHACHHANG { get; set; }

        public string TEL_KHACHHANG { get; set; }

        public string DIACHI_KHACHHANG { get; set; }

        public double TRONGLUONG { get; set; }

        public string NAME_NHOMHANGHOA { get; set; }

        public string NAME_KHUVUC { get; set; }

        public string NAME_NHANVIEN { get; set; }

        public string MAPHIEU { get; set; }
    }
}
