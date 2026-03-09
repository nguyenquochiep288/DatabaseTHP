// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.Class.ApiResponse
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll


namespace DatabaseTHP
{

    public class ApiResponse
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public object Data { get; set; }

        public object Expires { get; set; }

        public object Detail { get; set; }

        public bool CheckValue { get; set; }

        public string NewID { get; set; }

        public string ID { get; set; }

        public string URL { get; set; }

        public string ProductCombo { get; set; }

        public string PathProduct { get; set; }

        public string MAPHIEU { get; set; }

        public int SOPHIEU { get; set; }

        public string TYPE { get; set; }

        public string GETPROMOTION { get; set; }

        public string TAB { get; set; }

        public string CONTENT { get; set; }

        public string NAME { get; set; }

        public string ID_PHIEUXUAT { get; set; }
    }
}
