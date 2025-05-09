namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class view_web_PhanQuyen
    {
        public string LOC_ID { get; set; }

        public string ID { get; set; }

        public string ID_NHOMQUYEN { get; set; }

        public string ID_QUYEN { get; set; }

        public bool TRANGTHAI { get; set; }

        public string MAQUYEN { get; set; }

        public string TENQUYEN { get; set; }

        public string ID_MENU { get; set; }

        public string MA_NHOMQUYEN { get; set; }

        public string NAME_NHOMQUYEN { get; set; }

        public bool ISPHANQUYEN { get; set; }

        public string ACTIONNAME { get; set; }

        public string CONTROLLERNAME { get; set; }

        
    }
}
