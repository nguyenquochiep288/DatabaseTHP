// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.v_nv_NghiPhep
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using DatabaseTHP.Class;
using System;
using System.Linq;


namespace DatabaseTHP
{

    public class v_nv_NghiPhep : nv_NghiPhep
    {
        public string MA_NHANVIEN { get; set; }

        public string NAME_NHANVIEN { get; set; }

        public string NAME_THANGLUONG { get; set; }

        public string MA_NHANVIENDUYETPHEP { get; set; }

        public string NAME_NHANVIENDUYETPHEP { get; set; }

        public double NAMPHEP { get; set; }

        public string NAME_HINHTHUC
        {
            get
            {
                return API.lstHinhThucNghiPhep().Where<API.LoaiHangHoa>((Func<API.LoaiHangHoa, bool>)(e => e.ID == this.HINHTHUCNGHIPHEP)).FirstOrDefault<API.LoaiHangHoa>() == null ? "" : API.lstHinhThucNghiPhep().Where<API.LoaiHangHoa>((Func<API.LoaiHangHoa, bool>)(e => e.ID == this.HINHTHUCNGHIPHEP)).FirstOrDefault<API.LoaiHangHoa>().NAME;
            }
            set
            {
            }
        }

        public string NAME_DUYETPHEP
        {
            get => this.ISDUYETPHEP ? "Đã duyệt phép" : "Chưa phê duyệt";
            set
            {
            }
        }
    }
}
