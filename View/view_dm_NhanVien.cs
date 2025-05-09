namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_dm_NhanVien
    {
        public string LOC_ID { get; set; }

        public string ID { get; set; }

        public string MA { get; set; }

        public string NAME { get; set; }

        public string ID_CHUCVU { get; set; }

        public string NAME_CHUCVU { get; set; }

        public string GIOITINH { get; set; }

        public string ADDRESS { get; set; }

        public string TEL { get; set; }

        public string ID_NUMBER { get; set; }

        public DateTime? DATEOFBIRTH { get; set; }

        public DateTime? DATEJOIN { get; set; }

        public string ID_PHONGBAN { get; set; }

        public string NAME_PHONGBAN { get; set; }

        public string LOAINHANVIEN { get; set; }

        public string EMAIL { get; set; }

        public string GHICHU { get; set; }

        public DateTime? THOIGIANSUA { get; set; }

        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }

        public string ID_NGUOITAO { get; set; }

        public bool ISACTIVE { get; set; }
        public string ID_TAIKHOAN { get; set; }

        public string UserName { get; set; }

        public string ID_NHOMQUYEN { get; set; }

        public double CONGNODAUKY { get; set; }

        public double LUONGCOBAN { get; set; }
        public double SONGAYPHEP { get; set; }
    }
}
