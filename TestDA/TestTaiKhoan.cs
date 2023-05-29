using NUnit.Framework;
using QLCT.GUI;
using QLCT.DAO;
using QLCT;

namespace TestDA
{
    public class Tests
    {
        [Test]
        public void TestDangNhapWithValidCredentials()
        {
            TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();

            string taiKhoan = "Hiep";
            string matKhau = "vuvanhiep";
            string loaiTaiKhoan = "USER";

            bool result = taiKhoanDAO.DangNhap(taiKhoan, matKhau, loaiTaiKhoan);

            Assert.IsTrue(result);
        }

        [Test]
        public void TestDangNhapWithInvalidCredentials()
        {
            TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();

            string taiKhoan = "Hiep";
            string matKhau = "khongbiet";
            string loaiTaiKhoan = "USER";

            bool result = taiKhoanDAO.DangNhap(taiKhoan, matKhau, loaiTaiKhoan);

            Assert.IsFalse(result);
        }

        [Test]
        public void QuenMatKhau_ExistingAccount_ReturnsTrue()
        {
            TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();

            var taiKhoan = "Hiep";
            var soDienThoai = "0901519038";

            var result = taiKhoanDAO.QuenMatKhau(taiKhoan, soDienThoai);

            Assert.IsTrue(result);
        }

        [Test]
        public void QuenMatKhau_NonExistingAccount_ReturnsFalse()
        {
            TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();

            var taiKhoan = "Hien";
            var soDienThoai = "0901519038";

            var result = taiKhoanDAO.QuenMatKhau(taiKhoan, soDienThoai);

            Assert.IsFalse(result);
        }

        [Test]
        public void ThayDoiMatKhau_ExistingAccount_ReturnsTrue()
        {
            TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();

            var taiKhoan = "Hien";
            var matKhauMoi = "trieuquanghien";

            var result = taiKhoanDAO.ThayDoiMatKhau(taiKhoan, matKhauMoi);

            Assert.IsTrue(result);
        }

        [Test]
        public void ThayDoiMatKhau_NonExistingAccount_ReturnsFalse()
        {
            TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();

            var taiKhoan = "Yen";
            var matKhauMoi = "vuquangyen";

            var result = taiKhoanDAO.ThayDoiMatKhau(taiKhoan, matKhauMoi);

            Assert.IsFalse(result);
        }

        [Test]
        public void CapNhatTaiKhoan_ExistingAccount_ReturnsTrue()
        {
            TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();

            var taiKhoan = "Hiep";
            var hoTen = "Vũ Văn Hiệp";
            var gioiTinh = "Nam";
            var sDt = "0901519038";
            var diaChi = "Hưng Yên";
            var ngaySinh = new System.DateTime(2003, 5, 9);

            var result = taiKhoanDAO.CapNhatTaiKhoan(taiKhoan, hoTen, gioiTinh, sDt, diaChi, ngaySinh);

            Assert.IsTrue(result);
        }

        [Test]
        public void CapNhatTaiKhoan_NonExistingAccount_ReturnsFalse()
        {
            TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
            var taiKhoan = "non_existing_account";
            var hoTen = "Jane Smith";
            var gioiTinh = "Female";
            var sDt = "987654321";
            var diaChi = "456  HY";
            var ngaySinh = new System.DateTime(1990, 1, 1);

            var result = taiKhoanDAO.CapNhatTaiKhoan(taiKhoan, hoTen, gioiTinh, sDt, diaChi, ngaySinh);

            Assert.IsFalse(result);
        }

        [Test]
        public void ThongTinTaiKhoan_ExistingAccount_ReturnsDataTable()
        {
            TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();

            var taiKhoan = "Hiep";

            var result = taiKhoanDAO.ThongTinTaiKhoan(taiKhoan);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Rows.Count > 0);
        }

        [Test]
        public void ThongTinTaiKhoan_NonExistingAccount_ReturnsEmptyDataTable()
        {
            TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
            // Arrange
            var taiKhoan = "Yen";

            // Act
            var result = taiKhoanDAO.ThongTinTaiKhoan(taiKhoan);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Rows.Count == 0);
        }       
    }
}