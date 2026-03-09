// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.v_dm_BangLuong
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.Collections.Generic;

namespace DatabaseTHP
{

    public class v_dm_BangLuong : dm_BangLuong
    {
        public string NAME_PHONGBAN { get; set; }

        public string MA_PHONGBAN { get; set; }

        public List<v_dm_BangLuong_ChiTiet> lstdm_BangLuong_ChiTiet { get; set; }
    }
}
