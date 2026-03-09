// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.v_dm_KhachHang
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll


namespace DatabaseTHP
{

    public class v_dm_KhachHang : dm_KhachHang
    {
        public string NAME_NHOMKHACHHANG { get; set; }

        public string NAME_KHUVUC { get; set; }

        public string CONGNOTHONGBAO { get; set; }

        public bool KHONGDUOCPHEPTAO { get; set; }

        public double? LATITUDE { get; set; }

        public double? LONGITUDE { get; set; }

        public string CONTENT_MAP { get; set; }
    }
}
