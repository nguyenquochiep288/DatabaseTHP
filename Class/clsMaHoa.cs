using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Diagnostics;
using Microsoft.VisualBasic;
namespace DatabaseTHP.Class
{
    public class clsMaHoa
    {
        public const string PassMaHoa = "tmt6364";
        static TMTSecuritys.clsMaHoa tmtSecuritys = new TMTSecuritys.clsMaHoa();
        public static string Encrypt(string plainText, string code)
        {
            try
            {
                return tmtSecuritys.Encrypt(plainText, code);
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
                return tmtSecuritys.Decrypt(cipherText, code);
            }
            catch
            {
                return cipherText;
            }
        }
    }
}