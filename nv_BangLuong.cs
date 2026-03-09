// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.nv_BangLuong
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTHP
{

    public class nv_BangLuong
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string LOC_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ID { get; set; }

        public string MAPHIEU { get; set; }

        public int SOPHIEU { get; set; }

        [Required]
        public string ID_THANGLUONG { get; set; }

        [Required]
        public string ID_NHANVIEN { get; set; }

        public double SONGAYCONG { get; set; }

        public double MUCLUONG { get; set; }

        public double SONGAYLAMVIEC { get; set; }

        public double SONGAYNGHIPHEP { get; set; }

        public double TIENLUONG { get; set; }

        public double TIENLUONGKHAC { get; set; }

        public double TIENGIAM { get; set; }

        public double TIENTHUCNHAN { get; set; }

        public string GHICHU { get; set; }

        public DateTime NGAYLAP { get; set; }

        public bool ISTINHLUONG { get; set; }

        public DateTime? THOIGIANSUA { get; set; }

        [StringLength(50)]
        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }

        [StringLength(50)]
        public string ID_NGUOITAO { get; set; }

        public double SONGAYNGHIKHONGPHEP { get; set; }

        public double TIENDAUKY { get; set; }
    }
}
