// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.view_dm_KhachHang
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;


namespace DatabaseTHP
{

    public class view_dm_KhachHang
    {
        public string LOC_ID { get; set; }

        public string ID { get; set; }

        public string MA { get; set; }

        public string NAME { get; set; }

        public string ADDRESS { get; set; }

        public string TEL { get; set; }

        public string FAX { get; set; }

        public string EMAIL { get; set; }

        public DateTime? NGAYSINH { get; set; }

        public double DIS { get; set; }

        public double RATE { get; set; }

        public string ID_NHOMKHACHHANG { get; set; }

        public string NAME_NHOMKHACHHANG { get; set; }

        public double MAX_CONGNO { get; set; }

        public int SONGAY { get; set; }

        public int LEVEL_PRICE { get; set; }

        public string ID_KHUVUC { get; set; }

        public string NAME_KHUVUC { get; set; }

        public bool ISACTIVE { get; set; }

        public bool ISDEFAULT { get; set; }

        public double CONGNODAUKY { get; set; }

        public DateTime? THOIGIANSUA { get; set; }

        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }

        public string ID_NGUOITAO { get; set; }

        public double? LATITUDE { get; set; }

        public double? LONGITUDE { get; set; }

        public string CONTENT_MAP { get; set; }

        public string DIACHI { get; set; }

        public string MASOTHUE { get; set; }

        public string CCCD { get; set; }

        public string TENDONVI { get; set; }

        public string TENKHACHHANG { get; set; }

        public string PICTURE { get; set; }
    }
}
