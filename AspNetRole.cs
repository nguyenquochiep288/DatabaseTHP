// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.AspNetRole
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace DatabaseTHP
{

    public class AspNetRole
    {
        public AspNetRole()
        {
            this.AspNetRoleClaims = (ICollection<AspNetRoleClaim>)new HashSet<AspNetRoleClaim>();
            this.AspNetUser = (ICollection<AspNetUsers>)new HashSet<AspNetUsers>();
        }

        [StringLength(450)]
        public string Id { get; set; }

        [StringLength(256 /*0x0100*/)]
        public string Name { get; set; }

        [StringLength(256 /*0x0100*/)]
        public string NormalizedName { get; set; }

        public string ConcurrencyStamp { get; set; }

        public virtual ICollection<AspNetRoleClaim> AspNetRoleClaims { get; set; }

        public virtual ICollection<AspNetUsers> AspNetUser { get; set; }
    }
}
