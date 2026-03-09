// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.view_nv_PhepNam
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;


namespace DatabaseTHP
{

    public class view_nv_PhepNam
    {
        public string LOC_ID { get; set; }

        public string ID { get; set; }

        public string ID_NHANVIEN { get; set; }

        public double NAM { get; set; }

        public DateTime NGAYBATDAU { get; set; }

        public DateTime NGAYKETTHUC { get; set; }

        public double SONGAYPHEP { get; set; }

        public double SONGAYPHEPDADUNG { get; set; }

        public DateTime? THOIGIANSUA { get; set; }

        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }

        public string ID_NGUOITAO { get; set; }

        public string MA_NHANVIEN { get; set; }

        public string NAME_NHANVIEN { get; set; }
    }
}