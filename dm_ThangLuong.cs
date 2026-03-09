// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.dm_ThangLuong
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTHP
{

    public class dm_ThangLuong
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string LOC_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ID { get; set; }

        public string MA { get; set; }

        public string NAME { get; set; }

        public double THANG { get; set; }

        public double NAM { get; set; }

        public double SONGAY { get; set; }

        public double SONGAYCONG { get; set; }

        public string GHICHU { get; set; }

        public DateTime NGAYBATDAU { get; set; }

        public DateTime NGAYKETTHUC { get; set; }

        public string ID_PHONGBAN { get; set; }

        public bool ISCHAMCONG { get; set; }

        public bool ISACTIVE { get; set; }

        public TimeSpan GIOBATDAU { get; set; }

        public TimeSpan GIOBATDAU_NGHITRUA { get; set; }

        public TimeSpan GIOKETTHUC_NGHITRUA { get; set; }

        public TimeSpan GIOKETTHUC { get; set; }

        public double SOGIONGHITRUA { get; set; }

        public string DANHSACHNGAYNGHI { get; set; }
    }
}
