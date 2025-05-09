using DatabaseTHP;
using DatabaseTHP.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class v_dm_NhanVien : dm_NhanVien
    {
        public string NAME_CHUCVU { get; set; }
        public string NAME_PHONGBAN { get; set; }

        public string UserName { get; set; }

        public string NAME_GIOITINH { get { return (API.lstGioiTinh().Where(e => e.ID.ToString() == GIOITINH).FirstOrDefault() != null ? API.lstGioiTinh().Where(e => e.ID.ToString() == GIOITINH).FirstOrDefault().NAME : ""); } set { } }
    }
}