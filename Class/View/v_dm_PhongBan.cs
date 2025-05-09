using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_QuanLyTHP.Models
{
    public class v_dm_PhongBan : dm_PhongBan
    {
		//public PagedList.IPagedList<dm_PhongBan> IPagedList;
		public List<dm_PhongBan> lstdm_PhongBan { get; set; }

    }
}