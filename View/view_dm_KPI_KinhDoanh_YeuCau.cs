// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.view_dm_KPI_KinhDoanh_YeuCau
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using DatabaseTHP.Class;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace DatabaseTHP
{

    public class view_dm_KPI_KinhDoanh_YeuCau
    {
        public string MA { get; set; }

        public string NAME { get; set; }

        public string NAME_DVT { get; set; }

        [StringLength(50)]
        public string LOC_ID { get; set; }

        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string ID_KPI_KINHDOANH { get; set; }

        [StringLength(50)]
        public string ID_HANGHOA { get; set; }

        public double SOLUONG { get; set; }

        [StringLength(50)]
        public string ID_DVT { get; set; }

        public double SOTIEN { get; set; }

        public double TYLE_QD { get; set; }

        public double QTY_TOTAL { get; set; }

        public int HINHTHUC { get; set; }

        public string NAME_HINHTHUC
        {
            get
            {
                return API.lstHinhThucKhuyenMai().Where<API.LoaiHangHoa>((Func<API.LoaiHangHoa, bool>)(e => e.ID == this.HINHTHUC)).FirstOrDefault<API.LoaiHangHoa>() == null ? "" : API.lstHinhThucKhuyenMai().Where<API.LoaiHangHoa>((Func<API.LoaiHangHoa, bool>)(e => e.ID == this.HINHTHUC)).FirstOrDefault<API.LoaiHangHoa>().NAME;
            }
        }

        public double CHIETKHAU { get; set; }

        public double TIENGIAM { get; set; }

        public int HINHTHUC_TINHKPI { get; set; }

        public string NAME_HINHTHUC_TINHKPI
        {
            get
            {
                return API.lstHinhThucTinhKPI().Where<API.LoaiHangHoa>((Func<API.LoaiHangHoa, bool>)(e => e.ID == this.HINHTHUC_TINHKPI)).FirstOrDefault<API.LoaiHangHoa>() == null ? "" : API.lstHinhThucKhuyenMai().Where<API.LoaiHangHoa>((Func<API.LoaiHangHoa, bool>)(e => e.ID == this.HINHTHUC)).FirstOrDefault<API.LoaiHangHoa>().NAME;
            }
        }
    }
}
