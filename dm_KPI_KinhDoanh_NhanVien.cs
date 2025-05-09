namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class dm_KPI_KinhDoanh_NhanVien
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string LOC_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ID { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_NHANVIEN { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_KPI_KINHDOANH { get; set; }

        [StringLength(250)]
        public string GHICHU { get; set; }

        public int HINHTHUC { get; set; }
    }
}
