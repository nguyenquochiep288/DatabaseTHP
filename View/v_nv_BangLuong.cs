// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.v_nv_BangLuong
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.Collections.Generic;

namespace DatabaseTHP
{

    public class v_nv_BangLuong : nv_BangLuong
    {
        public string MA_NHANVIEN { get; set; }

        public string NAME_NHANVIEN { get; set; }

        public string MA_THANGLUONG { get; set; }

        public string NAME_THANGLUONG { get; set; }

        public List<nv_BangLuong_ChiTiet> lstnv_BangLuong_ChiTiet { get; set; }
    }
}
