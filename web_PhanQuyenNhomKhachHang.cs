namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class web_PhanQuyenNhomKhachHang
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
        public string ID_NHOMKHACHHANG { get; set; }

        public bool ISACTIVE { get; set; }

        public bool ISPHANQUYENKHACHHANG { get; set; }
    }
}
