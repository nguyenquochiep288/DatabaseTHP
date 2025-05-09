namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class web_ThongBao
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
