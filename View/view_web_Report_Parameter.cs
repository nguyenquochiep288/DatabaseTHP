// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.view_web_Report_Parameter
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.ComponentModel.DataAnnotations;


namespace DatabaseTHP
{

    public class view_web_Report_Parameter
    {
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string ID_REPORT { get; set; }

        [StringLength(50)]
        public string ID_PARAMETER { get; set; }

        public bool ISACTIVE { get; set; }

        public int STT { get; set; }

        public string NAME_REPORT { get; set; }

        public string NAME_PARAMETER { get; set; }

        public string NAME { get; set; }

        public string VALUE { get; set; }

        public string TYPE { get; set; }

        public string MA_PARAMETER { get; set; }

        public string VALUE_REPORT { get; set; }
    }
}