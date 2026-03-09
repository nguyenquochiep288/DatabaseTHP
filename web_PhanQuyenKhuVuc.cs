// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.web_PhanQuyenKhuVuc
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTHP
{

    public class web_PhanQuyenKhuVuc
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string LOC_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_NHOMQUYEN { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_KHUVUC { get; set; }

        public bool ISACTIVE { get; set; }

        public bool ISPHANQUYENKHUVUC { get; set; }

        public string ID_LICHLAMVIEC { get; set; }
    }
}
