// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.view_dm_KPI_KinhDoanh_NhanVien
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using DatabaseTHP.Class;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace DatabaseTHP
{

    public class view_dm_KPI_KinhDoanh_NhanVien
    {
        public string MA { get; set; }

        public string NAME { get; set; }

        [StringLength(50)]
        public string LOC_ID { get; set; }

        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string ID_KPI_KINHDOANH { get; set; }

        [StringLength(50)]
        public string ID_NHANVIEN { get; set; }

        public int HINHTHUC { get; set; }

        public string NAME_HINHTHUC
        {
            get
            {
                return API.lstHinhThucKhuyenMai().Where<API.LoaiHangHoa>((Func<API.LoaiHangHoa, bool>)(e => e.ID == this.HINHTHUC)).FirstOrDefault<API.LoaiHangHoa>() == null ? "" : API.lstHinhThucKhuyenMai().Where<API.LoaiHangHoa>((Func<API.LoaiHangHoa, bool>)(e => e.ID == this.HINHTHUC)).FirstOrDefault<API.LoaiHangHoa>().NAME;
            }
        }

        public string ID_TAIKHOAN { get; set; }
    }
}
