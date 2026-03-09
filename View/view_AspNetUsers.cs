// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.view_AspNetUsers
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;
using System.ComponentModel.DataAnnotations;


namespace DatabaseTHP
{

    public class view_AspNetUsers
    {
        [StringLength(50)]
        public string ID { get; set; }

        [Required]
        [StringLength(256 /*0x0100*/)]
        public string FullName { get; set; }

        [StringLength(256 /*0x0100*/)]
        public string UserName { get; set; }

        [StringLength(256 /*0x0100*/)]
        public string NormalizedUserName { get; set; }

        [StringLength(256 /*0x0100*/)]
        public string Email { get; set; }

        [StringLength(256 /*0x0100*/)]
        public string NormalizedEmail { get; set; }

        public bool EmailConfirmed { get; set; }

        public string PasswordDecrypt { get; set; }

        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }

        public string ConcurrencyStamp { get; set; }

        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }

        public DateTimeOffset? LockoutEnd { get; set; }

        public bool LockoutEnabled { get; set; }

        public int AccessFailedCount { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_NHOMQUYEN { get; set; }

        public string MA { get; set; }

        public string NAME { get; set; }

        public string URL_IMAGE { get; set; }

        public string MA_NHOMQUYEN { get; set; }

        public string NAME_NHOMQUYEN { get; set; }

        public string IPLOCATION { get; set; }
    }
}
