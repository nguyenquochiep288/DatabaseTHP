// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.Class.Misa.MisaInvoiceInfo
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;


namespace DatabaseTHP.Class.Misa;

public class MisaInvoiceInfo
{
  public string TransactionID { get; set; }

  public string InvNo { get; set; }

  public string InvoiceCode { get; set; }

  public string RefID { get; set; }

  public string InvSeries { get; set; }

  public DateTime InvDate { get; set; }

  public DateTime? PublishingTime { get; set; }
}
