// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.dm_NhaCungCap
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTHP
{

    public class dm_NhaCungCap
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string LOC_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string MA { get; set; }

        [Required]
        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(100)]
        public string ADDRESS { get; set; }

        [StringLength(20)]
        public string TEL { get; set; }

        [StringLength(20)]
        public string FAX { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_NHOMNCC { get; set; }

        public bool ISACTIVE { get; set; }

        public bool ISDEFAULT { get; set; }

        public double CONGNODAUKY { get; set; }

        public DateTime? THOIGIANSUA { get; set; }

        [StringLength(50)]
        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }

        [StringLength(50)]
        public string ID_NGUOITAO { get; set; }

        public string MASOTHUE { get; set; }

        public string TENNGANHANG { get; set; }

        public string CHUTAIKHOAN { get; set; }

        public string SOTAIKHOAN { get; set; }
    }
}
