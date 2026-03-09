// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.v_ThongKeCongNoNhanVien
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;

namespace DatabaseTHP
{

    public class v_ThongKeCongNoNhanVien : v_dm_NhanVien
    {
        public double TONGTIENCONGNODAUKY { get; set; }

        public double TONGTIENPHIEUXUAT { get; set; }

        public double TONGTIENPHIEUNHAP { get; set; }

        public double TONGTIENPHIEUTHU { get; set; }

        public double TONGTIENPHIEUCHI { get; set; }

        public double TONGTIENCONGNOCUOIKY { get; set; }

        public bool ISTHEOTHOIGIAN { get; set; }

        public DateTime TUNGAY { get; set; }

        public DateTime DENNGAY { get; set; }

        public string ID_NHANVIEN { get; set; }

        public bool ISPHATSINHCONGNO { get; set; }

        public bool ISPHATSINHCONGNOTRONGKY { get; set; }

        public bool ISCONCONGNO { get; set; }
    }
}