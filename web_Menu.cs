// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.web_Menu
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;
using System.ComponentModel.DataAnnotations;


namespace DatabaseTHP
{

    public class web_Menu
    {
        [StringLength(50)]
        public string ID { get; set; }

        [Required]
        [StringLength(200)]
        public string NAME { get; set; }

        [StringLength(100)]
        public string ACTIONNAME { get; set; }

        [StringLength(100)]
        public string CONTROLLERNAME { get; set; }

        [StringLength(50)]
        public string ID_QUYENCHA { get; set; }

        [StringLength(150)]
        public string ICON { get; set; }

        public int STT { get; set; }

        public bool ISACTIVE { get; set; }

        public DateTime? THOIGIANSUA { get; set; }

        [StringLength(50)]
        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }

        [StringLength(50)]
        public string ID_NGUOITAO { get; set; }
    }
}
