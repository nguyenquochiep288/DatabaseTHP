// Decompiled with JetBrains decompiler
// Type: DatabaseTHP.Class.API
// Assembly: DatabaseTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B9ADA26D-FEE8-4EBF-A8E2-7EEA7E056CE8
// Assembly location: G:\MyApiNetCore6-03_Authentication_New\Publish_API\DatabaseTHP.dll

using System;
using System.Collections.Generic;
using System.Linq;


namespace DatabaseTHP.Class
{

    public class API
    {
        public static string GTBH = nameof(GTBH);
        public static string TINHTHUE_KM = nameof(TINHTHUE_KM);
        public static string Input = nameof(Input);
        public static string ListValue = "listValue";
        public static string Checkbox = nameof(Checkbox);
        public static string NHNCC = nameof(NHNCC);
        public static string NTHKH = nameof(NTHKH);
        public static string XHKH = nameof(XHKH);
        public static string XTHNCC = nameof(XTHNCC);
        public static string PTNCC = nameof(PTNCC);
        public static string PTNV = nameof(PTNV);
        public static string PTKH = nameof(PTKH);
        public static string PTGCNKHCNV = nameof(PTGCNKHCNV);
        public static string PCGCNKHCNV = nameof(PCGCNKHCNV);
        public static string Chon1 = "0";
        public static string ChonSanPhamCombo = "1";
        public static string ChonSanPhamNhapXuatChuyen = "2";
        public static string ChonNhieu = "3";
        public static string ChonCTKM_YC = "4";
        public static string ChonCTKM_Tang = "5";
        public static string ChonCTKM_YC_NHOMSANPHAM = "6";
        public static string Chon1_GiaoHang = "7";
        public static string Chon1_NhanVien = "8";
        public static string Chon1_NhomQuyen = "9";
        public const string ViewBagTitle = "Trang Hiệp Phát";
        public const string Uniben = "Uniben";
        public const string UnibenSalesOrder = "UnibenSalesOrder";
        public const string Invoiced_Misa = "Invoiced_Misa";
        public const string ct_HoaDon_ChiTiet = "Invoiced_Detail";
        public const string ct_HoaDon = "Invoiced";
        public const string web_NhomQuyen = "GroupPermissions";
        public const string TBL_CASHIER = "ctluser_login";
        public const string INV_SALES = "INV_SALES";
        public const string INV_DEPOSIT_TEMP = "DEPOSIT_TEMP";
        public const string INV_DEPOSIT_DTL_TEMP = "DEPOSIT_DTL_TEMP";
        public const string ct_PhieuNhap = "Input";
        public const string ct_PhieuNhap_ChiTiet = "Input_Detail";
        public const string ct_PhieuNhapKhac = "InputOther";
        public const string ct_PhieuNhapKhac_ChiTiet = "InputOther_Detail";
        public const string ct_PhieuXuat = "Output";
        public const string ct_PhieuXuat_ChiTiet = "Output_Detail";
        public const string ct_PhieuXuatKhac = "OutputOther";
        public const string ct_PhieuXuatKhac_ChiTiet = "OutputOther_Detail";
        public const string ct_PhieuChuyen = "WarehouseTransfer";
        public const string ct_PhieuChuyen_ChiTiet = "WarehouseTransfer_Detail";
        public const string ct_PhieuThu = "Receipt";
        public const string ct_PhieuChi = "Payment";
        public const string ct_PhieuDatHang = "Deposit";
        public const string ct_PhieuDatHang_ChiTiet = "Deposit_Detail";
        public const string ct_PhieuDatHangNCC = "Order_Provider";
        public const string ct_PhieuDatHangNCC_ChiTiet = "Order_Provider_Detail";
        public const string ct_PhieuGiaoHang = "Delivery";
        public const string ct_PhieuGiaoHang_ChiTiet = "Delivery_Detail";
        public const string ct_PhieuGiaoHang_NhanVienGiao = "Delivery_Shipper";
        public const string ct_PhieuGiaoHang_HinhAnh = "Delivery_Image";
        public const string BaoCao = "ViewReport";
        public const string Tinh_KPI_KinhDoanh = "Payroll_KPI_Sale";
        public const string nv_BangLuong = "Payroll";
        public const string nv_ChamCong = "Timekeeping";
        public const string nv_NghiPhep = "HRLeave";
        public const string nv_PhepNam = "AnnualLeave";
        public const string nv_BangLuong_ChiTiet = "Payroll_Detail";
        public const string BaoCaoNhanVien = "ReportEmployee";
        public const string web_PhanQuyenNhomSanPham = "PermissionsGroupProduct";
        public const string web_PhanQuyenKhuVuc = "PermissionsArea";
        public const string web_PhanQuyenNhomKhachHang = "PermissionsGroupCustomer";
        public const string web_PhanQuyenKhachHang = "PermissionsCustomer";
        public const string web_PhanQuyenSanPham = "PermissionsProduct";
        public const string web_Quyen = "Quyen";
        public const string web_PhanQuyen = "Permissions";
        public const string dm_LoaiHoaDon = "TypeInvoiced";
        public const string TBL_ITEM = "Item";
        public const string TBL_DEPT = "Dept";
        public const string web_Menu = "Menu";
        public const string dm_KhuVuc = "Area";
        public const string dm_LichLamViec = "Calendar";
        public const string dm_Xe = "Car";
        public const string dm_DonViTinh = "Unit";
        public const string TBL_COMPANY = "Company";
        public const string dm_KhachHang = "Customer";
        public const string dm_TienTe = "Currency";
        public const string dm_TaiKhoan_Misa = "AccountMisa";
        public const string dm_TaiKhoan_Uniben = "AccountUniben";
        public const string dm_TaiKhoanNganHang = "BankAccount";
        public const string dm_NhomKhachHang = "GroupCustomer";
        public const string dm_NhomNhaCungCap = "GroupProvider";
        public const string tbl_nhom_khuvuc = "GroupArea";
        public const string dm_ChucVu = "Position";
        public const string TBL_Area = "Area";
        public const string dm_NhanVien = "Employee";
        public const string dm_Kho = "Depot";
        public const string dm_PhongBan = "Department";
        public const string dm_CongTy = "Company";
        public const string dm_HangHoa_HinhAnh = "Product_Image";
        public const string dm_HangHoa_Mota = "Product_Describe";
        public const string dm_HangHoa = "Product";
        public const string dm_HangHoa_Combo = "Product_Combo";
        public const string dm_HangHoa_Kho = "Product_Depot";
        public const string dm_HangHoa_KhuyenMai = "Product_Promotion";
        public const string dm_LoaiLuong = "TypePayroll";
        public const string dm_LoaiPhieuThu = "TypeReceipt";
        public const string dm_LoaiPhieuChi = "TypePayment";
        public const string dm_LoaiPhieuXuat = "TypeOutput";
        public const string dm_LoaiPhieuNhap = "TypeInput";
        public const string dm_NhaCungCap = "Provider";
        public const string dm_ThueSuat = "Tax";
        public const string dm_NhomHangHoa = "GroupProduct";
        public const string AspNetUser = "User";
        public const string Account = "Accounts";
        public const string dm_ChuongTrinhKhuyenMai = "Promotion";
        public const string dm_ChuongTrinhKhuyenMai_YeuCau = "Promotion_YC";
        public const string dm_ChuongTrinhKhuyenMai_Tang = "Promotion_Tang";
        public const string ThongBao = "ThongBao";
        public const string LoaHangHoa = "Loại hàng hóa";
        public const string MauHoaDon = "Mẫu hóa đơn";
        public const string dm_HTTT = "HTTT";
        public const string Search = "Search";
        public const string LogError = "LogError";
        public const string web_Parameter = "Parameter";
        public const string web_Report = "Report";
        public const string dm_KPI_KinhDoanh = "KPI_Sale";
        public const string dm_KPI_KinhDoanh_YeuCau = "KPI_Sale_YC";
        public const string dm_KPI_KinhDoanh_NhanVien = "KPI_Sale_NV";
        public const string dm_ThangLuong = "MonthlySalary";
        public const string dm_DiaDiemChamCong = "Location";
        public const string dm_BangLuong = "CategoryPayroll";
        public const string dm_BangLuong_ChiTiet = "CategoryPayroll_Detail";
        public const string dm_HangHoa_KhungGia = "ProductPriceRange";
        public const string ThongKeCongNoKhachHang = "DebtCustomer";
        public const string ThongKeCongNoNhanVien = "DebtEmployee";
        public const string ThongKeCongNoNhaCungCap = "DebtProvider";
        public const string ThongKeTonKhoHangHoa = "Inventory";
        public const string ThongKeThuChi = "IncomeStatement";
        public const string BaoCaoGiaoHang = "ReportDelivery";
        public const string ThongKeQuyTien = "MoneyFund";
        public const string ThongKeChiTietPhieuXuat = "OutputDetail";
        public const string web_Sp_Get_DSNhomSanPham = "web_Sp_Get_DSNhomSanPham";
        public const string web_Sp_Get_DSSanPham = "web_Sp_Get_DSSanPham";
        public const string web_Sp_Get_SanPham_Combo = "web_Sp_Get_SanPham_Combo";
        public const string web_Sp_Get_SanPham_Group = "web_Sp_Get_SanPham_Group";
        public const string web_Sp_Get_SanPham = "web_Sp_Get_SanPham";
        public const string web_Sp_Get_DSKhachHang = "web_Sp_Get_DSKhachHang";
        public const string web_Sp_Get_DanhSachKhuyenMai = "web_Sp_Get_DanhSachKhuyenMai";
        public const string web_Sp_Get_Sp_StockNow = "Sp_StockNow";
        public const string web_Sp_Get_DSKhuVuc = "web_Sp_Get_DSKhuVuc";
        public const string web_Sp_Get_DanhSachChietKhauHoaDon = "web_Sp_Get_DanhSachChietKhauHoaDon";
        public const string Sp_Get_DanhSachSanPhamKho = "Sp_Get_DanhSachSanPhamKho";
        public const string Sp_Get_DanhSachSanPhamKho_Combo = "Sp_Get_DanhSachSanPhamKho_Combo";
        public const string Sp_Get_DanhSachSanPham_Combo = "Sp_Get_DanhSachSanPham_Combo";
        public const string Sp_Get_DanhSachPhieuGiaoHang_PhieuXuat = "Sp_Get_DanhSachPhieuGiaoHang_PhieuXuat";
        public const string Sp_Get_DanhSachPhieuXuat = "Sp_Get_DanhSachPhieuXuat";
        public const string Sp_Get_DanhSachPhieuXuat_PhieuGiaoHang = "Sp_Get_DanhSachPhieuXuat_PhieuGiaoHang";
        public const string Sp_Get_DanhSachPhieuNhap_PhieuGiaoHang = "Sp_Get_DanhSachPhieuNhap_PhieuGiaoHang";
        public const string Sp_Get_DanhSachPhieuXuat_TimKiem = "Sp_Get_DanhSachPhieuXuat_TimKiem";
        public const string Sp_Get_DanhSachPhieuXuat_ChiTiet = "Sp_Get_DanhSachPhieuXuat_ChiTiet";
        public const string Sp_Get_DanhSachPhieuGiaoHang_In = "Sp_Get_DanhSachPhieuGiaoHang_In";
        public const string Sp_Get_DanhSachPhieuGiaoHang_InPhieuGiao = "Sp_Get_DanhSachPhieuGiaoHang_InPhieuGiao";
        public const string Sp_Get_DanhSachPhieuNhap = "Sp_Get_DanhSachPhieuNhap";
        public const string Sp_Get_DanhSachPhieuNhap_Chitiet = "Sp_Get_DanhSachPhieuNhap_Chitiet";
        public const string Sp_Get_ChuongTrinhKhuyenMai = "Sp_Get_ChuongTrinhKhuyenMai";
        public const string Sp_Get_DanhSachPhieuXuatHang_KhuyenMai = "Sp_Get_DanhSachPhieuXuatHang_KhuyenMai";
        public const string Sp_Get_DanhSachPhieuDatHang = "Sp_Get_DanhSachPhieuDatHang";
        public const string Sp_Get_DanhSachPhieuDatHang_ChiTiet = "Sp_Get_DanhSachPhieuDatHang_ChiTiet";
        public const string Sp_Get_DanhSachPhieuDatHang_ChiTiet_BaoCao = "Sp_Get_DanhSachPhieuDatHang_ChiTiet_BaoCao";
        public const string Sp_Get_DanhSachPhieuGiaoHang = "Sp_Get_DanhSachPhieuGiaoHang";
        public const string Sp_Get_DanhSachPhieuGiaoHang_ChiTiet = "Sp_Get_DanhSachPhieuGiaoHang_ChiTiet";
        public const string Sp_Get_DanhSachPhieuGiaoHang_NhanVienGiao = "Sp_Get_DanhSachPhieuGiaoHang_NhanVienGiao";
        public const string Sp_Get_DanhSachPhieuThu = "Sp_Get_DanhSachPhieuThu";
        public const string Sp_Get_DanhSachPhieuThu_PhieuGiaoHang = "Sp_Get_DanhSachPhieuThu_PhieuGiaoHang";
        public const string Sp_Get_DanhSachPhieuChi = "Sp_Get_DanhSachPhieuChi";
        public const string Sp_Get_DanhSachPhieuChi_PhieuGiaoHang = "Sp_Get_DanhSachPhieuChi_PhieuGiaoHang";
        public const string Sp_Get_DanhSachHoaDon = "Sp_Get_DanhSachHoaDon";
        public const string Sp_Get_DanhSachHoaDon_Chitiet = "Sp_Get_DanhSachHoaDon_Chitiet";
        public const string SP_GetReport = "SP_GetReport";
        public const string Sp_Get_DanhSachPhieuGiaoHang_KPI = "Sp_Get_DanhSachPhieuGiaoHang_KPI";
        public const string Sp_Get_ThongKeCongNoKhachHang = "Sp_Get_ThongKeCongNoKhachHang";
        public const string Sp_Get_ThongKeCongNoNhaCungCap = "Sp_Get_ThongKeCongNoNhaCungCap";
        public const string Sp_Get_ThongKeCongNoNhanVien = "Sp_Get_ThongKeCongNoNhanVien";
        public const string Sp_Get_ThongKeTonKhoHangHoa = "Sp_Get_ThongKeTonKhoHangHoa";
        public const string Sp_Get_ThongKeQuyTien = "Sp_Get_ThongKeQuyTien";
        public const string Sp_Get_DanhSachPhieuDatHang_ChiTiet_KPI = "Sp_Get_DanhSachPhieuDatHang_ChiTiet_KPI";
        public const string Sp_Get_DanhSachPhieuTraHang_ChiTiet_KPI = "Sp_Get_DanhSachPhieuTraHang_ChiTiet_KPI";
        public const string Sp_Get_BaoCaoPhieuDatHang = "Sp_Get_BaoCaoPhieuDatHang";
        public const string Sp_Get_DanhSachPhieuNhap_ChiTiet_BaoCao = "Sp_Get_DanhSachPhieuNhap_ChiTiet_BaoCao";
        public const string Sp_Get_BaoCaoTaiChinh = "Sp_Get_BaoCaoTaiChinh";
        public const string Sp_Get_DanhSachPhieuDatHangNCC_Chitiet = "Sp_Get_DanhSachPhieuDatHangNCC_Chitiet";
        public const string Sp_Get_DanhSachPhieuDatHangNCC = "Sp_Get_DanhSachPhieuDatHangNCC";
        public const string Sp_Get_DanhSachHangHoa_NhanVien = "Sp_Get_DanhSachHangHoa_NhanVien";
        public const string Sp_Get_DanhSachHangHoa = "Sp_Get_DanhSachHangHoa";
        public const string Sp_Get_DanhSachHangHoa_KhachHang = "Sp_Get_DanhSachHangHoa_KhachHang";
        public const string Sp_Get_DanhSachHangHoa_BanChay = "Sp_Get_DanhSachHangHoa_BanChay";
        public const string Sp_Get_DanhSachPhieuGiaoHang_ChiTiet_BaoCao = "Sp_Get_DanhSachPhieuGiaoHang_ChiTiet_BaoCao";
        public const string Insert_Customer_Map = "Insert_Customer_Map";
        public const string Sp_Get_ThongKeThuChi_GroupBy = "Sp_Get_ThongKeThuChi_GroupBy";
        public const string Sp_Get_ThongKeThuChi = "Sp_Get_ThongKeThuChi";
        public const string Sp_Get_BaoCaoGiaoHang = "Sp_Get_BaoCaoGiaoHang";
        public const string Sp_Get_BaoCaoGiaoHang_ChiTiet = "Sp_Get_BaoCaoGiaoHang_ChiTiet";
        public const string Sp_Get_DanhSachBangLuong = "Sp_Get_DanhSachBangLuong";
        public const string Sp_Get_DanhSachChamCong = "Sp_Get_DanhSachChamCong";
        public const string Sp_Get_DanhSachNghiPhep = "Sp_Get_DanhSachNghiPhep";
        public const string Sp_Get_DanhSachPhieuNhapTraHang_ChiTiet_BaoCao = "Sp_Get_DanhSachPhieuNhapTraHang_ChiTiet_BaoCao";
        public const string Sp_Get_BaoCaoTheoNhanVien = "Sp_Get_BaoCaoTheoNhanVien";
        public const string Sp_Get_BaoCaoTaiChinh_New = "Sp_Get_BaoCaoTaiChinh_New";
        public const string Sp_Get_DanhSachPhieuXuat_ChiTiet_BC = "Sp_Get_DanhSachPhieuXuat_ChiTiet_BC";
        public const string Xem = "View";
        public const string Create = "Create";
        public const string CreateUser = "CreateUser";
        public const string Edit = "Edit";
        public const string Delete = "Delete";
        public const string UserData = "UserData";
        public const string AllData = "AllData";
        public const string CreateInput = "CreateInput";
        public const string ApproveLeave = "ApproveLeave";
        public const string Delivery = "Delivery";
        public const string Delivery_CreateReceipt = "Delivery_CreateReceipt";
        public const string Delivery_CreateReturn = "Delivery_CreateReturn";
        public const string EditPrice = "EditPrice";
        public const string TitlePermission = "Bạn không có quyền truy cập chức năng!";
        public const string TitleTryCatch = "Đã có lỗi phát sinh trong phiên làm việc!";
        public const string PathLogo = "/Images_Upload/Logo/";
        public const string PathProduct = "/Images_Upload/Product/";
        public const string PathCustomer = "/Images_Upload/Customer/";
        public const string PathUser = "/Images_Upload/User/";
        public const string PathDelivery_Image = "/Images_Upload/Delivery/";
        public const string PathProductServer = "C:\\FTP\\Images_Upload\\Product";

        public static double LATITUDE { get; set; }

        public static double LONGITUDE { get; set; }

        public static List<API.LoaiHangHoa> lstGioiTinh()
        {
            return new List<API.LoaiHangHoa>()
    {
      new API.LoaiHangHoa() { ID = 0, NAME = "Nữ" },
      new API.LoaiHangHoa() { ID = 1, NAME = "Nam" }
    };
        }

        public static List<API.LoaiHangHoa> lstHinhThucKhuyenMai()
        {
            return new List<API.LoaiHangHoa>()
    {
      new API.LoaiHangHoa() { ID = 0, NAME = "Sản phẩm" },
      new API.LoaiHangHoa() { ID = 1, NAME = "Nhóm sản phẩm" }
    };
        }

        public static List<API.LoaiHangHoa> lstHinhThucTinhKPI()
        {
            return new List<API.LoaiHangHoa>()
    {
      new API.LoaiHangHoa() { ID = 0, NAME = "Thưởng thêm" },
      new API.LoaiHangHoa()
      {
        ID = 1,
        NAME = "Thưởng thêm trên 1 số lượng"
      },
      new API.LoaiHangHoa()
      {
        ID = 2,
        NAME = "Thưởng thêm sau khi trừ tiền đạt mốc"
      },
      new API.LoaiHangHoa()
      {
        ID = 3,
        NAME = "Thưởng khi đạt mốc"
      }
    };
        }

        public static List<API.LoaiHangHoa> lstHinhThucNhanVien()
        {
            return new List<API.LoaiHangHoa>()
    {
      new API.LoaiHangHoa() { ID = 0, NAME = "Nhân viên" },
      new API.LoaiHangHoa() { ID = 1, NAME = "Nhóm quyền" }
    };
        }

        public static List<API.LoaiHangHoa> lstHinhThucNghiPhep()
        {
            return new List<API.LoaiHangHoa>()
    {
      new API.LoaiHangHoa() { ID = 0, NAME = "Nguyên Ngày" },
      new API.LoaiHangHoa() { ID = 1, NAME = "Buổi sáng" },
      new API.LoaiHangHoa() { ID = 2, NAME = "Buổi chiều" }
    };
        }

        public static List<API.LoaiHangHoa> lstLoaiHangHoa()
        {
            return new List<API.LoaiHangHoa>()
    {
      new API.LoaiHangHoa() { ID = 0, NAME = "Bình thường" },
      new API.LoaiHangHoa() { ID = 1, NAME = "Combo" },
      new API.LoaiHangHoa()
      {
        ID = 2,
        NAME = "Không quản lý số lượng"
      }
    };
        }

        public static List<API.LoaiHangHoa> lstTYPEInputOutput()
        {
            return new List<API.LoaiHangHoa>()
    {
      new API.LoaiHangHoa() { ID = 1, NAME = "Nhà cung cấp" },
      new API.LoaiHangHoa() { ID = 2, NAME = "Khách hàng" },
      new API.LoaiHangHoa() { ID = 3, NAME = "Nhân viên" }
    };
        }

        public static List<API.LoaiHangHoa> lstTYPEThuChi()
        {
            return new List<API.LoaiHangHoa>()
    {
      new API.LoaiHangHoa() { ID = 1, NAME = "Nhà cung cấp" },
      new API.LoaiHangHoa() { ID = 2, NAME = "Khách hàng" },
      new API.LoaiHangHoa() { ID = 3, NAME = "Nhân viên" },
      new API.LoaiHangHoa() { ID = 4, NAME = "Xe" }
    };
        }

        public static List<API.LoaiHangHoa> lstTYPELoaiLuong()
        {
            return new List<API.LoaiHangHoa>()
    {
      new API.LoaiHangHoa() { ID = -1, NAME = "-" },
      new API.LoaiHangHoa() { ID = 1, NAME = "+" }
    };
        }

        public static List<API.LoaiHangHoa> lstTYPELuong()
        {
            return new List<API.LoaiHangHoa>()
    {
      new API.LoaiHangHoa() { ID = 0, NAME = "Tiền lương" },
      new API.LoaiHangHoa() { ID = 1, NAME = "KPI" },
      new API.LoaiHangHoa() { ID = 2, NAME = "Khác" }
    };
        }

        public static List<API.LoaiHangHoa> lstTYPEQuyTacTinhLuong()
        {
            return new List<API.LoaiHangHoa>()
    {
      new API.LoaiHangHoa()
      {
        ID = 0,
        NAME = "Số thời gian làm việc"
      },
      new API.LoaiHangHoa() { ID = 1, NAME = "Ngày" },
      new API.LoaiHangHoa() { ID = 2, NAME = "Tháng" }
    };
        }

        public static string GetMaPhieu(string Type, DateTime Ngaylap, int SoPhieu)
        {
            string str = "";
            if (Type != null)
            {
                switch (Type.Length)
                {
                    case 5:
                        if (Type == "Input")
                        {
                            str = "PN";
                            break;
                        }
                        break;
                    case 6:
                        if (Type == "Output")
                        {
                            str = "PX";
                            break;
                        }
                        break;
                    case 7:
                        switch (Type[3])
                        {
                            case 'e':
                                if (Type == "Receipt")
                                {
                                    str = "PT";
                                    break;
                                }
                                break;
                            case 'm':
                                if (Type == "Payment")
                                {
                                    str = "PC";
                                    break;
                                }
                                break;
                            case 'o':
                                if (Type == "Deposit")
                                {
                                    str = "PDH";
                                    break;
                                }
                                break;
                            case 'r':
                                if (Type == "Payroll")
                                {
                                    str = "BL";
                                    break;
                                }
                                break;
                        }
                        break;
                    case 8:
                        switch (Type[0])
                        {
                            case 'D':
                                if (Type == "Delivery")
                                {
                                    str = "PGH";
                                    break;
                                }
                                break;
                            case 'I':
                                if (Type == "Invoiced")
                                {
                                    str = "HD";
                                    break;
                                }
                                break;
                        }
                        break;
                    case 14:
                        if (Type == "Order_Provider")
                        {
                            str = "NCC";
                            break;
                        }
                        break;
                    case 17:
                        if (Type == "WarehouseTransfer")
                        {
                            str = "PCK";
                            break;
                        }
                        break;
                }
            }
            return $"{str}-{Ngaylap.ToString("ddMMyy")}-{SoPhieu.ToString().PadLeft(5, '0')}";
        }

        public static Product_Detail TinhTong(
          Product_Detail Product_Detail,
          string VALUE,
          List<Product_Detail> lstProduct,
          DatabaseTHP.dm_ThueSuat dm_ThueSuat)
        {
            if (Product_Detail.TYPE == "ID_THUESUAT")
            {
                if (VALUE != null)
                    Product_Detail.ID_THUESUAT = VALUE;
                if (string.IsNullOrEmpty(Product_Detail.ID_THUESUAT))
                {
                    Product_Detail.THUESUAT = 0.0;
                    Product_Detail.TONGTIENVAT = 0.0;
                    Product_Detail.TONGCONG = Math.Round(Product_Detail.THANHTIEN + Product_Detail.TONGTIENVAT, 0);
                }
                else if (dm_ThueSuat != null)
                {
                    Product_Detail.THUESUAT = dm_ThueSuat.THUESUAT;
                    Product_Detail.TONGTIENVAT = Math.Round(Product_Detail.THANHTIEN * Product_Detail.THUESUAT / 100.0, 0);
                    Product_Detail.TONGCONG = Math.Round(Product_Detail.THANHTIEN + Product_Detail.TONGTIENVAT, 0);
                }
            }
            else if (Product_Detail.TYPE == "SOLUONG")
            {
                if (!string.IsNullOrEmpty(VALUE))
                    Product_Detail.SOLUONG = API.ConvertStringToDouble((object)VALUE);
                Product_Detail.TONGTIENGIAMGIA = Math.Round(Product_Detail.SOLUONG * Product_Detail.DONGIA * Product_Detail.CHIETKHAU / 100.0, 0);
                Product_Detail.THANHTIEN = Math.Round(Product_Detail.SOLUONG * Product_Detail.DONGIA - Product_Detail.TONGTIENGIAMGIA, 0);
                Product_Detail.TONGTIENVAT = Math.Round(Product_Detail.THANHTIEN * Product_Detail.THUESUAT / 100.0, 0);
                Product_Detail.TONGCONG = Math.Round(Product_Detail.THANHTIEN + Product_Detail.TONGTIENVAT, 0);
            }
            else if (Product_Detail.TYPE == "DONGIA")
            {
                if (!string.IsNullOrEmpty(VALUE))
                    Product_Detail.DONGIA = API.ConvertStringToDouble((object)VALUE);
                Product_Detail.TONGTIENGIAMGIA = Math.Round(Product_Detail.SOLUONG * Product_Detail.DONGIA * Product_Detail.CHIETKHAU / 100.0, 0);
                Product_Detail.THANHTIEN = Math.Round(Product_Detail.SOLUONG * Product_Detail.DONGIA - Product_Detail.TONGTIENGIAMGIA, 0);
                Product_Detail.TONGTIENVAT = Math.Round(Product_Detail.THANHTIEN * Product_Detail.THUESUAT / 100.0, 0);
                Product_Detail.TONGCONG = Math.Round(Product_Detail.THANHTIEN + Product_Detail.TONGTIENVAT, 0);
            }
            else if (Product_Detail.TYPE == "TONGTIENGIAMGIA")
            {
                if (!string.IsNullOrEmpty(VALUE))
                    Product_Detail.TONGTIENGIAMGIA = API.ConvertStringToDouble((object)VALUE);
                Product_Detail.THANHTIEN = Math.Round(Product_Detail.SOLUONG * Product_Detail.DONGIA - Product_Detail.TONGTIENGIAMGIA, 0);
                Product_Detail.TONGTIENVAT = Math.Round(Product_Detail.THANHTIEN * Product_Detail.THUESUAT / 100.0, 0);
                Product_Detail.TONGCONG = Math.Round(Product_Detail.THANHTIEN + Product_Detail.TONGTIENVAT, 0);
            }
            else if (Product_Detail.TYPE == "CHIETKHAU")
            {
                if (!string.IsNullOrEmpty(VALUE))
                    Product_Detail.CHIETKHAU = API.ConvertStringToDouble((object)VALUE);
                Product_Detail.TONGTIENGIAMGIA = Math.Round(Product_Detail.SOLUONG * Product_Detail.DONGIA * Product_Detail.CHIETKHAU / 100.0, 0);
                Product_Detail.THANHTIEN = Math.Round(Product_Detail.SOLUONG * Product_Detail.DONGIA - Product_Detail.TONGTIENGIAMGIA, 0);
                Product_Detail.TONGTIENVAT = Math.Round(Product_Detail.THANHTIEN * Product_Detail.THUESUAT / 100.0, 0);
                Product_Detail.TONGCONG = Math.Round(Product_Detail.THANHTIEN + Product_Detail.TONGTIENVAT, 0);
            }
            else if (Product_Detail.TYPE == "TONGTIENVAT")
            {
                if (!string.IsNullOrEmpty(VALUE))
                    Product_Detail.TONGTIENVAT = API.ConvertStringToDouble((object)VALUE);
                Product_Detail.TONGCONG = Math.Round(Product_Detail.THANHTIEN + Product_Detail.TONGTIENVAT, 0);
            }
            else if (Product_Detail.TYPE == "THANHTIEN")
            {
                if (!string.IsNullOrEmpty(VALUE))
                    Product_Detail.THANHTIEN = API.ConvertStringToDouble((object)VALUE);
                Product_Detail.TONGTIENVAT = Math.Round(Product_Detail.THANHTIEN * Product_Detail.THUESUAT / 100.0, 0);
                Product_Detail.TONGCONG = Math.Round(Product_Detail.THANHTIEN + Product_Detail.TONGTIENVAT, 0);
            }
            else if (Product_Detail.TYPE == "DONGIA")
            {
                if (!string.IsNullOrEmpty(VALUE))
                    Product_Detail.DONGIA = API.ConvertStringToDouble((object)VALUE);
                Product_Detail.TONGTIENGIAMGIA = Math.Round(Product_Detail.SOLUONG * Product_Detail.DONGIA * Product_Detail.CHIETKHAU / 100.0, 0);
                Product_Detail.THANHTIEN = Math.Round(Product_Detail.SOLUONG * Product_Detail.DONGIA - Product_Detail.TONGTIENGIAMGIA, 0);
                Product_Detail.TONGTIENVAT = Math.Round(Product_Detail.THANHTIEN * Product_Detail.THUESUAT / 100.0, 0);
                Product_Detail.TONGCONG = Math.Round(Product_Detail.THANHTIEN + Product_Detail.TONGTIENVAT, 0);
            }
            else if (Product_Detail.TYPE == "TONGCONG")
            {
                if (!string.IsNullOrEmpty(VALUE))
                    Product_Detail.TONGCONG = API.ConvertStringToDouble((object)VALUE);
            }
            else
            {
                Product_Detail.TONGTIENGIAMGIA = Math.Round(Product_Detail.SOLUONG * Product_Detail.DONGIA * Product_Detail.CHIETKHAU / 100.0, 0);
                Product_Detail.THANHTIEN = Math.Round(Product_Detail.SOLUONG * Product_Detail.DONGIA - Product_Detail.TONGTIENGIAMGIA, 0);
                Product_Detail.TONGTIENVAT = Math.Round(Product_Detail.THANHTIEN * Product_Detail.THUESUAT / 100.0, 0);
                Product_Detail.TONGCONG = Math.Round(Product_Detail.THANHTIEN + Product_Detail.TONGTIENVAT, 0);
            }
            if (!string.IsNullOrEmpty(Product_Detail.ID_COMBO))
            {
                foreach (Product_Detail productDetail in lstProduct.Where<Product_Detail>((Func<Product_Detail, bool>)(e => e.ID_COMBO == Product_Detail.ID_COMBO && e.ISCOMBO)))
                {
                    productDetail.ID_DVT = productDetail.ID_DVT_COMBO;
                    productDetail.SOLUONG = Product_Detail.SOLUONG * productDetail.QTY_COMBO;
                    productDetail.TYLE_QD = productDetail.TYLE_QD_COMBO;
                    productDetail.TONGSOLUONG = Product_Detail.SOLUONG * productDetail.QTY_TOTAL_COMBO;
                    productDetail.DONGIA = 0.0;
                    productDetail.ISCOMBO = true;
                    productDetail.ID_COMBO = Product_Detail.ID_HANGHOA;
                }
            }
            return Product_Detail;
        }

        public static double ConvertStringToDouble(object value)
        {
            try
            {
                return Convert.ToDouble(value);
            }
            catch
            {
                return 0.0;
            }
        }

        public static double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
        {
            double radians1 = API.ToRadians(lat2 - lat1);
            double radians2 = API.ToRadians(lon2 - lon1);
            double d = Math.Sin(radians1 / 2.0) * Math.Sin(radians1 / 2.0) + Math.Cos(API.ToRadians(lat1)) * Math.Cos(API.ToRadians(lat2)) * Math.Sin(radians2 / 2.0) * Math.Sin(radians2 / 2.0);
            return 6378137.0 * (2.0 * Math.Atan2(Math.Sqrt(d), Math.Sqrt(1.0 - d)));
        }

        private static double ToRadians(double angle) => angle * Math.PI / 180.0;

        public enum HinhThucNghiPhep
        {
            NguyenNgay,
            BuoiSang,
            BuoiChieu,
        }

        public enum HinhThucKhuyenMai
        {
            SanPham,
            NhomSanPham,
        }

        public enum HinhThucTinhKPI
        {
            ThuongThem,
            ThuongTheoSoLuong1,
            ThuongTuTroLen,
            ThuongKhiDatMoc,
        }

        public enum HinhThucTimKiem
        {
            Chon1,
            ChonSanPhamCombo,
            ChonSanPhamNhapXuatChuyen,
            ChonNhieu,
            ChonCTKM_YC,
            ChonCTKM_Tang,
            ChonCTKM_YC_NHOMSANPHAM,
            Chon1_GiaoHang,
            Chon1_NhanVien,
            Chon1_NhomQuyen,
        }

        public enum LoaiSanPham
        {
            BinhThuong,
            Combo,
            KhongQuanLyTonKho,
        }

        public enum Luong
        {
            Luong,
            KPI,
            Khac,
        }

        public enum QuyTacTinhLuong
        {
            ThoiGianLamViec,
            Ngay,
            Thang,
        }

        public class LoaiHangHoa
        {
            public int ID { get; set; }

            public string NAME { get; set; }
        }
    }
}
