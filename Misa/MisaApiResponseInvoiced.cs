// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.Class.Misa.MisaApiResponseInvoiced
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.Collections.Generic;


namespace DatabaseTHP.Class.Misa
{

    public class MisaApiResponseInvoiced
    {
        public bool success { get; set; }

        public string data { get; set; }

        public string error { get; set; }

        public string error_description { get; set; }

        public List<string> errorCode { get; set; }
    }
}