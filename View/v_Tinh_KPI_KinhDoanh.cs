// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.v_Tinh_KPI_KinhDoanh
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.Collections.Generic;


namespace DatabaseTHP
{

    public class v_Tinh_KPI_KinhDoanh
    {
        public string ID_NHANVIEN { get; set; }

        public string NAME_NHANVIEN { get; set; }

        public List<v_Tinh_KPI_KinhDoanh_ChiTiet> lstTinh_KPI_KinhDoanh_ChiTiet { get; set; }

        public double SOTIEN_KPI { get; set; }
    }
}
