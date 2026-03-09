// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.Class.Misa.MisaInvoiceDetails
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;

namespace DatabaseTHP.Class.Misa
{

    public class MisaInvoiceDetails
    {
        public int InventoryItemType { get; set; }

        public string InventoryItemCode { get; set; }

        public string Description { get; set; }

        public int? SortOrderView { get; set; }

        public int SortOrder { get; set; }

        public bool IsPromotion { get; set; }

        public string UnitName { get; set; }

        public Decimal Quantity { get; set; }

        public Decimal UnitPrice { get; set; }

        public Decimal AmountOC { get; set; }

        public Decimal Amount { get; set; }

        public Decimal? DiscountRate { get; set; }

        public Decimal? DiscountAmountOC { get; set; }

        public Decimal? DiscountAmount { get; set; }

        public int? VATRate { get; set; }

        public Decimal VATAmountOC { get; set; }

        public Decimal VATAmount { get; set; }

        public Decimal InWards { get; set; }

        public Decimal? WageAmountOC { get; set; }

        public Decimal? WageAmount { get; set; }

        public Decimal? TaxReduction43AmountOC { get; set; }

        public Decimal? TaxReduction43Amount { get; set; }

        public Decimal? ExciseTaxRate { get; set; }

        public Decimal? ExciseTaxAmountOC { get; set; }

        public Decimal? ExciseTaxAmount { get; set; }

        public Decimal? ServiceFeeRate { get; set; }

        public Decimal? ServiceAmountOC { get; set; }

        public Decimal? ServiceAmount { get; set; }

        public string LotNo { get; set; }

        public DateTime? ExpireDate { get; set; }

        public string LicensePlate { get; set; }

        public string EngineNumber { get; set; }

        public string ChassisNumber { get; set; }

        public Decimal? AmountWithoutVATOC { get; set; }

        public Decimal? AmountWithoutVAT { get; set; }
    }
}