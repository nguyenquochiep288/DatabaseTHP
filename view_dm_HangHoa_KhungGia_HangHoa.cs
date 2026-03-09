using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class view_dm_HangHoa_KhungGia_HangHoa
    {
        public string LOC_ID { get; set; }
        public string ID { get; set; }  
        public string ID_HANGHOA { get; set; }
        public string ID_HANGHOA_KHUNGGIA_MASTER { get; set; }
        public string MA { get; set; }
        public string NAME { get; set; }

        public bool ISACTIVE { get; set; }
    }
}