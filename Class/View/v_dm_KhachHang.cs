using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_QuanLyTHP.Models
{
    public class v_dm_KhachHang : dm_KhachHang
    {
		//public PagedList.IPagedList<dm_KhachHang> IPagedList;
		public List<dm_KhuVuc> lstdm_KhuVuc { get; set; }
        public List<dm_NhomKhachHang_NCC> lstdm_NhomKhachHang_NCC { get; set; }

    }
}