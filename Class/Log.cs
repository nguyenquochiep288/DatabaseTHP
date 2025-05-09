using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DatabaseTHP.Class
{
    internal class Log
    {
        public static void WriteLog(string ActionName , string ControllerName, Exception e)
        {
            try
            {
                System.Diagnostics.StackTrace trace = new System.Diagnostics.StackTrace(e, true);
                StackFrame stf = trace.GetFrame(0);
                string sCName = ((System.Reflection.MemberInfo)(stf.GetMethod())).DeclaringType.FullName;
                string MethodName = stf.GetMethod().Name;
                int ix = stf.GetFileLineNumber();
                
                //StreamWriter log;

                //// Write to the file:
                //string strError = e.Message;
                //log.WriteLine("**************************Class==>" + sCName + "*************************");
                //log.WriteLine("Time==>" + DateTime.Now);
                //log.WriteLine("Method==>" + MethodName);
                //log.WriteLine("Error msg==> Line number: " + ix.ToString() + ", Error excuting: " + strError);
                //log.WriteLine();
                //// Close the stream:
                //log.Close();
            }
            catch 
            { 
            }
        }
    }
}
