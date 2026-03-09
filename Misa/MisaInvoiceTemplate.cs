// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.Class.Misa.MisaInvoiceTemplate
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll


namespace DatabaseTHP.Class.Misa;

public class MisaInvoiceTemplate
{
  public string IPTemplateID { get; set; }

  public int CompanyID { get; set; }

  public string TemplateName { get; set; }

  public string InvTemplateNo { get; set; }

  public string InvSeries { get; set; }

  public string OrgInvSeries { get; set; }

  public int TemplateType { get; set; }

  public int InvoiceType { get; set; }

  public int BusinessAreas { get; set; }

  public int SortOrder { get; set; }

  public bool Inactive { get; set; }

  public string TemplateContent { get; set; }

  public string DefaultTemplateID { get; set; }

  public bool IsCustomTemplate { get; set; }

  public bool IsInheritFromOldTemplate { get; set; }

  public bool IsPublished { get; set; }

  public bool IsPublishedPetrol { get; set; }

  public bool IsSendSummary { get; set; }

  public bool? IsPetrol { get; set; }

  public bool IsTemplatePetrol { get; set; }

  public string ExpireDateType { get; set; }

  public bool IsMoreVATRate { get; set; }

  public string BinCode { get; set; }

  public string AccountNo { get; set; }

  public int SpecificInvoiceType { get; set; }
}
