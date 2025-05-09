using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class Product_Detail : view_dm_HangHoa
    {
        public bool ISEDIT { get; set; }

        public string ID_LOC { get; set; }

        public string ID_HANGHOAKHO { get; set; }

        public double SOLUONG { get; set; }

        public double TONGSOLUONG { get; set; }

        public double DONGIA { get; set; }

        public double GIAVON { get; set; }

        public double THANHTIEN { get; set; }

        public string GHICHU { get; set; }

        public double CHIETKHAU { get; set; }

        public double TONGTIENGIAMGIA { get; set; }

        public double THUESUAT { get; set; }

        public double TONGTIENVAT { get; set; }

        public double TONGCONG { get; set; }

        public string TYPE { get; set; }

        public string ID_KHO { get; set; }

        public string ID_HANGHOA { get; set; }

        public string ID_DVT_COMBO { get; set; }
        public double QTY_COMBO { get; set; }
        public double TYLE_QD_COMBO { get; set; }
        public double QTY_TOTAL_COMBO { get; set; }
        public double QTY { get; set; }
        public string ID_COMBO { get; set; }
        public bool ISKHUYENMAI { get; set; }
        public string ID_KHUYENMAI { get; set; }
        public bool ISDALAYKHUYENMAI { get; set; }
        public double SOLUONGDALAYKHUYENMAI { get; set; }
        public int STT { get; set; }
        public string ID_PHIEUDIEUHANG_CHITIET { get; set; }
        public string ID_PHIEUXUAT_CHITIET { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public double SOLUONGDALAY_KM { get; set; }
        public double SOLUONGDALAY_KM_TAM { get; set; }
    }
}