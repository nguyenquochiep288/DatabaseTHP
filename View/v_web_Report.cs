// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.v_web_Report
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.Collections.Generic;


namespace DatabaseTHP
{

    public class v_web_Report : web_Report
    {
        public string NAME_MENU { get; set; }

        public List<v_web_Report_Parameter> lstweb_Report_Parameter { get; set; }
    }
}
