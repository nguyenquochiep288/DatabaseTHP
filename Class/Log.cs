// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.Class.Log
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;
using System.Diagnostics;


namespace DatabaseTHP
{

    internal class Log
    {
        public static void WriteLog(string ActionName, string ControllerName, Exception e)
        {
            try
            {
                StackFrame frame = new StackTrace(e, true).GetFrame(0);
                string fullName = frame.GetMethod().DeclaringType.FullName;
                string name = frame.GetMethod().Name;
                frame.GetFileLineNumber();
            }
            catch
            {
            }
        }
    }
}
