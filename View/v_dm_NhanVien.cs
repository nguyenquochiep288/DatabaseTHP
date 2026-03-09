// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.v_dm_NhanVien
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using DatabaseTHP.Class;
using System;
using System.Linq;


namespace DatabaseTHP
{

    public class v_dm_NhanVien : dm_NhanVien
    {
        public string NAME_CHUCVU { get; set; }

        public string NAME_PHONGBAN { get; set; }

        public string UserName { get; set; }

        public string NAME_GIOITINH
        {
            get
            {
                return API.lstGioiTinh().Where<API.LoaiHangHoa>((Func<API.LoaiHangHoa, bool>)(e => e.ID.ToString() == this.GIOITINH)).FirstOrDefault<API.LoaiHangHoa>() == null ? "" : API.lstGioiTinh().Where<API.LoaiHangHoa>((Func<API.LoaiHangHoa, bool>)(e => e.ID.ToString() == this.GIOITINH)).FirstOrDefault<API.LoaiHangHoa>().NAME;
            }
            set
            {
            }
        }
    }
}
