using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTHP.Class
{
    public class TokenRequest
    {
        public string TaxCode { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
    public class ApiResponseInvoiced
    {
        public bool Success { get; set; }
        public string Data { get; set; }  // Dữ liệu JSON dạng chuỗi
        public string Error { get; set; }
        public string ErrorDescription { get; set; }
        public List<string> ErrorCode { get; set; }
    }

    /// <summary>
    /// Đại diện cho thông tin xác thực nhận được từ API.
    /// </summary>
    public class TokenData
    {
        /// <summary>Chuỗi mã truy cập dùng để xác thực các yêu cầu API.</summary>
        public string AccessToken { get; set; }

        /// <summary>Loại token xác thực, thường là "bearer".</summary>
        public string TokenType { get; set; }

        /// <summary>Thời gian token hết hạn tính bằng giây (ví dụ: 1209599 giây ≈ 14 ngày).</summary>
        public int ExpiresIn { get; set; }

        /// <summary>Mã định danh duy nhất của người dùng.</summary>
        public string UserID { get; set; }

        /// <summary>Mã định danh đơn vị tổ chức người dùng thuộc về.</summary>
        public string OrganizationUnitID { get; set; }

        /// <summary>Tên tài khoản người dùng (thường là email).</summary>
        public string UserName { get; set; }

        /// <summary>ID của công ty người dùng liên kết.</summary>
        public int CompanyID { get; set; }

        /// <summary>Mô tả lỗi nếu có, hoặc null nếu không có lỗi.</summary>
        public string ErrorDescription { get; set; }

        /// <summary>Thông tin lỗi nếu có, hoặc null nếu yêu cầu thành công.</summary>
        public string Error { get; set; }
    }
    /// <summary>
    /// Đại diện cho thông tin mẫu hóa đơn trong hệ thống.
    /// </summary>
    public class InvoiceTemplate
    {
        /// <summary>ID của mẫu hóa đơn.</summary>
        public string IPTemplateID { get; set; }

        /// <summary>ID của công ty liên quan đến mẫu hóa đơn.</summary>
        public int CompanyID { get; set; }

        /// <summary>Tên của mẫu hóa đơn.</summary>
        public string TemplateName { get; set; }

        /// <summary>Mẫu số của hóa đơn.</summary>
        public string InvTemplateNo { get; set; }

        /// <summary>Ký hiệu của hóa đơn.</summary>
        public string InvSeries { get; set; }

        /// <summary>Chuỗi hóa đơn gốc (original invoice series).</summary>
        public string OrgInvSeries { get; set; }

        /// <summary>Loại mẫu (ví dụ: 1 cho loại cụ thể).</summary>
        public int TemplateType { get; set; }

        /// <summary>Loại hóa đơn (ví dụ: 1 cho hóa đơn bán hàng).</summary>
        public int InvoiceType { get; set; }

        /// <summary>Khu vực kinh doanh liên quan đến mẫu.</summary>
        public int BusinessAreas { get; set; }

        /// <summary>Thứ tự sắp xếp khi hiển thị mẫu.</summary>
        public int SortOrder { get; set; }

        /// <summary>Trạng thái hoạt động của mẫu (true: không hoạt động, false: đang hoạt động).</summary>
        public bool Inactive { get; set; }

        /// <summary>Nội dung chi tiết của mẫu hóa đơn.</summary>
        public string TemplateContent { get; set; }

        /// <summary>ID của mẫu mặc định được liên kết.</summary>
        public string DefaultTemplateID { get; set; }

        /// <summary>Cho biết đây có phải là mẫu tùy chỉnh không.</summary>
        public bool IsCustomTemplate { get; set; }

        /// <summary>Cho biết mẫu có kế thừa từ mẫu cũ không.</summary>
        public bool IsInheritFromOldTemplate { get; set; }

        /// <summary>Trạng thái xuất bản của mẫu hóa đơn.</summary>
        public bool IsPublished { get; set; }

        /// <summary>Trạng thái xuất bản dành riêng cho hóa đơn xăng dầu.</summary>
        public bool IsPublishedPetrol { get; set; }

        /// <summary>Mẫu có gửi tóm tắt báo cáo hay không.</summary>
        public bool IsSendSummary { get; set; }

        /// <summary>Cho biết mẫu có phải hóa đơn dành cho ngành xăng dầu không.</summary>
        public bool? IsPetrol { get; set; }

        /// <summary>Mẫu có phải là hóa đơn xăng dầu theo định dạng riêng không.</summary>
        public bool IsTemplatePetrol { get; set; }

        /// <summary>Loại ngày hết hạn áp dụng cho mẫu (có thể dùng để xử lý logic thời gian).</summary>
        public string ExpireDateType { get; set; }

        /// <summary>Cho biết mẫu có nhiều mức thuế VAT hay không.</summary>
        public bool IsMoreVATRate { get; set; }

        /// <summary>Mã kho hàng liên quan đến mẫu (nếu có).</summary>
        public string BinCode { get; set; }

        /// <summary>Số tài khoản liên quan đến mẫu (nếu có).</summary>
        public string AccountNo { get; set; }

        /// <summary>Loại hóa đơn cụ thể theo từng quy trình kinh doanh.</summary>
        public int SpecificInvoiceType { get; set; }
    }

    /// <summary>
    /// Đại diện cho một dòng hàng hóa/dịch vụ trong chứng từ.
    /// </summary>
    public class InvoiceDetails
    {
        /// <summary>
        /// Tính chất hàng hóa/dịch vụ:
        /// 0 - Hàng hóa/dịch vụ;
        /// 2 - Khuyến mại;
        /// 3 - Ghi chú/diễn giải;
        /// 4 - Chiết khấu thương mại (theo dòng);
        /// 6 - Hàng hóa đặc thù.
        /// </summary>
        public int InventoryItemType { get; set; }

        /// <summary>Mã hàng hóa.</summary>
        public string InventoryItemCode { get; set; }

        /// <summary>Mô tả hoặc tên hàng hóa/dịch vụ.</summary>
        public string Description { get; set; }

        /// <summary>Thứ tự sắp xếp hiển thị của dòng hàng (null nếu là loại 3 hoặc 4).</summary>
        public int? SortOrderView { get; set; }

        /// <summary>Thứ tự hiển thị của dòng hàng bắt đầu từ 1.</summary>
        public int SortOrder { get; set; }

        /// <summary>Chỉ định dòng khuyến mại, bắt buộc nếu InventoryItemType = 2.</summary>
        public bool IsPromotion { get; set; }

        /// <summary>Đơn vị tính.</summary>
        public string UnitName { get; set; }

        /// <summary>Số lượng hàng hóa.</summary>
        public decimal Quantity { get; set; }

        /// <summary>Đơn giá của hàng hóa.</summary>
        public decimal UnitPrice { get; set; }

        /// <summary>Thành tiền nguyên tệ.</summary>
        public decimal AmountOC { get; set; }

        /// <summary>Thành tiền sau quy đổi.</summary>
        public decimal Amount { get; set; }

        /// <summary>Tỷ lệ chiết khấu (%).</summary>
        public decimal? DiscountRate { get; set; }

        /// <summary>Tiền chiết khấu nguyên tệ.</summary>
        public decimal? DiscountAmountOC { get; set; }

        /// <summary>Tiền chiết khấu quy đổi.</summary>
        public decimal? DiscountAmount { get; set; }

        /// <summary>
        /// Tỷ lệ thuế suất VAT:
        /// -1: Không chịu thuế;
        /// -3: Không kê khai nộp thuế;
        /// 0, 5, 8, 10: Thuế suất tương ứng;
        /// null: ứng dụng tự tính theo VATAmountOC.
        /// </summary>
        public int? VATRate { get; set; }

        /// <summary>Tiền thuế VAT nguyên tệ.</summary>
        public decimal VATAmountOC { get; set; }

        /// <summary>Tiền thuế VAT quy đổi.</summary>
        public decimal VATAmount { get; set; }

        /// <summary>Số lượng thực xuất (áp dụng cho phiếu xuất kho).</summary>
        public decimal InWards { get; set; }

        /// <summary>Tiền công nguyên tệ.</summary>
        public decimal? WageAmountOC { get; set; }

        /// <summary>Tiền công quy đổi.</summary>
        public decimal? WageAmount { get; set; }

        /// <summary>Số tiền giảm thuế nguyên tệ theo nghị quyết 43.</summary>
        public decimal? TaxReduction43AmountOC { get; set; }

        /// <summary>Số tiền giảm thuế quy đổi theo nghị quyết 43.</summary>
        public decimal? TaxReduction43Amount { get; set; }

        /// <summary>Thuế suất tiêu thụ đặc biệt (TTDB).</summary>
        public decimal? ExciseTaxRate { get; set; }

        /// <summary>Tiền thuế TTDB nguyên tệ.</summary>
        public decimal? ExciseTaxAmountOC { get; set; }

        /// <summary>Tiền thuế TTDB quy đổi.</summary>
        public decimal? ExciseTaxAmount { get; set; }

        /// <summary>Tỷ lệ phí dịch vụ (%).</summary>
        public decimal? ServiceFeeRate { get; set; }

        /// <summary>Tiền phí dịch vụ nguyên tệ.</summary>
        public decimal? ServiceAmountOC { get; set; }

        /// <summary>Tiền phí dịch vụ quy đổi.</summary>
        public decimal? ServiceAmount { get; set; }

        /// <summary>Số lô sản phẩm.</summary>
        public string LotNo { get; set; }

        /// <summary>Hạn dùng của sản phẩm.</summary>
        public DateTime? ExpireDate { get; set; }

        /// <summary>Biển kiểm soát (nếu là xe cộ).</summary>
        public string LicensePlate { get; set; }

        /// <summary>Số máy thiết bị.</summary>
        public string EngineNumber { get; set; }

        /// <summary>Số khung thiết bị.</summary>
        public string ChassisNumber { get; set; }
    }


    /// <summary>
    /// Đại diện cho thông tin tổng thể của một hóa đơn.
    /// </summary>
    public class InvoiceMaster
    {
        /// <summary>Mã tham chiếu hóa đơn (GUID duy nhất để kiểm tra trùng).</summary>
        public string RefID { get; set; }

        /// <summary>ID mẫu hóa đơn từ API mẫu.</summary>
        public string InvoiceTemplateID { get; set; }

        /// <summary>Ký hiệu hóa đơn.</summary>
        public string InvSeries { get; set; }

        /// <summary>Ngày phát hành hóa đơn.</summary>
        public string InvDate { get; set; }

        /// <summary>Mã số thuế của khách hàng.</summary>
        public string AccountObjectTaxCode { get; set; }

        /// <summary>Tên đơn vị mua hàng.</summary>
        public string AccountObjectName { get; set; }

        /// <summary>Mã định danh của đơn vị.</summary>
        public string AccountObjectCode { get; set; }

        /// <summary>Địa chỉ đơn vị mua hàng.</summary>
        public string AccountObjectAddress { get; set; }

        /// <summary>Số tài khoản ngân hàng của đơn vị.</summary>
        public string AccountObjectBankAccount { get; set; }

        /// <summary>Tên ngân hàng của đơn vị.</summary>
        public string AccountObjectBankName { get; set; }

        /// <summary>Số định danh cá nhân (12 số, dùng cho ND70).</summary>
        public string CitizenIDNumber { get; set; }

        /// <summary>Số hộ chiếu (tối đa 20 ký tự, dùng cho ND70).</summary>
        public string PassportNumber { get; set; }

        /// <summary>Mã số đơn vị có quan hệ ngân sách (7 ký tự, dùng cho ND70).</summary>
        public string RelatedUnitCode { get; set; }

        /// <summary>Mã cửa hàng bán hàng.</summary>
        public string SellerShopCode { get; set; }

        /// <summary>Tên cửa hàng bán hàng.</summary>
        public string SellerShopName { get; set; }

        /// <summary>Họ tên người mua hàng.</summary>
        public string ContactName { get; set; }

        /// <summary>Địa chỉ email của người mua hàng để gửi hóa đơn.</summary>
        public string ReceiverEmail { get; set; }

        /// <summary>Tên người nhận email.</summary>
        public string ReceiverName { get; set; }

        /// <summary>Số điện thoại dùng để gửi SMS thông báo.</summary>
        public string ReceiverMobile { get; set; }

        /// <summary>Phương thức thanh toán (TM, CK…).</summary>
        public string PaymentMethod { get; set; }

        /// <summary>Mã loại tiền (VND, USD…).</summary>
        public string CurrencyCode { get; set; }

        /// <summary>Tỷ lệ chiết khấu áp dụng cho hóa đơn.</summary>
        public decimal DiscountRate { get; set; }

        /// <summary>Tỷ giá quy đổi tiền tệ.</summary>
        public decimal ExchangeRate { get; set; }

        /// <summary>Tổng tiền hàng nguyên tệ (trước thuế, chiết khấu).</summary>
        public decimal TotalSaleAmountOC { get; set; }

        /// <summary>Tổng tiền hàng sau quy đổi.</summary>
        public decimal TotalSaleAmount { get; set; }

        /// <summary>Tổng tiền chiết khấu nguyên tệ.</summary>
        public decimal TotalDiscountAmountOC { get; set; }

        /// <summary>Tổng tiền chiết khấu quy đổi.</summary>
        public decimal TotalDiscountAmount { get; set; }

        /// <summary>Tổng VAT nguyên tệ.</summary>
        public decimal TotalVATAmountOC { get; set; }

        /// <summary>Tổng VAT quy đổi.</summary>
        public decimal TotalVATAmount { get; set; }

        /// <summary>Tổng tiền thanh toán bao gồm thuế (nguyên tệ).</summary>
        public decimal TotalAmountOC { get; set; }

        /// <summary>Tổng tiền thanh toán quy đổi.</summary>
        public decimal TotalAmount { get; set; }

        /// <summary>Ngày tạo hóa đơn.</summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>Người tạo hóa đơn.</summary>
        public string CreatedBy { get; set; }

        /// <summary>Ngày chỉnh sửa hóa đơn.</summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>Người chỉnh sửa hóa đơn.</summary>
        public string ModifiedBy { get; set; }

        /// <summary>Danh sách chi tiết hóa đơn.</summary>
        public List<InvoiceDetails> InvoiceDetails { get; set; }
    }

    /// <summary>
    /// Lớp thông tin đăng nhập sử dụng mã số thuế.
    /// </summary>
    public class TaxLoginRequest
    {
        /// <summary>
        /// Mã số thuế của người nộp thuế hoặc doanh nghiệp.
        /// </summary>
        public string TaxCode { get; set; }

        /// <summary>
        /// Tên tài khoản đăng nhập (ví dụ: tài khoản test).
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Mật khẩu đăng nhập (được mã hóa nếu cần).
        /// </summary>
        public string Password { get; set; }
    }

    public enum TinhChatHangHoa
    {
        HangHoaDichVu = 0,
        KhuyenMai = 2,
        GhiChuDienGiai = 3,
        ChietKhauThuongMai = 4,
        HangHoaDacThu = 6
    }
    public class TaxHelper
    {
        public int? GetVAT(int vatRate, List<dm_ThueSuat> lstDanhMuc)
        {
            int? result = null;
            switch (vatRate)
            {
                case -1:
                    // Không chịu thuế
                    result = -1;
                    break;
                case -3:
                    result = -3;
                    break;
                case 0:
                    result = 0;
                    break;
                case 5:
                    result = 5;
                    break;
                case 8:
                    result = 8;
                    break;
                case 10:
                    result = 10;
                    break;
                default:
                    result = null;
                    break;
            }
            return result;
        }
    }
}
