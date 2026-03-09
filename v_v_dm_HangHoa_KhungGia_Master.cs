using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_QuanLyTHP.Models
{
    public class v_v_dm_HangHoa_KhungGia_Master : v_dm_HangHoa_KhungGia_Master
    {
	  public PagedList.IPagedList<v_dm_HangHoa_KhungGia_Master> IPagedList;

        public List<v_dm_HangHoa> lstdm_HangHoa { get; set; }

        public string ID_HANGHOA { get; set; }
    }
}