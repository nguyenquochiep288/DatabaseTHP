// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.web_ThongBao
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.ComponentModel.DataAnnotations;


namespace DatabaseTHP
{

    public class web_ThongBao
    {
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(500)]
        public string DISPLAYNAME { get; set; }

        [StringLength(500)]
        public string VN { get; set; }

        [StringLength(500)]
        public string EN { get; set; }
    }
}
