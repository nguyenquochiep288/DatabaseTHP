// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.nv_ChamCong
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTHP
{

    public class nv_ChamCong
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
        public string ID_NHANVIEN { get; set; }

        [StringLength(50)]
        public string ID_THANGLUONG { get; set; }

        public DateTime NGAYCONG { get; set; }

        public DateTime? THOIGIANVAO { get; set; }

        public DateTime? THOIGIANRA { get; set; }

        public double SOTIENGLAMVIEC { get; set; }

        public string GHICHU { get; set; }

        public DateTime? THOIGIANSUA { get; set; }

        [StringLength(50)]
        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }

        [StringLength(50)]
        public string ID_NGUOITAO { get; set; }

        public bool ISNGHIPHEP { get; set; }

        public string IP_CHAMCONGVAO { get; set; }

        public string IP_CHAMCONGRA { get; set; }
    }
}
