// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.Class.Misa.MisaApiResponseInvoiced_Error
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll


namespace DatabaseTHP.Class.Misa
{

    public class MisaApiResponseInvoiced_Error
    {
        public string RefID { get; set; }

        public string InvSeries { get; set; }

        public string InvDate { get; set; }

        public string ErrorMessage { get; set; }

        public int EInvoiceStatus { get; set; }
    }
}