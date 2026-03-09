// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.dm_TaiKhoan_Uniben
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTHP
{

    public class dm_TaiKhoan_Uniben
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string LOC_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string MASOTHUE { get; set; }

        [Required]
        [StringLength(150)]
        public string USERNAME { get; set; }

        [Required]
        [StringLength(250)]
        public string PASSWORD { get; set; }

        [StringLength(4000)]
        public string ACCESSTOKEN { get; set; }

        public int? EXPIRESIN { get; set; }

        [StringLength(150)]
        public string USERID { get; set; }

        [StringLength(150)]
        public string ORGANIZATIONUNITID { get; set; }

        public int? COMPANYID { get; set; }

        [StringLength(250)]
        public string GHICHU { get; set; }

        public bool ISACTIVE { get; set; }

        public DateTime? THOIGIANSUA { get; set; }

        [StringLength(50)]
        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }

        [StringLength(50)]
        public string ID_NGUOITAO { get; set; }

        public DateTime? THOIGIANLAYTOKEN { get; set; }

        public string LINK { get; set; }

        public string LINK_TRACUU { get; set; }
    }
}
