using DatabaseTHP;
using DatabaseTHP.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static DatabaseTHP.Class.API;

namespace DatabaseTHP
{
    public class v_dm_BangLuong_ChiTiet : dm_BangLuong_ChiTiet
    {
        public string NAME_LOAILUONG { get; set; }
        public string MA_LOAILUONG { get; set; }

        public string NAME_LUONG
        {
            get { return (API.lstTYPELuong().Where(e => e.ID == TYPE_LUONG).FirstOrDefault() != null ? API.lstTYPELuong().Where(e => e.ID == TYPE_LUONG).FirstOrDefault().NAME : ""); }
            set { }
        }

        public string NAME_QUYTACTINHLUONG
        {
            get { return (API.lstTYPEQuyTacTinhLuong().Where(e => e.ID == TYPE_QUYTACTINHLUONG).FirstOrDefault() != null ? API.lstTYPEQuyTacTinhLuong().Where(e => e.ID == TYPE_QUYTACTINHLUONG).FirstOrDefault().NAME : ""); }
            set { }
        }
    }
}