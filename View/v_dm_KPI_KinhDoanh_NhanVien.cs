// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.v_dm_KPI_KinhDoanh_NhanVien
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using DatabaseTHP.Class;
using System;
using System.Collections.Generic;
using System.Linq;


namespace DatabaseTHP { 

public class v_dm_KPI_KinhDoanh_NhanVien : dm_KPI_KinhDoanh_NhanVien
{
  public List<v_dm_KPI_KinhDoanh> lstdm_KPI_KinhDoanh { get; set; }

  public string MA { get; set; }

  public string NAME { get; set; }

  public string NAME_HINHTHUC
  {
    get
    {
      return API.lstHinhThucNhanVien().Where<API.LoaiHangHoa>((Func<API.LoaiHangHoa, bool>) (e => e.ID == this.HINHTHUC)).FirstOrDefault<API.LoaiHangHoa>() == null ? "" : API.lstHinhThucNhanVien().Where<API.LoaiHangHoa>((Func<API.LoaiHangHoa, bool>) (e => e.ID == this.HINHTHUC)).FirstOrDefault<API.LoaiHangHoa>().NAME;
    }
  }

  public string ID_TAIKHOAN { get; set; }
}
}
