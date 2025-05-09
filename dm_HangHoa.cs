namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class dm_HangHoa
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string LOC_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ID { get; set; }

        [Required]
        [StringLength(50)]
        public string MA { get; set; }

        [Required]
        [StringLength(200)]
        public string NAME { get; set; }

        [StringLength(250)]
        public string PICTURE { get; set; }

        public double GIA01 { get; set; }

        public double GIA02 { get; set; }

        public double GIA03 { get; set; }

        public double GIA01_QD { get; set; }

        public double GIA02_QD { get; set; }

        public double GIA03_QD { get; set; }

        public double GIAMUA { get; set; }
        public double GIAMUA_QD { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_NHOMHANGHOA { get; set; }

        [Required]
        [StringLength(2)]
        public string LOAIHANGHOA { get; set; }

        public bool BAOGOMTHUESUAT { get; set; }

        [StringLength(50)]
        public string ID_THUESUAT { get; set; }

        public bool ISCOMBO { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_DVT { get; set; }

        public double TYLE_QD { get; set; }

        public double TRONGLUONG { get; set; }

        [StringLength(20)]
        public string BARCODE { get; set; }

        public bool STATUS_HIENTHI { get; set; }

        [StringLength(50)]
        public string ID_NCC { get; set; }

        [StringLength(50)]
        public string ID_DVT_QD { get; set; }

        public bool STATUS_QD { get; set; }

        public bool ISACTIVE { get; set; }

        public DateTime? THOIGIANSUA { get; set; }

        [StringLength(50)]
        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }

        [StringLength(50)]
        public string ID_NGUOITAO { get; set; }

        public bool ISKHONGHIENTHITONKHO { get; set; }

        public bool ISKHONGDUOCPHEPSUA { get; set; }
    }
}
