// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.v_dm_BangLuong_ChiTiet
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using DatabaseTHP.Class;
using System;
using System.Linq;

namespace DatabaseTHP
{
    public class v_dm_BangLuong_ChiTiet : dm_BangLuong_ChiTiet
    {
        public string NAME_LOAILUONG { get; set; }

        public string MA_LOAILUONG { get; set; }

        public string NAME_LUONG
        {
            get
            {
                return API.lstTYPELuong().Where<API.LoaiHangHoa>((Func<API.LoaiHangHoa, bool>)(e => e.ID == this.TYPE_LUONG)).FirstOrDefault<API.LoaiHangHoa>() == null ? "" : API.lstTYPELuong().Where<API.LoaiHangHoa>((Func<API.LoaiHangHoa, bool>)(e => e.ID == this.TYPE_LUONG)).FirstOrDefault<API.LoaiHangHoa>().NAME;
            }
            set
            {
            }
        }

        public string NAME_QUYTACTINHLUONG
        {
            get
            {
                return API.lstTYPEQuyTacTinhLuong().Where<API.LoaiHangHoa>((Func<API.LoaiHangHoa, bool>)(e => e.ID == this.TYPE_QUYTACTINHLUONG)).FirstOrDefault<API.LoaiHangHoa>() == null ? "" : API.lstTYPEQuyTacTinhLuong().Where<API.LoaiHangHoa>((Func<API.LoaiHangHoa, bool>)(e => e.ID == this.TYPE_QUYTACTINHLUONG)).FirstOrDefault<API.LoaiHangHoa>().NAME;
            }
            set
            {
            }
        }
    }
}
