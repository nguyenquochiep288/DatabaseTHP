// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.Class.Misa.MisaInvoiceMaster
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;
using System.Collections.Generic;


namespace DatabaseTHP.Class.Misa
{

    public class MisaInvoiceMaster
    {
        public string RefID { get; set; }

        public string InvoiceTemplateID { get; set; }

        public string InvSeries { get; set; }

        public string InvDate { get; set; }

        public string AccountObjectTaxCode { get; set; }

        public string AccountObjectName { get; set; }

        public string AccountObjectCode { get; set; }

        public string AccountObjectAddress { get; set; }

        public string AccountObjectBankAccount { get; set; }

        public string AccountObjectBankName { get; set; }

        public string CitizenIDNumber { get; set; }

        public string PassportNumber { get; set; }

        public string RelatedUnitCode { get; set; }

        public string SellerShopCode { get; set; }

        public string SellerShopName { get; set; }

        public string ContactName { get; set; }

        public string ReceiverEmail { get; set; }

        public string ReceiverName { get; set; }

        public string ReceiverMobile { get; set; }

        public string PaymentMethod { get; set; }

        public string CurrencyCode { get; set; }

        public Decimal DiscountRate { get; set; }

        public Decimal ExchangeRate { get; set; }

        public Decimal TotalSaleAmountOC { get; set; }

        public Decimal TotalSaleAmount { get; set; }

        public Decimal TotalDiscountAmountOC { get; set; }

        public Decimal TotalDiscountAmount { get; set; }

        public Decimal TotalVATAmountOC { get; set; }

        public Decimal TotalVATAmount { get; set; }

        public Decimal TotalAmountOC { get; set; }

        public Decimal TotalAmount { get; set; }

        public string CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedDate { get; set; }

        public string ModifiedBy { get; set; }

        public List<MisaInvoiceDetails> InvoiceDetails { get; set; }
    }
}
