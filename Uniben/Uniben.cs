// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.Class.Uniben.Uniben
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace DatabaseTHP.Class.Uniben;

public class Uniben
{
  public class UnibenTokenRequest
  {
    public string username { get; set; }

    public string password { get; set; }
  }

  public class UnibenApiResponse
  {
    public object payload { get; set; }

    public int status { get; set; }

    public string message { get; set; }

    public DatabaseTHP.Class.Uniben.Uniben.UnibenMetaData metaData { get; set; }
  }

  public class UnibenMetaData
  {
    public int page { get; set; }

    public int pageSize { get; set; }

    public int lastPage { get; set; }

    public int totalItems { get; set; }

    public string sort { get; set; }

    public string direction { get; set; }
  }

  public class UnibenToken
  {
    public string fullName { get; set; }

    public bool needChangePwd { get; set; }

    public string distributorCode { get; set; }

    public string distributorName { get; set; }

    public string groupCode { get; set; }

    public string salesTeamCode { get; set; }

    public string distributionChannel { get; set; }

    public int distance { get; set; }

    public string id_token { get; set; }
  }

  public class UnibenOrderData
  {
    public string MAPHIEUDATHANG { get; set; }

    public bool DATONTAI { get; set; }

    public bool CHON { get; set; }

    public int orderId { get; set; }

    public string orderCode { get; set; }

    public string status { get; set; }

    public string customerCode { get; set; }

    public string customerName { get; set; }

    public string deliveryAddress { get; set; }

    public DateTime orderDate { get; set; }

    public Decimal totalAmount { get; set; }

    public string routeCode { get; set; }

    public string salesUserName { get; set; }

    public string deliveryCode { get; set; }

    public DateTime? recordDate { get; set; }

    public DateTime? deliveryDate { get; set; }

    public bool mobileFlag { get; set; }

    public string orderNote { get; set; }

    public double totalWeight { get; set; }

    public int totalQty { get; set; }

    public double totalVolumn { get; set; }

    public bool lastDayFlag { get; set; }

    public string distributorCode { get; set; }

    public string distributorName { get; set; }

    public bool returnFlag { get; set; }

    public string routeFullName { get; set; }

    public string distributorFullName { get; set; }

    public string einvoiceNoInfo { get; set; }

    public DateTime? einvoiceReleasedDatetime { get; set; }
  }

  public class UnibenOrder
  {
    public int id { get; set; }

    public string orderCode { get; set; }

    public DateTime orderDate { get; set; }

    public DateTime? invoiceDate { get; set; }

    public string deliveryCode { get; set; }

    public DateTime? recordDate { get; set; }

    public DateTime? deliveryDate { get; set; }

    public string retDeliveryCode { get; set; }

    public DateTime? retRecordDate { get; set; }

    public DateTime? retDeliveryDate { get; set; }

    public int customerId { get; set; }

    public string customerCode { get; set; }

    public string customerName { get; set; }

    public string taxNo { get; set; }

    public string identifyCardNo { get; set; }

    public string deliveryAddress { get; set; }

    public string routeCode { get; set; }

    public string userName { get; set; }

    public string status { get; set; }

    public Decimal netAmount { get; set; }

    public Decimal discountAmount { get; set; }

    public Decimal discountTotalAmount { get; set; }

    public Decimal personalIncomeTax { get; set; }

    public Decimal personalIncomeAmount { get; set; }

    public Decimal vatRate { get; set; }

    public Decimal vatAmount { get; set; }

    public Decimal totalAmount { get; set; }

    public bool mobileFlag { get; set; }

    public bool returnFlag { get; set; }

    public string orderNode { get; set; }

    public int diffQty { get; set; }

    public List<DatabaseTHP.Class.Uniben.Uniben.UnibenOrderDetail> details { get; set; }
  }

  public class UnibenOrderDetail
  {
    public string lineNo { get; set; }

    public string productCode { get; set; }

    public string materialGroup { get; set; }

    public string productAbbr { get; set; }

    public int remainQty { get; set; }

    public int secondRemainQty { get; set; }

    public int qty { get; set; }

    public int secondQty { get; set; }

    public int quantityConversion { get; set; }

    public Decimal salesOutPrice { get; set; }

    public Decimal secondSalesOutPrice { get; set; }

    public Decimal netAmount { get; set; }

    public Decimal discountRate { get; set; }

    public Decimal discountAmount { get; set; }

    public Decimal totalAmount { get; set; }

    public Decimal totalWeight { get; set; }

    public int focQty { get; set; }

    public int secondFocQty { get; set; }

    public int focPromotionQty { get; set; }

    public int secondFocPromotionQty { get; set; }

    public int focLoyaltyQty { get; set; }

    public int secondFocLoyaltyQty { get; set; }

    public string promotionCode { get; set; }

    public string promotionName { get; set; }

    public string loyaltyCode { get; set; }

    public string loyaltyName { get; set; }

    public string detailType { get; set; }

    public string salesUomCode { get; set; }

    public string salesUomName { get; set; }

    public string secondSalesUomCode { get; set; }

    public string secondSalesUomName { get; set; }

    public bool? promotionFreeTaxFlag { get; set; }

    public int diffQty { get; set; }

    public bool? personalIncomeFlag { get; set; }

    public bool? inventoryFlag { get; set; }

    public string doiNapPromotionCodes { get; set; }

    public string doiNapProductCodes { get; set; }

    public double totalWeightInTon { get; set; }

    public int totalSecondFocPromotionQty { get; set; }

    public int totalSecondFocLoyaltyQty { get; set; }
  }

  public class UnibenOrderListResponse
  {
    public List<v_uniben_dm_LienKet_HangHoa> HangHoa { get; set; }

    public List<v_uniben_dm_LienKet_KhachHang> KhachHang { get; set; }

    public List<v_uniben_dm_LienKet_NhanVien> NhanVien { get; set; }

    public List<DatabaseTHP.Class.Uniben.Uniben.DonHang> lstDonHang { get; set; }
  }

  public class DonHang
  {
    public string MAPHIEUDATHANG { get; set; }

    public bool DATONTAI { get; set; }

    public bool CHON { get; set; }

    public DatabaseTHP.Class.Uniben.Uniben.UnibenOrder unibenOrder { get; set; }

    public v_ct_PhieuDatHang DonDatHang { get; set; }
  }

  public enum TrangThai
  {
    [Description("Xác nhận")] CONFIRMED,
    [Description("Đóng")] CLOSED,
    [Description("Hủy")] CANCEL,
  }

  public class UnibenCustomer
  {
    public int customerId { get; set; }

    public string customerCode { get; set; }

    public string customerName { get; set; }

    public string phoneNo { get; set; }

    public string address { get; set; }

    public string address1 { get; set; }

    public string address2 { get; set; }

    public string status { get; set; }

    public bool activeFlag { get; set; }

    public string distributorCode { get; set; }

    public string distributorName { get; set; }

    public string businessType { get; set; }

    public string businessTypeName { get; set; }

    public double incomeTax { get; set; }

    public string routeCode { get; set; }

    public string userName { get; set; }

    public string taxNo { get; set; }

    public string identifyCardNo { get; set; }

    public string contactPerson { get; set; }

    public string customerFullName { get; set; }

    public string customerRoute { get; set; }
  }

  public class UnibenProduct
  {
    public int id { get; set; }

    public string productCode { get; set; }

    public string materialGroupName { get; set; }

    public string productName { get; set; }

    public string productAbbr { get; set; }

    public string salesUomCode { get; set; }

    public string salesUomName { get; set; }

    public string secondSalesUomCode { get; set; }

    public string secondSalesUomName { get; set; }

    public int salesInPrice { get; set; }

    public int secondSalesInPrice { get; set; }

    public int salesOutPrice { get; set; }

    public int secondSalesOutPrice { get; set; }

    public int quantityConversion { get; set; }

    public int stockQty { get; set; }

    public int secondStockQty { get; set; }

    public int salesOutQty { get; set; }

    public int secondSalesOutQty { get; set; }

    public int remainQty { get; set; }

    public int secondRemainQty { get; set; }

    public double uomWeight { get; set; }

    public double uomVolume { get; set; }

    public bool promotionFlag { get; set; }

    public bool posmFlag { get; set; }

    public bool activeFlag { get; set; }

    public bool personalIncomeFlag { get; set; }

    public int conversionRate { get; set; }

    public string productGroup { get; set; }

    public string productCategory { get; set; }

    public string productBrand { get; set; }

    public string productFlavor { get; set; }
  }

  public class UnibenRoute
  {
    public int routeId { get; set; }

    public string routeCode { get; set; }

    public string routeName { get; set; }

    public string regionName { get; set; }

    public string distributorCode { get; set; }

    public string distributorName { get; set; }

    public string salesUserCode { get; set; }

    public string salesUserName { get; set; }

    public string referUserCode { get; set; }

    public string hierarchyCode { get; set; }

    public string hierarchyName { get; set; }

    public string usmName { get; set; }

    public string usmReferUserCode { get; set; }

    public string rsmName { get; set; }

    public string rsmReferUserCode { get; set; }

    public string salesTeamName { get; set; }

    public string salesTeamCode { get; set; }

    public bool activeFlag { get; set; }

    public string routeFullName { get; set; }
  }
}
