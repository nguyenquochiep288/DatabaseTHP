// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.INV_DEPOSIT_DTL_TEMP
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTHP
{

    public class INV_DEPOSIT_DTL_TEMP
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string ID { get; set; }

        [StringLength(2)]
        public string LOC_ID { get; set; }

        [StringLength(20)]
        public string ID_DEPOSIT_TEMP { get; set; }

        [StringLength(20)]
        public string ID_ITEM { get; set; }

        public double QTY { get; set; }

        public double PRICE { get; set; }

        public double DISCOUNT { get; set; }

        public double VAT { get; set; }

        [StringLength(200)]
        public string Diengiai { get; set; }

        public DateTime? date_add { get; set; }

        [StringLength(1)]
        public string khuyenmai { get; set; }

        [StringLength(100)]
        public string waiter { get; set; }

        public double? purse { get; set; }

        public double dis_values { get; set; }

        [StringLength(1)]
        public string item_style { get; set; }

        [StringLength(100)]
        public string promat_id { get; set; }

        [StringLength(10)]
        public string status_add_km { get; set; }
    }
}
