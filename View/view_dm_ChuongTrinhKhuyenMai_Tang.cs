// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.view_dm_ChuongTrinhKhuyenMai_Tang
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.ComponentModel.DataAnnotations;


namespace DatabaseTHP
{

    public class view_dm_ChuongTrinhKhuyenMai_Tang
    {
        public string MA { get; set; }

        public string NAME { get; set; }

        public string NAME_DVT { get; set; }

        [StringLength(50)]
        public string LOC_ID { get; set; }

        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string ID_CHUONGTRINHKHUYENMAI { get; set; }

        [StringLength(50)]
        public string ID_HANGHOA { get; set; }

        public double SOLUONG { get; set; }

        [StringLength(50)]
        public string ID_DVT { get; set; }

        public double TYLE_QD { get; set; }

        public double QTY_TOTAL { get; set; }

        public double SOTIEN { get; set; }
    }
}
