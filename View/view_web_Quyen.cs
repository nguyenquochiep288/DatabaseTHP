using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class view_web_Quyen
    {
        public string LOC_ID { get; set; }

        public string ID { get; set; }

        public string MAQUYEN { get; set; }

        public string TENQUYEN { get; set; }

        public string ID_MENU { get; set; }
        public string MOTA { get; set; }
        public string NAME_MENU { get; set; }
    }
}