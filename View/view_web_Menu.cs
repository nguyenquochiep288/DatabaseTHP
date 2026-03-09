// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.view_web_Menu
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;


namespace DatabaseTHP
{

    public class view_web_Menu
    {
        public string ID { get; set; }

        public string NAME { get; set; }

        public string ACTIONNAME { get; set; }

        public string CONTROLLERNAME { get; set; }

        public string ID_QUYENCHA { get; set; }

        public string ICON { get; set; }

        public int STT { get; set; }

        public bool ISACTIVE { get; set; }

        public DateTime? THOIGIANSUA { get; set; }

        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }

        public string ID_NGUOITAO { get; set; }

        public string NAME_QUYENCHA { get; set; }

        public string NAME_ORDERBY { get; set; }

        public string ID_REPORT { get; set; }
    }
}
