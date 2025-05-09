namespace DatabaseTHP
{
    using DatabaseTHP.Class;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Diagnostics.SymbolStore;
    using System.Linq;

    public partial class view_dm_HangHoa
    {
        public string LOC_ID { get; set; }

        public string ID { get; set; }

        public string MA { get; set; }

        public string NAME { get; set; }

        public string PICTURE { get; set; }

        public double GIA01 { get; set; }

        public double GIA02 { get; set; }

        public double GIA03 { get; set; }

        public double GIA01_QD { get; set; }

        public double GIA02_QD { get; set; }

        public double GIA03_QD { get; set; }

        public double GIAMUA { get; set; }

        public double GIAMUA_QD { get; set; }

        public string ID_NHOMHANGHOA { get; set; }

        public string NAME_NHOMHANGHOA { get; set; }

        public string LOAIHANGHOA { get; set; }

        public bool BAOGOMTHUESUAT { get; set; }

        public string ID_THUESUAT { get; set; }
        public bool ISCOMBO { get; set; }

        public string ID_DVT { get; set; }

        public string NAME_DVT { get; set; }

        public double TYLE_QD { get; set; }

        public double TRONGLUONG { get; set; }

        public string BARCODE { get; set; }

        public bool STATUS_HIENTHI { get; set; }

        public string ID_NCC { get; set; }

        public string NAME_NCC { get; set; }

        public string ID_DVT_QD { get; set; }

        public string NAME_DVT_QD { get; set; }

        public bool STATUS_QD { get; set; }

        public bool ISACTIVE { get; set; }

        public DateTime? THOIGIANSUA { get; set; }

        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }

        public string ID_NGUOITAO { get; set; }

        public string NAME_LOAIHANGHOA { get; set; }

        public string NAME_THUESUAT { get; set; }

        public double MUCTHUE { get; set; }

        public bool ISKHONGHIENTHITONKHO { get; set; }

        public bool ISKHONGDUOCPHEPSUA { get; set; }
    }
}
