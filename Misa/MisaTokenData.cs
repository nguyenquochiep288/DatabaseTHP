// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.Class.Misa.MisaTokenData
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll


namespace DatabaseTHP.Class.Misa;

public class MisaTokenData
{
  public string access_token { get; set; }

  public string token_type { get; set; }

  public int expires_in { get; set; }

  public string UserID { get; set; }

  public string OrganizationUnitID { get; set; }

  public string UserName { get; set; }

  public int CompanyID { get; set; }

  public string error_description { get; set; }

  public string error { get; set; }
}
