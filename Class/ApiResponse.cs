using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseTHP.Class
{
    public class ApiResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        public object Expires { get; set; }
        public object Detail { get; set; }
        public bool CheckValue { get; set; }
        public string NewID { get; set; }
        public string ID { get; set; }
        public string URL { get; set; }

        public string ProductCombo { get; set; }

        public string PathProduct { get; set; }

        public string MAPHIEU { get; set; }
        public int SOPHIEU { get; set; }

        public string TYPE { get; set; }

        public string GETPROMOTION { get; set; }

        public string TAB { get; set; }

        public string CONTENT { get; set; }

        public string NAME { get; set; }

        public string ID_PHIEUXUAT { get; set; }
    }

    public class modelState
    {
        public string Key { get; set; }
        public string Error { get; set; }
    }

    public class ValueEdit
    {
        public string Key { get; set; }
        public object Value { get; set; }
        public object Name { get; set; }
        public string Controller { get; set; }
    }

    public class ListValue
    {
        public string ID { get; set; }
        public object NAME { get; set; }
        public Boolean? ISACTIVE { get; set; }
    }
}

