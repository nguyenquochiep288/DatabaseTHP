// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.Class.clsMaHoa
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll


namespace DatabaseTHP
{

    public class clsMaHoa
    {
        public const string PassMaHoa = "tmt6364";
        private static TMTSecuritys.clsMaHoa tmtSecuritys = new TMTSecuritys.clsMaHoa();

        public static string Encrypt(string plainText, string code)
        {
            try
            {
                return clsMaHoa.tmtSecuritys.Encrypt(plainText, code);
            }
            catch
            {
                return plainText;
            }
        }

        public static string Decrypt(string cipherText, string code)
        {
            try
            {
                return clsMaHoa.tmtSecuritys.Decrypt(cipherText, code);
            }
            catch
            {
                return cipherText;
            }
        }
    }
}
