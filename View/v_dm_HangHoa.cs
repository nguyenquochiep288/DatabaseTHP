// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.v_dm_HangHoa
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.Collections.Generic;


namespace DatabaseTHP
{

    public class v_dm_HangHoa : dm_HangHoa
    {
        public List<v_dm_HangHoa_Combo> lstdm_HangHoa_Combo { get; set; }

        public string NAME_NHOMHANGHOA { get; set; }

        public string NAME_DVT { get; set; }

        public string NAME_NCC { get; set; }

        public string NAME_DVT_QD { get; set; }

        public string FILEBASE64 { get; set; }

        public bool FILENEW { get; set; }

        public string NAME_LOAIHANGHOA { get; set; }

        public double GIA { get; set; }

        public double GIA_QD { get; set; }

        public double CHIETKHAU { get; set; }

        public double TONGTIENGIAMGIA { get; set; }

        public double THANHTIEN { get; set; }

        public double THUESUAT { get; set; }

        public double TONGTIENVAT { get; set; }

        public double TONGCONG { get; set; }

        public string ID_HANGHOAKHO { get; set; }

        public string ID_KHO { get; set; }

        public string ID_HANGHOA { get; set; }

        public string NAME_THUESUAT { get; set; }
    }
}
