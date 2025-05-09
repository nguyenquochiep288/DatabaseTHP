namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ct_PhieuChuyen
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string LOC_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ID { get; set; }

        public string MAPHIEU { get; set; }
        public int SOPHIEU { get; set; }

        public DateTime NGAYLAP { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_NHANVIEN { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_TUKHO { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_DENKHO { get; set; }

        [StringLength(200)]
        public string GHICHU { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_PHIEUXUATKHAC { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_PHIEUNHAPKHAC { get; set; }
    }
}
