using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Web.Mvc;

namespace DatabaseTHP.StoredProcedure.Parameter
{
    [Bind(Include = "ID_LOAIPHIEUTHU,ID_LOAIPHIEUCHI,ID_LOAIPHIEUNHAP,SOLAN,HINHTHUC_THUCHI,ID_NHACUNGCAP,HINHTHUCBAOCAO_HANGHOA,ID_PHONGBAN,ISDETAIL,ID_HANGHOA,ID_NHOMHANGHOA,HINHTHUC_PHIEUXUATHANG_KHUYENMAI,ID_CHUONGTRINHKHUYENMAI,HINHTHUC,ID_REPORT,NAME_SP,LOC_ID,TUNGAY,DENNGAY,KEY,ID_NHANVIEN,ID_PHIEUNHAP,ID_PHIEUXUAT,ID_PHIEUDATHANG,ID_PHIEUGIAOHANG,ID_KHACHHANG,ID_KHUVUC,ID_NHOMKHACHHANG,HINHTHUC_BAOCAOTAICHINH")]
    public class SP_Parameter_Report
    {
        public string CONTROLLER { get; set; }
        public string ID_REPORT { get; set; }
        public string NAME_SP { get; set; }

        [StringLength(50)]
        public string LOC_ID { get; set; }

        public DateTime? TUNGAY { get; set; }

        public DateTime? DENNGAY { get; set; }

        [StringLength(250)]
        public string KEY { get; set; }

        public string ID_NHANVIEN { get; set; }

        public string ID_PHIEUNHAP { get; set; }

        public string ID_PHIEUXUAT { get; set; }

        public string ID_PHIEUDATHANG { get; set; }

        public string ID_PHIEUGIAOHANG { get; set; }

        public string ID_PHIEUCHI { get; set; }

        public string ID_PHIEUTHU { get; set; }

        public string ID_KHACHHANG { get; set; }

        public string ID_KHUVUC { get; set; }

        public string ID_NHOMKHACHHANG { get; set; }

        public string ID_NHOMHANGHOA { get; set; }
        public string ID_HANGHOA { get; set; }

        public int? HINHTHUC { get; set; }

        public int? HINHTHUC_BAOCAOTAICHINH { get; set; }

        public int? HINHTHUC_PHIEUXUATHANG_KHUYENMAI { get; set; }
        public string ID_CHUONGTRINHKHUYENMAI { get; set; }
        public bool ISDETAIL { get; set; }
        public string ID_PHONGBAN { get; set; }
        public string HINHTHUCBAOCAO_HANGHOA { get; set; }
        public string ID_NHACUNGCAP { get; set; }

        public string HINHTHUC_THUCHI { get; set; }

        public int? SOLAN { get; set; }

        public string ID_LOAIPHIEUNHAP { get; set; }
        public string ID_LOAIPHIEUTHU { get; set; }
        public string ID_LOAIPHIEUCHI { get; set; }
    }
}
