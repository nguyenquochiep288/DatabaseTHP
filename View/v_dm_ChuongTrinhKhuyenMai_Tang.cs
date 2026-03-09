// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.v_dm_ChuongTrinhKhuyenMai_Tang
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.Collections.Generic;

namespace DatabaseTHP
{

    public class v_dm_ChuongTrinhKhuyenMai_Tang : dm_ChuongTrinhKhuyenMai_Tang
    {
        public List<v_dm_ChuongTrinhKhuyenMai> lstdm_ChuongTrinhKhuyenMai { get; set; }

        public string MA { get; set; }

        public string NAME { get; set; }

        public string NAME_DVT { get; set; }
    }
}
