// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.INV_DEPOSIT_TEMP
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTHP
{

    public class INV_DEPOSIT_TEMP
    {
        [NotMapped]
        public bool CHON { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        [Required]
        public string LOC_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        [Required]
        public string ID_DEPOSIT_TEMP { get; set; }

        public string ADDRESS { get; set; }

        public string TEL { get; set; }

        [Required]
        public DateTime TRX_DATE { get; set; }

        public double VALUE_DEPOSIT { get; set; }

        public double VALUE_TOTAL { get; set; }

        [StringLength(20)]
        [Required]
        public string ID_CUS { get; set; }

        [StringLength(100)]
        public string REF { get; set; }

        [StringLength(20)]
        public string ID_USER { get; set; }

        public DateTime? LAST_UPDATE { get; set; }

        [StringLength(1000)]
        public string Diengiai_khixoa { get; set; }

        [StringLength(1)]
        public string status_km { get; set; }

        public double ck_tonghd { get; set; }

        public double ck_tong { get; set; }

        [StringLength(50)]
        public string ID_DEPOSIT { get; set; }

        [StringLength(50)]
        [Required]
        public string ID_AREA { get; set; }
    }
}
