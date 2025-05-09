using DatabaseTHP;
using DatabaseTHP.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static DatabaseTHP.Class.API;

namespace DatabaseTHP
{
    public class v_dm_LoaiPhieuXuat : dm_LoaiPhieuXuat
    {

        public List<LoaiHangHoa> lstTYPEInputOutput
        {
            get { return API.lstTYPEInputOutput(); }
        }
    }
}