// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.v_view_dm_ChuongTrinhKhuyenMai
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.Collections.Generic;


namespace DatabaseTHP
{

    public class v_view_dm_ChuongTrinhKhuyenMai : view_dm_ChuongTrinhKhuyenMai
    {
        public List<v_dm_ChuongTrinhKhuyenMai_Tang> lstdm_ChuongTrinhKhuyenMai_Tang { get; set; }

        public List<v_dm_ChuongTrinhKhuyenMai_YeuCau> lstdm_ChuongTrinhKhuyenMai_YeuCau { get; set; }
    }
}
