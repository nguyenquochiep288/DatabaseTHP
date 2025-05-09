namespace DatabaseTHP.StoredProcedure
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class web_Sp_Get_DanhSachChietKhauHoaDon_Result
    {
        [StringLength(50)]
        public string LOC_ID { get; set; }

        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        public double? DS_BEGIN { get; set; }

        public double? DS_END { get; set; }

        public DateTime? FROMDATE { get; set; }

        public DateTime? TODATE { get; set; }

        [StringLength(1)]
        public string STATUS_ACTIVE { get; set; }

        [StringLength(500)]
        public string DIENGIAI { get; set; }

        public double? CK_PER { get; set; }

        public double? CK_VALUE { get; set; }
    }
}
