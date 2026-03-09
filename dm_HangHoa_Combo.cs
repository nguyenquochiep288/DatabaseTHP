// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.dm_HangHoa_Combo
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;
using System.ComponentModel.DataAnnotations;


namespace DatabaseTHP
{

    public class dm_HangHoa_Combo
    {
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string LOC_ID { get; set; }

        [StringLength(50)]
        public string ID_HANGHOACOMBO { get; set; }

        [StringLength(50)]
        public string ID_HANGHOA { get; set; }

        public string ID_DVT { get; set; }

        public double QTY { get; set; }

        public double TYLE_QD { get; set; }

        public double QTY_TOTAL { get; set; }

        public bool ISACTIVE { get; set; }

        public DateTime? THOIGIANSUA { get; set; }

        [StringLength(50)]
        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }

        [StringLength(50)]
        public string ID_NGUOITAO { get; set; }
    }
}
