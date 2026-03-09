// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.C__EFMigrationsHistory
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTHP
{

    [Table("__EFMigrationsHistory")]
    public class C__EFMigrationsHistory
    {
        [Key]
        [StringLength(150)]
        public string MigrationId { get; set; }

        [Required]
        [StringLength(32 /*0x20*/)]
        public string ProductVersion { get; set; }
    }
}
