using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DatabaseTHP.StoredProcedure.Parameter
{
    [Bind(Include = "NGAYCONG,ID_BANGLUONG,ID_THANGLUONG,ID_TAIKHOANNGANHANG,ID_XE,ID_PHONGBAN,THU,LOC_ID,ID_NHANVIEN,ID_NHOMQUYEN,ID_NHOMHANGHOA,ID_HANGHOA,ID_KHUVUC,ID_KHO,BOLTONKHO,ID_HANGHOAKHO,TUNGAY,DENNGAY,ID_PHIEUNHAP,ID_PHIEUXUAT,ID_PHIEUDATHANG,ID_PHIEUGIAOHANG,KEY,ID_COMBO,ID_KHACHHANG,ID_NHACUNGCAP,ID_NHOMNCC,ID_NHOMKHACHHANG,ISTHEOTHOIGIAN,ISPHATSINHCONGNO,ISPHATSINHCONGNOTRONGKY,ISCONCONGNO")]
    public class SP_Parameter
    {
        [StringLength(50)]
        public string LOC_ID { get; set; }

        [StringLength(50)]
        public string ID_NHANVIEN { get; set; }

        [StringLength(50)]
        public string ID_NHOMQUYEN { get; set; }

        [StringLength(50)]
        public string ID_NHOMHANGHOA { get; set; }

        [StringLength(50)]
        public string ID_HANGHOA { get; set; }

        [StringLength(50)]
        public string ID_KHUVUC { get; set; }

        public string ID_KHO { get; set; }

        public bool? BOLTONKHO { get; set; }

        public string ID_HANGHOAKHO { get; set; }

        public DateTime? TUNGAY { get; set; }

        public DateTime? DENNGAY { get; set; }

        public DateTime? NGAYCONG { get; set; }

        public string ID_PHIEUNHAP { get; set; }
        public string ID_PHIEUXUAT { get; set; }

        public string ID_PHIEUCHI { get; set; }

        public string ID_PHIEUTHU { get; set; }

        public string ID_PHIEUDATHANG { get; set; }

        public string ID_PHIEUGIAOHANG { get; set; }

        [StringLength(250)]
        public string KEY { get; set; }

        public string ID_COMBO { get; set; }

        public string ID_KHACHHANG { get; set; }

        public string ID_NHACUNGCAP { get; set; }

        public string ID_NHOMNCC { get; set; }

        public string ID_NHOMKHACHHANG { get; set; }

        public bool? ISTHEOTHOIGIAN { get; set; }

        public bool? ISPHATSINHCONGNO { get; set; }
        public bool? ISPHATSINHCONGNOTRONGKY { get; set; }
        public bool? ISCONCONGNO { get; set; }
        public string LOAITIMKIEM { get; set; }

        public string THU { get; set; }
        public string ID_PHONGBAN { get; set; }
        public int? SOLAN { get; set; }
        public string ID_XE { get; set; }

        public string ID_TAIKHOANNGANHANG { get; set; }
        public string ID_BANGLUONG { get; set; }
        public string ID_THANGLUONG { get; set; }
    }
}
