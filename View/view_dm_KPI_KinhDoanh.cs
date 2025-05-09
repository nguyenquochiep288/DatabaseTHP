using DatabaseTHP;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatabaseTHP
{
    public class view_dm_KPI_KinhDoanh
    {
        [StringLength(50)]
        public string LOC_ID { get; set; }

        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string MA { get; set; }

        [StringLength(150)]
        public string NAME { get; set; }

        public DateTime TUNGAY { get; set; }

        public DateTime DENNGAY { get; set; }

        public double CHIETKHAU { get; set; }

        public double TIENGIAM { get; set; }

        public bool IS_YEUCAUCHITIET { get; set; }

        public double TONGTIEN_DATKM { get; set; }

        public double SOLUONG_DATKM { get; set; }

        [StringLength(50)]
        public string ID_DVT_DATKM { get; set; }

        public bool ISACTIVE { get; set; }

        public DateTime? THOIGIANSUA { get; set; }

        [StringLength(50)]
        public string ID_NGUOISUA { get; set; }

        public DateTime? THOIGIANTHEM { get; set; }

        [StringLength(50)]
        public string ID_NGUOITAO { get; set; }

        public string NAME_DVT { get; set; }

        public int CAPDO { get; set; }
    }
}