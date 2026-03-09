// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.Sp_Get_DanhSachPhieuGiaoHang_In
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;

#nullable disable
namespace DatabaseTHP;

public class Sp_Get_DanhSachPhieuGiaoHang_In : v_ct_PhieuXuat_ChiTiet
{
  public string ID_KHACHHANG_NCC { get; set; }

  public string ID_PHIEUGIAOHANG { get; set; }

  public string NAME_NCC { get; set; }

  public string NAME_DVT_QD { get; set; }

  public string NAME_NHOMHANGHOA { get; set; }

  public bool STATUS_QD { get; set; }

  public double TYLE_QD_HH { get; set; }

  public Decimal TONGSOLUONGHH { get; set; }

  public string NAME_SOLUONG
  {
    get
    {
      try
      {
        int num = Convert.ToInt32(this.TONGSOLUONGHH) / Convert.ToInt32(this.TYLE_QD_HH);
        return (num > 0 ? $"{num.ToString("N0")} {this.NAME_DVT}" : "") + (this.TONGSOLUONGHH - Convert.ToDecimal((double) num * this.TYLE_QD_HH) > 0M ? $" {(this.TONGSOLUONGHH - Convert.ToDecimal((double) num * this.TYLE_QD_HH)).ToString("N0")} {this.NAME_DVT_QD}" : "");
      }
      catch
      {
        return "";
      }
    }
    set
    {
    }
  }

  public string NAME_KHACHHANG_NCC { get; set; }

  public string DIACHI_KHACHHANG_NCC { get; set; }

  public string TEL_KHACHHANG_NCC { get; set; }

  public string MAPHIEU { get; set; }

  public double TONGTIENTINHTHUE { get; set; }

  public string NAME_KHUVUC { get; set; }

  public string BIENSOXE { get; set; }
}
