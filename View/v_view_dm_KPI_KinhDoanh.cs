// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.v_view_dm_KPI_KinhDoanh
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.Collections.Generic;


namespace DatabaseTHP
{

    public class v_view_dm_KPI_KinhDoanh : view_dm_KPI_KinhDoanh
    {
        public List<v_dm_KPI_KinhDoanh_YeuCau> lstdm_KPI_KinhDoanh_YeuCau { get; set; }

        public List<v_dm_KPI_KinhDoanh_NhanVien> lstdm_KPI_KinhDoanh_NhanVien { get; set; }
    }
}
