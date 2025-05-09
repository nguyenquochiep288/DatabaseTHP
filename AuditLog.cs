namespace DatabaseTHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AuditLog
    {
        public int ID { get; set; }
        public string ID_PHIEU { get; set; }
        public string ENTITYNAME { get; set; }
        public string OPERATION { get; set; }
        public string DATA { get; set; }
        public DateTime TIMESTAMP { get; set; }
        public string ID_DINHKEM { get; set; }
    }
}
