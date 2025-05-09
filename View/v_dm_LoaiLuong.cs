using DatabaseTHP;
using DatabaseTHP.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static DatabaseTHP.Class.API;

namespace DatabaseTHP
{
    public class v_dm_LoaiLuong : dm_LoaiLuong
    {

        public List<LoaiHangHoa> lstTYPELoaiLuong
        {
            get { return API.lstTYPELoaiLuong(); }
        }
    }
}