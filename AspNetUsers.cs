// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.AspNetUsers
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable
namespace DatabaseTHP;

public class AspNetUsers
{
  public AspNetUsers()
  {
    this.AspNetUserClaims = (ICollection<AspNetUserClaim>) new HashSet<AspNetUserClaim>();
    this.AspNetUserLogins = (ICollection<AspNetUserLogin>) new HashSet<AspNetUserLogin>();
    this.AspNetUserTokens = (ICollection<AspNetUserToken>) new HashSet<AspNetUserToken>();
    this.AspNetRoles = (ICollection<AspNetRole>) new HashSet<AspNetRole>();
  }

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

  public string URL_IMAGE { get; set; }

  public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }

  public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }

  public virtual ICollection<AspNetUserToken> AspNetUserTokens { get; set; }

  public virtual ICollection<AspNetRole> AspNetRoles { get; set; }
}
