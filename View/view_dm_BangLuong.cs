// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.view_dm_BangLuong
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;
using System.Collections.Generic;


namespace DatabaseTHP
{

    public class view_dm_BangLuong
    {
        public string LOC_ID { get; set; }

        public string ID { get; set; }

        public string ID_PHONGBAN { get; set; }

        public string MA { get; set; }

        public string NAME { get; set; }

        public DateTime? THOIGIANSUA { get; set; }

        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }

        public string ID_NGUOITAO { get; set; }

        public bool ISACTIVE { get; set; }

        public List<v_dm_BangLuong_ChiTiet> lstdm_BangLuong_ChiTiet { get; set; }

        public string NAME_PHONGBAN { get; set; }

        public string MA_PHONGBAN { get; set; }
    }
}
