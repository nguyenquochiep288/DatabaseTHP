using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class v_dm_HangHoa_KhungGia_Master : dm_HangHoa_KhungGia_Master
    {
        public List<dm_HangHoa_KhungGia> lstdm_HangHoa_KhungGia { get; set; }
        public List<v_dm_HangHoa_KhungGia_HangHoa> lstdm_HangHoa_KhungGia_HangHoa { get; set; }
    }
}