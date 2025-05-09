using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_QuanLyTHP.Models
{
    public class v_dm_NhanVien : dm_NhanVien
    {
		//public PagedList.IPagedList<dm_NhanVien> IPagedList;
		public List<dm_ChucVu> lstdm_ChucVu { get; set; }
public List<dm_PhongBan> lstdm_PhongBan { get; set; }

    }
}