namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class dm_KPI_KinhDoanh_YeuCau
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
        public string ID_KPI_KINHDOANH { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_HANGHOA { get; set; }

        public double SOLUONG { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_DVT { get; set; }

        public double SOTIEN { get; set; }
        public double TYLE_QD { get; set; }

        public double QTY_TOTAL { get; set; }
        public int HINHTHUC_TINHKPI { get; set; }
        public int HINHTHUC { get; set; }
        public double CHIETKHAU { get; set; }
        public double TIENGIAM { get; set; }
    }
}
