using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CSLT_hungdoan30.session3
{
    enum CurrencyType { USD, EUR, JPY, GBP }

    enum StockStatus { OutOfStock, LowStock, InStock, Discontinued }

    enum VehicleType { Motorbike, Car, Truck }

    enum CustomerType { Child, Student, Adult, Senior }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            bool dangChay = true;
            while (dangChay)
            {
                HienThiMenu();
                string luaChon = Console.ReadLine();
                Console.WriteLine();

                switch (luaChon)
                {
                    case "1": Bai01_TinhTienDien(); break;
                    case "2": Bai02_TinhBMI(); break;
                    case "3": Bai03_QuyDoiTienTe(); break;
                    case "4": Bai04_TinhTuoi(); break;
                    case "5": Bai05_TinhGPA(); break;
                    case "6": Bai06_ChuanHoaHoTen(); break;
                    case "7": Bai07_ChiPhiXangDau(); break;
                    case "8": Bai08_KiemTraOTP(); break;
                    case "9": Bai09_LuongGrossNet(); break;
                    case "10": Bai10_QuanLyTonKho(); break;
                    case "11": Bai11_LaiSuatTietKiem(); break;
                    case "12": Bai12_CaesarCipher(); break;
                    case "13": Bai13_BaiDoXe(); break;
                    case "14": Bai14_XuLyChuoiSoAnToan(); break;
                    case "15": Bai15_BanVeRapPhim(); break;
                    case "0": dangChay = false; break;
                    default: Console.WriteLine("Lựa chọn không hợp lệ, vui lòng chọn lại "); break;
                }

                if (dangChay)
                {
                    Console.WriteLine("\nNhấn Enter để quay về Menu...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

            Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình.");
        }

        static void HienThiMenu()
        {
            Console.WriteLine(" 1.  Tính tiền điện gia đình sinh hoạt theo bậc thang (EVN)");
            Console.WriteLine(" 2.  Tính chỉ số BMI");
            Console.WriteLine(" 3.  Quy đổi tiền tệ ngoại tệ");
            Console.WriteLine(" 4.  Tính tuổi & đếm ngược sinh nhật");
            Console.WriteLine(" 5.  Tính điểm GPA học phần");
            Console.WriteLine(" 6.  Chuẩn hóa họ tên & tạo email");
            Console.WriteLine(" 7.  Chi phí nhiên liệu chuyến đi (car-pooling)");
            Console.WriteLine(" 8.  Kiểm tra mã OTP");
            Console.WriteLine(" 9.  Tính lương Gross - Net & thuế TNCN");
            Console.WriteLine("10.  Quản lý tồn kho (Nullable Types)");
            Console.WriteLine("11.  Tính lãi suất tiết kiệm (đơn & kép)");
            Console.WriteLine("12.  Mã hóa/giải mã Caesar Cipher");
            Console.WriteLine("13.  Tính phí gửi xe bãi đỗ thông minh");
            Console.WriteLine("14.  Xử lý chuỗi số an toàn & kiểm tra tràn số");
            Console.WriteLine("15.  Bán vé rạp chiếu phim & chiết khấu");
            Console.WriteLine(" 0.  Thoát chương trình");
            Console.Write("Nhập lựa chọn của bạn: ");
        }

   
        // BÀI 1: TÍNH TIỀN ĐIỆN SINH HOẠT BẬC THANG (EVN)
 
        static void Bai01_TinhTienDien()
        {
            Console.WriteLine("BÀI 1: TÍNH TIỀN ĐIỆN SINH HOẠT");
            Console.Write("Nhập chỉ số điện cũ (kWh): ");
            double chisocu = double.Parse(Console.ReadLine());
            Console.Write("Nhập chỉ số điện mới (kWh): ");
            double chisomoi = double.Parse(Console.ReadLine());

            if (chisomoi < chisocu)
            {
                Console.WriteLine("Chỉ số mới phải lớn hơn hoặc bằng chỉ số cũ");
                return;
            }

            double sodienTieuThu = chisomoi - chisocu;

            decimal gia1 = 1806m, gia2 = 1866m, gia3 = 2167m, gia4 = 2729m, gia5 = 3050m;

            decimal tienDien = 0m;
            double soConLai = sodienTieuThu;

            // Bậc 1
            double bac1 = Math.Min(soConLai, 50);
            tienDien += (decimal)bac1 * gia1;
            soConLai -= bac1;

            // Bậc 2
            double bac2 = Math.Min(soConLai, 50);
            tienDien += (decimal)bac2 * gia2;
            soConLai -= bac2;

            // Bậc 3
            double bac3 = Math.Min(soConLai, 100);
            tienDien += (decimal)bac3 * gia3;
            soConLai -= bac3;

            // Bậc 4
            double bac4 = Math.Min(soConLai, 100);
            tienDien += (decimal)bac4 * gia4;
            soConLai -= bac4;

            // Bậc 5 (từ 301 kWh trở lên)
            double bac5 = soConLai;
            tienDien += (decimal)bac5 * gia5;

            decimal thueVAT = tienDien * 0.08m; 
            decimal tongTien = Math.Round(tienDien + thueVAT, 0); 

            Console.WriteLine($"\nSố điện tiêu thụ: {sodienTieuThu:N0} kWh");
            Console.WriteLine($"Tiền điện chưa thuế: {tienDien:N0} VNĐ");
            Console.WriteLine($"Thuế VAT (8%): {thueVAT:N0} VNĐ");
            Console.WriteLine($"Tổng thanh toán: {tongTien:N0} VNĐ");
        }

        
        // BÀI 2: TÍNH CHỈ SỐ BMI

        static void Bai02_TinhBMI()
        {
            Console.WriteLine("BÀI 2: TÍNH CHỈ SỐ BMI");
            Console.Write("Chiều cao (m): ");
            double chieuCao = double.Parse(Console.ReadLine());
            Console.Write("Cân nặng (kg): ");
            double canNang = double.Parse(Console.ReadLine());

            double bmi = canNang / Math.Pow(chieuCao, 2);

            string phanLoai;
            if (bmi < 18.5) phanLoai = "Gầy (Thiếu cân)";
            else if (bmi < 23.0) phanLoai = "Bình thường (Lý tưởng)";
            else if (bmi < 25.0) phanLoai = "Thừa cân (Tiền béo phì)";
            else phanLoai = "Béo phì";

            double canNangMin = 18.5 * Math.Pow(chieuCao, 2);
            double canNangMax = 22.9 * Math.Pow(chieuCao, 2);

            Console.WriteLine($"\nChỉ số BMI của bạn: {bmi:F2}");
            Console.WriteLine($"Phân loại sức khỏe: {phanLoai}");
            Console.WriteLine($"Khuyên dùng: Cân nặng lý tưởng của bạn nên từ {canNangMin:F2} kg đến {canNangMax:F2} kg.");
        }

        // BÀI 3: QUY ĐỔI TIỀN TỆ NGOẠI TỆ

        static void Bai03_QuyDoiTienTe()
        {
            Console.WriteLine("BÀI 3: QUY ĐỔI TIỀN TỆ ");
            Console.Write("Nhập số tiền VNĐ cần đổi: ");
            decimal soTienVND = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Chọn ngoại tệ: 1-USD, 2-EUR, 3-JPY, 4-GBP");
            Console.Write("Lựa chọn: ");
            int luaChon = int.Parse(Console.ReadLine());

            CurrencyType loaiTien;
            decimal tyGia; // 1 đơn vị ngoại tệ = bao nhiêu VNĐ

            switch (luaChon)
            {
                case 1: loaiTien = CurrencyType.USD; tyGia = 25400m; break;
                case 2: loaiTien = CurrencyType.EUR; tyGia = 27200m; break;
                case 3: loaiTien = CurrencyType.JPY; tyGia = 165m; break;
                case 4: loaiTien = CurrencyType.GBP; tyGia = 32100m; break;
                default:
                    Console.WriteLine("Lựa chọn ngoại tệ không hợp lệ!");
                    return;
            }

            decimal phiDichVu = soTienVND * 0.005m; // phí 0.5%
            decimal soTienSauPhi = soTienVND - phiDichVu;
            decimal soTienNgoaiTe = soTienSauPhi / tyGia;

            Console.WriteLine($"\nPhí dịch vụ (0.5%): {phiDichVu:N0} VNĐ");
            Console.WriteLine($"Số tiền VNĐ tính đổi: {soTienSauPhi:N0} VNĐ");
            Console.WriteLine($"Số tiền {loaiTien} nhận được: {soTienNgoaiTe:N2} {loaiTien}");
        }

        // =================================================================
        // BÀI 4: TÍNH TUỔI CHÍNH XÁC & ĐẾM NGƯỢC SINH NHẬT
        // Kiến thức: DateTime, TimeSpan, DateTime.TryParseExact
        // =================================================================
        static void Bai04_TinhTuoi()
        {
            Console.WriteLine("----- BÀI 4: TÍNH TUỔI & ĐẾM NGƯỢC SINH NHẬT -----");
            Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
            string input = Console.ReadLine();

            // TryParseExact trả về bool, không ném lỗi nếu sai định dạng -> an toàn hơn Parse thường
            bool hopLe = DateTime.TryParseExact(
                input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngaySinh);

            if (!hopLe)
            {
                Console.WriteLine("Ngày sinh không đúng định dạng dd/MM/yyyy!");
                return;
            }

            DateTime homNay = DateTime.Now.Date;

            int tuoi = homNay.Year - ngaySinh.Year;
            // Nếu năm nay chưa tới ngày sinh nhật thì phải trừ đi 1 tuổi
            if (homNay < ngaySinh.AddYears(tuoi)) tuoi--;

            // Phép trừ 2 DateTime trả về 1 TimeSpan
            TimeSpan daSong = homNay - ngaySinh;

            // Tìm sinh nhật gần nhất sắp tới (năm nay hoặc năm sau)
            DateTime sinhNhatNamNay = new DateTime(homNay.Year, ngaySinh.Month, ngaySinh.Day);
            DateTime sinhNhatTiepTheo = sinhNhatNamNay >= homNay ? sinhNhatNamNay : sinhNhatNamNay.AddYears(1);
            TimeSpan conLai = sinhNhatTiepTheo - homNay;

            Console.WriteLine($"\nTuổi hiện tại: {tuoi} tuổi");
            Console.WriteLine($"Bạn đã sống tổng cộng: {daSong.TotalDays:N0} ngày");
            Console.WriteLine($"Sinh nhật tiếp theo còn: {conLai.TotalDays:N0} ngày nữa");
        }

        // =================================================================
        // BÀI 5: QUẢN LÝ ĐIỂM HỌC PHẦN & QUY ĐỔI GPA
        // Kiến thức: double, điểm trung bình trọng số, cấu trúc rẽ nhánh
        // =================================================================
        static void Bai05_TinhGPA()
        {
            Console.WriteLine("----- BÀI 5: TÍNH ĐIỂM GPA -----");
            Console.Write("Điểm C# (thang 10): "); double diemCS = double.Parse(Console.ReadLine());
            Console.Write("Số tín chỉ C#: "); int tcCS = int.Parse(Console.ReadLine());
            Console.Write("Điểm Toán rời rạc (thang 10): "); double diemToan = double.Parse(Console.ReadLine());
            Console.Write("Số tín chỉ Toán: "); int tcToan = int.Parse(Console.ReadLine());
            Console.Write("Điểm Tiếng Anh (thang 10): "); double diemAnh = double.Parse(Console.ReadLine());
            Console.Write("Số tín chỉ Tiếng Anh: "); int tcAnh = int.Parse(Console.ReadLine());

            int tongTinChi = tcCS + tcToan + tcAnh;
            // Điểm trung bình trọng số = tổng(điểm x tín chỉ) / tổng tín chỉ
            double diemTB = (diemCS * tcCS + diemToan * tcToan + diemAnh * tcAnh) / tongTinChi;

            string diemChu;
            double thang4;
            string xepLoai;

            if (diemTB >= 8.5) { diemChu = "A"; thang4 = 4.0; xepLoai = "Xuất sắc / Giỏi"; }
            else if (diemTB >= 7.0) { diemChu = "B"; thang4 = 3.0; xepLoai = "Khá"; }
            else if (diemTB >= 5.5) { diemChu = "C"; thang4 = 2.0; xepLoai = "Trung bình"; }
            else if (diemTB >= 4.0) { diemChu = "D"; thang4 = 1.0; xepLoai = "Yếu"; }
            else { diemChu = "F"; thang4 = 0.0; xepLoai = "Kém (Trượt)"; }

            Console.WriteLine($"\nĐiểm TB Thang 10: {diemTB:F2}");
            Console.WriteLine($"Điểm Chữ Quy Đổi: {diemChu}");
            Console.WriteLine($"Điểm GPA Thang 4: {thang4:F1}");
            Console.WriteLine($"Xếp Loại Học Lực: {xepLoai}");
        }

        // ----- Hàm phụ trợ cho Bài 6: xóa dấu tiếng Việt -----
        static string XoaDauTiengViet(string s)
        {
            // Tách ký tự gốc và dấu ra riêng (Unicode Normalization Form D)
            string chuoiTach = s.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();
            foreach (char c in chuoiTach)
            {
                // Bỏ qua các ký tự thuộc nhóm "dấu kết hợp" (NonSpacingMark)
                var loaiKyTu = CharUnicodeInfo.GetUnicodeCategory(c);
                if (loaiKyTu != UnicodeCategory.NonSpacingMark)
                    sb.Append(c);
            }
            string ketQua = sb.ToString().Normalize(NormalizationForm.FormC);
            // Chữ "đ" không tách dấu được bằng NormalizationForm nên xử lý riêng
            ketQua = ketQua.Replace('đ', 'd').Replace('Đ', 'D');
            return ketQua;
        }

        // ----- Hàm phụ trợ cho Bài 6: viết hoa chữ cái đầu mỗi từ -----
        static string ChuyenThanhTitleCase(string s)
        {
            string[] tuList = s.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < tuList.Length; i++)
            {
                string tuThuong = tuList[i].ToLower();
                tuList[i] = char.ToUpper(tuThuong[0]) + tuThuong.Substring(1);
            }
            return string.Join(" ", tuList);
        }

        // =================================================================
        // BÀI 6: CHUẨN HÓA HỌ TÊN & TẠO EMAIL/USERNAME
        // Kiến thức: string, Trim, Split, Substring, ToLower/ToUpper, Join
        // =================================================================
        static void Bai06_ChuanHoaHoTen()
        {
            Console.WriteLine("----- BÀI 6: CHUẨN HÓA HỌ TÊN & TẠO EMAIL -----");
            Console.Write("Nhập họ tên thô: ");
            string hoTenTho = Console.ReadLine();

            string hoTenChuan = ChuyenThanhTitleCase(hoTenTho);
            string[] phanTu = hoTenChuan.Split(' ');

            string ho = phanTu[0];
            string ten = phanTu[phanTu.Length - 1];
            // Tên đệm là các từ ở giữa (nếu có)
            string tenDem = phanTu.Length > 2
                ? string.Join(" ", phanTu, 1, phanTu.Length - 2)
                : "";

            string hoVaTenDem = tenDem.Length > 0 ? ho + " " + tenDem : ho;

            string tenKhongDau = XoaDauTiengViet(ten).ToLower();
            string hoTenDemKhongDau = XoaDauTiengViet(hoVaTenDem).Replace(" ", "").ToLower();

            string username = $"{tenKhongDau}.{hoTenDemKhongDau}";
            string email = $"{username}@company.edu.vn";

            Console.WriteLine($"\nHọ tên chuẩn hóa: {hoTenChuan}");
            Console.WriteLine($"Họ: {ho} | Tên đệm: {(tenDem.Length > 0 ? tenDem : "(không có)")} | Tên: {ten}");
            Console.WriteLine($"Username tạo tự động: {username}");
            Console.WriteLine($"Email cấp phát: {email}");
        }

        // =================================================================
        // BÀI 7: CHI PHÍ NHIÊN LIỆU CHUYẾN ĐI (CAR-POOLING)
        // Kiến thức: double, decimal, int, Math.Ceiling
        // =================================================================
        static void Bai07_ChiPhiXangDau()
        {
            Console.WriteLine("----- BÀI 7: CHI PHÍ NHIÊN LIỆU CHUYẾN ĐI -----");
            Console.Write("Quãng đường (km): "); double quangDuong = double.Parse(Console.ReadLine());
            Console.Write("Mức tiêu hao (Lít/100km): "); double tieuHao = double.Parse(Console.ReadLine());
            Console.Write("Giá xăng (VNĐ/Lít): "); decimal giaXang = decimal.Parse(Console.ReadLine());
            Console.Write("Số người tham gia: "); int soNguoi = int.Parse(Console.ReadLine());

            double tongLit = (quangDuong / 100) * tieuHao;
            // Ép kiểu double -> decimal khi nhân với đơn giá tiền tệ
            decimal tongChiPhi = (decimal)tongLit * giaXang;
            decimal chiPhiMoiNguoi = tongChiPhi / soNguoi;

            // Làm tròn LÊN đến hàng nghìn VNĐ gần nhất
            chiPhiMoiNguoi = Math.Ceiling(chiPhiMoiNguoi / 1000) * 1000;

            Console.WriteLine($"\nTổng nhiên liệu tiêu thụ: {tongLit:F2} Lít");
            Console.WriteLine($"Tổng chi phí xăng dầu: {tongChiPhi:N0} VNĐ");
            Console.WriteLine($"Chi phí mỗi người: {chiPhiMoiNguoi:N0} VNĐ");
        }

        // =================================================================
        // BÀI 8: KIỂM TRA MÃ XÁC THỰC OTP
        // Kiến thức: string, DateTime, TimeSpan, bool, so sánh chuỗi
        // =================================================================
        static void Bai08_KiemTraOTP()
        {
            Console.WriteLine("----- BÀI 8: KIỂM TRA MÃ OTP -----");

            // Mô phỏng mã OTP hệ thống đã gửi và thời điểm phát hành
            string maOTPHeThong = "839201";
            DateTime thoiDiemTao = DateTime.Now;

            Console.Write("Nhập mã OTP nhận được: ");
            string maNhap = Console.ReadLine();

            Console.Write("Giả lập số giây đã trôi qua kể từ lúc tạo mã: ");
            bool hopLeSo = int.TryParse(Console.ReadLine(), out int soGiayTroiQua);

            // Điều kiện 1: đúng 6 ký tự và toàn bộ là chữ số
            if (maNhap.Length != 6 || !maNhap.All(char.IsDigit))
            {
                Console.WriteLine("\nTrạng thái xác thực: LỖI - Định dạng OTP không hợp lệ (phải gồm đúng 6 chữ số).");
                return;
            }

            // Điều kiện 2: mã nhập khớp với mã hệ thống
            if (maNhap != maOTPHeThong)
            {
                Console.WriteLine("\nTrạng thái xác thực: LỖI - Mã OTP không chính xác.");
                return;
            }

            if (!hopLeSo)
            {
                Console.WriteLine("\nGiá trị thời gian nhập không hợp lệ.");
                return;
            }

            // Điều kiện 3: chưa vượt quá 5 phút (300 giây) hiệu lực
            DateTime thoiDiemXacThuc = thoiDiemTao.AddSeconds(soGiayTroiQua);
            TimeSpan chenhLech = thoiDiemXacThuc - thoiDiemTao;

            if (chenhLech.TotalSeconds > 300)
                Console.WriteLine("\nTrạng thái xác thực: LỖI - Mã OTP đã hết hạn (quá 5 phút).");
            else
                Console.WriteLine("\nTrạng thái xác thực: THÀNH CÔNG - Giao dịch đã được phê duyệt.");
        }

        // ----- Hàm phụ trợ cho Bài 9: tính thuế TNCN lũy tiến từng phần -----
        static decimal TinhThueLuyTien(decimal thuNhapChiuThue)
        {
            // Các ngưỡng bậc thuế (VNĐ/tháng) và thuế suất tương ứng theo biểu thuế TNCN
            decimal[] nguongBac = { 5000000m, 10000000m, 18000000m, 32000000m, 52000000m, 80000000m };
            decimal[] thueSuat = { 0.05m, 0.10m, 0.15m, 0.20m, 0.25m, 0.30m, 0.35m };

            decimal thue = 0m;
            decimal daTinhDenNguong = 0m;

            for (int i = 0; i < nguongBac.Length; i++)
            {
                if (thuNhapChiuThue > nguongBac[i])
                {
                    decimal phanTrongBac = nguongBac[i] - daTinhDenNguong;
                    thue += phanTrongBac * thueSuat[i];
                    daTinhDenNguong = nguongBac[i];
                }
                else
                {
                    thue += (thuNhapChiuThue - daTinhDenNguong) * thueSuat[i];
                    return thue;
                }
            }
            // Phần thu nhập vượt quá bậc cao nhất (bậc 7: 35%)
            thue += (thuNhapChiuThue - daTinhDenNguong) * thueSuat[6];
            return thue;
        }

        // =================================================================
        // BÀI 9: MÁY TÍNH LƯƠNG GROSS - NET & THUẾ TNCN
        // Kiến thức: decimal, double, bool, thuế lũy tiến từng phần
        // =================================================================
        static void Bai09_LuongGrossNet()
        {
            Console.WriteLine("----- BÀI 9: TÍNH LƯƠNG GROSS - NET -----");
            Console.Write("Lương Gross (VNĐ): "); decimal luongGross = decimal.Parse(Console.ReadLine());
            Console.Write("Số người phụ thuộc: "); int soNguoiPhuThuoc = int.Parse(Console.ReadLine());

            decimal bhxh = luongGross * 0.08m;   // Bảo hiểm xã hội 8%
            decimal bhyt = luongGross * 0.015m;  // Bảo hiểm y tế 1.5%
            decimal bhtn = luongGross * 0.01m;   // Bảo hiểm thất nghiệp 1%
            decimal tongBaoHiem = bhxh + bhyt + bhtn; // Tổng = 10.5%

            decimal mucGiamTruBanThan = 11000000m;
            decimal mucGiamTruPhuThuoc = 4400000m * soNguoiPhuThuoc;

            decimal thuNhapChiuThue = luongGross - tongBaoHiem - mucGiamTruBanThan - mucGiamTruPhuThuoc;
            if (thuNhapChiuThue < 0) thuNhapChiuThue = 0;

            decimal thueTNCN = TinhThueLuyTien(thuNhapChiuThue);
            decimal luongNet = luongGross - tongBaoHiem - thueTNCN;

            Console.WriteLine($"\nGiảm trừ Bảo hiểm (10.5%): {tongBaoHiem:N0} VNĐ");
            Console.WriteLine($"Thu nhập chịu thuế: {thuNhapChiuThue:N0} VNĐ");
            Console.WriteLine($"Thuế TNCN phải nộp: {thueTNCN:N0} VNĐ");
            Console.WriteLine($"LƯƠNG NET THỰC NHẬN: {luongNet:N0} VNĐ");
        }

        // =================================================================
        // BÀI 10: QUẢN LÝ TỒN KHO & XỬ LÝ NULLABLE TYPES
        // Kiến thức: int?, DateTime?, toán tử ?? và ?.
        // =================================================================
        static void Bai10_QuanLyTonKho()
        {
            Console.WriteLine("----- BÀI 10: QUẢN LÝ TỒN KHO (NULLABLE TYPES) -----");

            string maSanPham = "KB-09";
            string tenSanPham = "Bàn phím Cơ Akko";
            int? quantity = null;           // Số lượng CHƯA kiểm kê -> null
            int minThreshold = 10;          // Ngưỡng cảnh báo sắp hết hàng
            DateTime? restockDate = null;   // CHƯA có lịch nhập hàng tiếp theo

            // Toán tử ?? (null-coalescing): nếu quantity là null thì lấy giá trị 0
            int soLuongHienThi = quantity ?? 0;

            StockStatus trangThai;
            if (quantity == null || quantity == 0)
                trangThai = StockStatus.OutOfStock;
            else if (quantity < minThreshold)
                trangThai = StockStatus.LowStock;
            else
                trangThai = StockStatus.InStock;

            // Toán tử ?. (null-conditional): chỉ gọi ToString() nếu restockDate KHÔNG null
            string ngayNhapHang = restockDate?.ToString("dd/MM/yyyy") ?? "Chưa có lịch nhập hàng";

            Console.WriteLine($"\nSản phẩm: {tenSanPham} (Mã: {maSanPham})");
            Console.WriteLine($"Số lượng hiển thị: {soLuongHienThi}" +
                (quantity == null ? " (Cảnh báo: Dữ liệu trống)" : ""));
            Console.WriteLine($"Trạng thái kho: {trangThai}");
            Console.WriteLine($"Dự kiến nhập hàng: {ngayNhapHang}");
        }

        // =================================================================
        // BÀI 11: TÍNH LÃI SUẤT TIẾT KIỆM (LÃI ĐƠN & LÃI KÉP)
        // Kiến thức: decimal, double, Math.Pow, ép kiểu qua lại
        // =================================================================
        static void Bai11_LaiSuatTietKiem()
        {
            Console.WriteLine("----- BÀI 11: TÍNH LÃI SUẤT TIẾT KIỆM -----");
            Console.Write("Số tiền gửi ban đầu (VNĐ): "); decimal P = decimal.Parse(Console.ReadLine());
            Console.Write("Lãi suất năm (%/năm, ví dụ 6.8): "); double r = double.Parse(Console.ReadLine());
            Console.Write("Kỳ hạn gửi (tháng): "); int n = int.Parse(Console.ReadLine());

            // Lãi đơn = P * (r/100) * (n/12)
            decimal laiDon = P * (decimal)(r / 100) * ((decimal)n / 12m);

            // Lãi kép cần dùng Math.Pow (chỉ nhận double) nên phải ép P sang double,
            // rồi ép kết quả trở lại decimal vì đây vẫn là số tiền.
            double pDouble = (double)P;
            double tongTienKepDouble = pDouble * Math.Pow(1 + (r / 100) / 12, n);
            decimal tongTienKep = (decimal)tongTienKepDouble;
            decimal laiKep = tongTienKep - P;

            decimal chenhLech = laiKep - laiDon;

            Console.WriteLine($"\nTổng tiền lãi (Lãi đơn): {laiDon:N0} VNĐ");
            Console.WriteLine($"Tổng tiền lãi (Lãi kép): {laiKep:N0} VNĐ");
            Console.WriteLine($"Lợi nhuận chênh lệch: {chenhLech:N0} VNĐ (Lãi kép tối ưu hơn)");
        }

        // ----- Hàm phụ trợ cho Bài 12: mã hóa Caesar Cipher -----
        static string MaHoaCaesar(string vanBan, int k)
        {
            var sb = new StringBuilder();
            foreach (char c in vanBan)
            {
                if (c >= 'A' && c <= 'Z')
                    // Ép kiểu char <-> int để tính vị trí mới trong bảng chữ cái
                    sb.Append((char)('A' + (c - 'A' + k) % 26));
                else if (c >= 'a' && c <= 'z')
                    sb.Append((char)('a' + (c - 'a' + k) % 26));
                else
                    sb.Append(c); // số, khoảng trắng, dấu câu giữ nguyên
            }
            return sb.ToString();
        }

        // =================================================================
        // BÀI 12: MÃ HÓA & GIẢI MÃ TIN NHẮN CAESAR CIPHER
        // Kiến thức: char, string, ép kiểu int <-> char, phép chia lấy dư
        // =================================================================
        static void Bai12_CaesarCipher()
        {
            Console.WriteLine("----- BÀI 12: MÃ HÓA CAESAR CIPHER -----");
            Console.Write("Văn bản gốc: "); string vanBan = Console.ReadLine();
            Console.Write("Khóa dịch chuyển k (1-25): "); int k = int.Parse(Console.ReadLine());

            string maHoa = MaHoaCaesar(vanBan, k);
            // Giải mã = dịch chuyển bù (26 - k) để quay ngược lại đúng vị trí ban đầu
            string giaiMa = MaHoaCaesar(maHoa, 26 - k);

            Console.WriteLine($"\nVăn bản Mã hóa: {maHoa}");
            Console.WriteLine($"Văn bản Giải mã: {giaiMa}");
        }

        // =================================================================
        // BÀI 13: BÃI ĐỖ XE THÔNG MINH & TÍNH PHÍ GỬI XE
        // Kiến thức: DateTime, TimeSpan, enum, Math.Ceiling, decimal
        // =================================================================
        static void Bai13_BaiDoXe()
        {
            Console.WriteLine("----- BÀI 13: TÍNH PHÍ GỬI XE -----");
            Console.WriteLine("Chọn loại xe: 1-Motorbike, 2-Car, 3-Truck");
            Console.Write("Lựa chọn: "); int chonXe = int.Parse(Console.ReadLine());
            VehicleType loaiXe = (VehicleType)(chonXe - 1);

            Console.Write("Giờ vào (yyyy-MM-dd HH:mm): ");
            DateTime gioVao = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Giờ ra (yyyy-MM-dd HH:mm): ");
            DateTime gioRa = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);

            // TimeSpan.TotalHours trả về số giờ dạng double (có phần thập phân)
            double tongGio = (gioRa - gioVao).TotalHours;
            int soGioTinhPhi = (int)Math.Ceiling(tongGio); // làm tròn LÊN số giờ nguyên

            decimal phi2GioDau, phiThemMoiGio;
            switch (loaiXe)
            {
                case VehicleType.Motorbike: phi2GioDau = 5000m; phiThemMoiGio = 2000m; break;
                case VehicleType.Car: phi2GioDau = 20000m; phiThemMoiGio = 10000m; break;
                default: phi2GioDau = 50000m; phiThemMoiGio = 25000m; break; // Truck
            }

            decimal tongPhi = phi2GioDau;
            int soGioThem = 0;
            if (soGioTinhPhi > 2)
            {
                soGioThem = soGioTinhPhi - 2;
                tongPhi += soGioThem * phiThemMoiGio;
            }

            // Phụ phí qua đêm nếu giờ vào và giờ ra không cùng một ngày (đi qua mốc 00:00)
            if (gioVao.Date != gioRa.Date)
                tongPhi += 30000m;

            Console.WriteLine($"\nTổng thời gian đỗ: {tongGio:F2} giờ -> Tính phí: {soGioTinhPhi} giờ");
            Console.WriteLine($"Phí 2 giờ đầu: {phi2GioDau:N0} VNĐ");
            if (soGioThem > 0)
                Console.WriteLine($"Phí {soGioThem} giờ tiếp theo: {soGioThem * phiThemMoiGio:N0} VNĐ ({phiThemMoiGio:N0} x {soGioThem})");
            Console.WriteLine($"TỔNG PHÍ ĐỖ XE: {tongPhi:N0} VNĐ");
        }

        // =================================================================
        // BÀI 14: XỬ LÝ CHUỖI SỐ AN TOÀN & KIỂM TRA TRÀN SỐ
        // Kiến thức: TryParse, byte/short/int/long, khối checked, OverflowException
        // =================================================================
        static void Bai14_XuLyChuoiSoAnToan()
        {
            Console.WriteLine("----- BÀI 14: XỬ LÝ CHUỖI SỐ AN TOÀN -----");
            Console.Write("Nhập chuỗi số: "); string input = Console.ReadLine();

            // TryParse trả về bool và KHÔNG ném exception nếu sai định dạng -> an toàn hơn Parse
            bool hopLe = int.TryParse(input, out int giaTri);

            if (!hopLe)
            {
                Console.WriteLine("Kiểm tra Parse: THẤT BẠI! Chuỗi nhập vào không phải là số nguyên hợp lệ.");
                return;
            }

            Console.WriteLine($"Kiểm tra Parse: Thành công! Giá trị int = {giaTri}");

            bool phuHopByte = giaTri >= byte.MinValue && giaTri <= byte.MaxValue;
            bool phuHopShort = giaTri >= short.MinValue && giaTri <= short.MaxValue;
            Console.WriteLine($"Phù hợp kiểu byte (0-255): {(phuHopByte ? "CÓ" : "KHÔNG")}");
            Console.WriteLine($"Phù hợp kiểu short (-32,768 đến 32,767): {(phuHopShort ? "CÓ" : "KHÔNG")}");

            // Tính tổng các chữ số cấu thành số
            int soDuong = Math.Abs(giaTri);
            string chuoiSo = soDuong.ToString();
            int tongChuSo = 0;
            foreach (char c in chuoiSo)
                tongChuSo += (c - '0'); // ép kiểu ngầm định char -> int dựa trên bảng mã ASCII

            Console.WriteLine($"Tổng các chữ số: {string.Join(" + ", chuoiSo.ToCharArray())} = {tongChuSo}");

            // Dùng khối checked{} để buộc CLR kiểm tra tràn số khi tính toán
            try
            {
                checked
                {
                    int ketQuaBinhPhuong = giaTri * giaTri;
                    Console.WriteLine($"Kiểm tra Tràn số: An toàn trong phạm vi int32 (bình phương = {ketQuaBinhPhuong}).");
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Kiểm tra Tràn số: PHÁT HIỆN TRÀN SỐ (OverflowException)! Giá trị vượt quá giới hạn int32.");
            }
        }

        // =================================================================
        // BÀI 15: BÁN VÉ RẠP CHIẾU PHIM & CHIẾT KHẤU TỰ ĐỘNG
        // Kiến thức: enum, DayOfWeek, decimal, bool, cấu trúc logic điều kiện
        // =================================================================
        static void Bai15_BanVeRapPhim()
        {
            Console.WriteLine("----- BÀI 15: BÁN VÉ RẠP CHIẾU PHIM -----");
            Console.WriteLine("Chọn loại khách hàng: 1-Child, 2-Student, 3-Adult, 4-Senior");
            Console.Write("Lựa chọn: "); int chonKH = int.Parse(Console.ReadLine());
            CustomerType loaiKhachHang = (CustomerType)(chonKH - 1);

            bool coTheSV = false;
            if (loaiKhachHang == CustomerType.Student)
            {
                Console.Write("Có thẻ sinh viên hợp lệ không? (true/false): ");
                coTheSV = bool.Parse(Console.ReadLine());
            }

            Console.WriteLine("Chọn ngày xem phim: 1-Thứ2 2-Thứ3 3-Thứ4 4-Thứ5 5-Thứ6 6-Thứ7 7-CN");
            Console.Write("Lựa chọn: "); int chonNgay = int.Parse(Console.ReadLine());

            // Map thủ công số 1-7 sang đúng thứ trong tuần để code rõ ràng, dễ hiểu
            DayOfWeek[] mapNgay = {
                DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday,
                DayOfWeek.Friday, DayOfWeek.Saturday, DayOfWeek.Sunday
            };
            DayOfWeek ngayXem = mapNgay[chonNgay - 1];

            decimal giaGoc = 100000m;
            decimal giamGia = 0m;
            decimal phuThu = 0m;

            if (loaiKhachHang == CustomerType.Child || loaiKhachHang == CustomerType.Senior)
            {
                giamGia = giaGoc * 0.5m; // Giảm 50%
            }
            else if (loaiKhachHang == CustomerType.Student && coTheSV &&
                     (ngayXem == DayOfWeek.Monday || ngayXem == DayOfWeek.Tuesday ||
                      ngayXem == DayOfWeek.Wednesday || ngayXem == DayOfWeek.Thursday))
            {
                giamGia = giaGoc * 0.3m; // Giảm 30% cho SV có thẻ, từ T2-T5
            }
            else if (loaiKhachHang == CustomerType.Adult && ngayXem == DayOfWeek.Wednesday)
            {
                giamGia = giaGoc * 0.2m; // Khuyến mãi Thứ 4 Vui Vẻ cho Adult
            }

            if (ngayXem == DayOfWeek.Friday || ngayXem == DayOfWeek.Saturday || ngayXem == DayOfWeek.Sunday)
            {
                phuThu = 20000m; // Phụ thu cuối tuần
            }

            decimal tongTien = giaGoc - giamGia + phuThu;

            Console.WriteLine($"\nGiá vé gốc: {giaGoc:N0} VNĐ");
            Console.WriteLine($"Giảm giá: -{giamGia:N0} VNĐ");
            Console.WriteLine($"Phụ thu cuối tuần: {phuThu:N0} VNĐ");
            Console.WriteLine($"TỔNG TIỀN VÉ: {tongTien:N0} VNĐ");
        }
    }
}
