// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.Class.Misa.TaxHelper
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.Collections.Generic;


namespace DatabaseTHP.Class.Misa
{

    public class TaxHelper
    {
        public int? GetVAT(int vatRate, List<dm_ThueSuat> lstDanhMuc)
        {
            int? vat = new int?();
            switch (vatRate)
            {
                case -3:
                    vat = new int?(-3);
                    break;
                case -1:
                    vat = new int?(-1);
                    break;
                case 0:
                    vat = new int?(0);
                    break;
                case 5:
                    vat = new int?(5);
                    break;
                case 8:
                    vat = new int?(8);
                    break;
                case 10:
                    vat = new int?(10);
                    break;
                default:
                    vat = new int?();
                    break;
            }
            return vat;
        }
    }
}
