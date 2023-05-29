using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using QLCT.BUS;
using QLCT.DTO;

namespace QLCT.GUI
{
    public partial class frmDangKy : Form
    {
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        public frmDangKy()
        {
            InitializeComponent();
        }
        private void frmDangKy_Load(object sender, EventArgs e)
        {
            cboTinh.DataSource = DanhSachTinhThanh;
            InitializeDanhSachHuyen();
            cboTinh.SelectedItem = "TP Hà Nội";
            cboTinh_SelectedIndexChanged(sender, e);
            if (frmDangNhap.SizeForm)
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void txtHoTen_Enter(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "Nhập họ tên")
            {
                txtHoTen.Text = "";
                txtHoTen.ForeColor = Color.Black;
            }
        }

        private void txtHoTen_Leave(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "")
            {
                txtHoTen.Text = "Nhập họ tên";
                txtHoTen.ForeColor = Color.Silver;
            }
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || txtHoTen.Text.Length <= 15 || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                errorHoTen.Clear();
                btnHoTen.FlatAppearance.BorderSize = 0;
            }
            else
            {
                e.Handled = true;
                errorHoTen.SetError(btnHoTen, "Quá ký tự cho phép");
                btnHoTen.FlatAppearance.BorderSize = 2;
            }

            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho ký tự số được nhập vào TextBox
            }
        }

        private void txtTaiKhoan_Enter(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "Nhập tên đăng nhập")
            {
                txtTaiKhoan.Text = "";
                txtTaiKhoan.ForeColor = Color.Black;
            }
        }

        private void txtTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "")
            {
                txtTaiKhoan.Text = "Nhập tên đăng nhập";
                txtTaiKhoan.ForeColor = Color.Silver;
            }
        }

        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtTaiKhoan.Text.Length <= 20 || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                errorTaiKhoan.Clear();
                btnTaiKhoan.FlatAppearance.BorderSize = 0;
            }
            else
            {
                e.Handled = true;
                errorTaiKhoan.SetError(btnTaiKhoan, "Quá ký tự cho phép");
                btnTaiKhoan.FlatAppearance.BorderSize = 2;
            }

            if (char.IsLetter(e.KeyChar) && e.KeyChar > 127)
            {
                e.Handled = true; // Không cho phép ký tự có dấu được nhập
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Nhập mật khẩu")
            {
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black;
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.Text = "Nhập mật khẩu";
                txtMatKhau.ForeColor = Color.Silver;
            }
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtMatKhau.Text.Length <= 20 || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                errorMatKhau.Clear();
                btnMatKhau.FlatAppearance.BorderSize = 0;
            }
            else
            {
                e.Handled = true;
                errorMatKhau.SetError(btnMatKhau, "Quá ký tự cho phép");
                btnMatKhau.FlatAppearance.BorderSize = 2;
            }

            if (char.IsLetter(e.KeyChar) && e.KeyChar > 127)
            {
                e.Handled = true; // Không cho phép ký tự có dấu được nhập
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            btnAn.Visible = true;
            btnHienThi.Visible = false;
            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void btnAn_Click(object sender, EventArgs e)
        {
            btnAn.Visible = false;
            btnHienThi.Visible = true;
            txtMatKhau.UseSystemPasswordChar = false;
        }

        string gioiTinh = string.Empty;

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string sDt = mtxtSDT.Text.Replace("-", "").Replace(" ", "");
            errorHoTen.Clear();
            errorGioiTinh.Clear();
            errorNgaySinh.Clear();
            errorSDT.Clear();
            errorDiaChi.Clear();
            errorTaiKhoan.Clear();
            errorMatKhau.Clear();
            KiemTraHoTen(txtHoTen.Text);
            KiemTraGioiTinh();
            KiemTraNgaySinh(dtpNgaySinh.Value);
            KiemTraSoDienThoai(sDt);
            KiemTraDiaChi(cboTinh.Text, cboHuyen.Text);
            KiemTraTaiKhoan(txtTaiKhoan.Text);
            KiemTraMatKhau(txtMatKhau.Text);
            if (KiemTraMatKhau(txtMatKhau.Text) == 1 && KiemTraTaiKhoan(txtTaiKhoan.Text) == 1 && KiemTraHoTen(txtHoTen.Text) == 1 && KiemTraGioiTinh() == 1 && KiemTraNgaySinh(dtpNgaySinh.Value) == 1 && KiemTraSoDienThoai(mtxtSDT.Text) == 1 && KiemTraDiaChi(cboTinh.Text, cboHuyen.Text) == 1)
            {
                string diaChi = cboHuyen.Text + "-" + cboTinh.Text;
                if (taiKhoanBUS.DangKy(txtTaiKhoan.Text, txtMatKhau.Text, txtHoTen.Text, gioiTinh, sDt, diaChi,dtpNgaySinh.Value ,"USER"))
                {
                    MessageBox.Show("Đăng ký tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại vui lòng chọn tên đăng nhập khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (KiemTraMatKhau(txtMatKhau.Text) == -1 || KiemTraTaiKhoan(txtTaiKhoan.Text) == -1 || KiemTraHoTen(txtHoTen.Text) == -1 || KiemTraGioiTinh() == -1 || KiemTraNgaySinh(dtpNgaySinh.Value) == -1 || KiemTraSoDienThoai(mtxtSDT.Text) == -1 || KiemTraDiaChi(cboTinh.Text, cboHuyen.Text) == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Lỗi định dạng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTinhThanh = cboTinh.SelectedItem.ToString();

            // Kiểm tra xem có danh sách huyện/quận cho tỉnh/thành phố đã chọn hay không
            if (DanhSachHuyen.ContainsKey(selectedTinhThanh))
            {
                List<string> DanhSachhuyen = DanhSachHuyen[selectedTinhThanh];

                // Cập nhật danh sách huyện/quận cho ComboBox huyện/quận
                cboHuyen.DataSource = DanhSachhuyen;
            }
            else
            {
                // Nếu không có danh sách huyện/quận, xóa danh sách hiện tại của ComboBox huyện/quận
                cboHuyen.DataSource = null;
            }
        }


        //--------------------------------------------------------------
        //Kiểm tra mật khẩu
        #region
        public int KiemTraMatKhau(string matKhau)
        {
            int checkMatKhau;
            if (matKhau == "Nhập mật khẩu" || matKhau == "")
            {
                btnMatKhau.FlatAppearance.BorderSize = 2;
                errorMatKhau.SetError(btnMatKhau, "Vui lòng không để trống");
                checkMatKhau = -1;
            }
            else
            {
                if (Regex.IsMatch(matKhau, @"[ ]")) //Kiểm tra chứa ký tự cách
                {
                    btnMatKhau.FlatAppearance.BorderSize = 2;
                    errorMatKhau.SetError(btnMatKhau, "Lỗi định dạng");
                    checkMatKhau = 0;
                }
                else
                {
                    btnMatKhau.FlatAppearance.BorderSize = 0;
                    checkMatKhau = 1;
                }
            }
            return checkMatKhau;
        }
        #endregion

        //Kiểm tra tài khoản
        #region
        public int KiemTraTaiKhoan(string taiKhoan)
        {
            int checkTaiKhoan;
            if (taiKhoan == "Nhập tên đăng nhập" || taiKhoan == "") //Kiểm tra rỗng
            {
                btnTaiKhoan.FlatAppearance.BorderSize = 2;
                errorTaiKhoan.SetError(btnTaiKhoan, "Vui lòng không để trống");
                checkTaiKhoan = -1;
            }
            else
            {
                if (Regex.IsMatch(taiKhoan, @"[!@#$%^&*()+{}| :""<>,.?/'[\]\\`~-]") || char.IsDigit(taiKhoan[0])) //Kiểm tra chứa ký tự đạc biệt và kiểm tra ký tự đầu khác số
                {
                    btnTaiKhoan.FlatAppearance.BorderSize = 2;
                    errorTaiKhoan.SetError(btnTaiKhoan, "Lỗi định dạng");
                    checkTaiKhoan = 0;
                }
                else
                {
                    btnTaiKhoan.FlatAppearance.BorderSize = 0;
                    checkTaiKhoan = 1;
                }
            }
            return checkTaiKhoan;
        }
        #endregion

        //Kiểm tra họ tên
        #region
        public int KiemTraHoTen(string hoTen)
        {
            int checkHoTen;
            if (hoTen == "Nhập họ tên" || hoTen == "") //Kiểm tra rỗng
            {
                btnHoTen.FlatAppearance.BorderSize = 2;
                errorHoTen.SetError(btnHoTen, "Vui lòng không để trống");
                checkHoTen = -1;
            }
            else
            {
                if (Regex.IsMatch(hoTen, @"[1234567890!@#$%^&*()+{}|:""<>,.?/'[\]\\`~-]")) //Kiểm tra chứa ký tự đạc biệt và số không
                {
                    btnHoTen.FlatAppearance.BorderSize = 2;
                    errorHoTen.SetError(btnHoTen, "Lỗi định dạng");
                    checkHoTen = 0;
                }
                else
                {
                    btnHoTen.FlatAppearance.BorderSize = 0;
                    checkHoTen = 1;
                }
            }
            return checkHoTen;
        }
        #endregion

        //Kiểm tra sdt
        #region
        public int KiemTraSoDienThoai(string sdt)
        {
            int checkSDT;
            if (string.IsNullOrEmpty(sdt))
            {
                errorSDT.SetError(btnSDT, "Vui lòng không để trống");
                checkSDT = -1;
            }
            else
            {
                checkSDT = 1;
            }
            return checkSDT;
        }
        #endregion

        //Kiểm tra dia chi
        #region
        public int KiemTraDiaChi(string tinh, string huyen)
        {
            int checkDiaChi;
            if (tinh == "" || huyen == "") //Kiểm tra rỗng
            {
                errorDiaChi.SetError(cboHuyen, "Vui lòng không để trống");
                checkDiaChi = -1;
            }
            else
            {
                checkDiaChi = 1;
            }
            return checkDiaChi;
        }
        #endregion

        //Kiểm tra ngay sinh
        #region
        public int KiemTraNgaySinh(DateTime ngaySinh)
        {
            int checkNgaySinh;
            if (ngaySinh.Day == DateTime.Now.Day && ngaySinh.Month == DateTime.Now.Month && ngaySinh.Year == DateTime.Now.Year) //Kiểm tra rỗng
            {
                errorNgaySinh.SetError(dtpNgaySinh, "Vui lòng chọn lại ngày sinh phù hợp");
                checkNgaySinh = -1;
            }
            else
            {
                checkNgaySinh = 1;
            }
            return checkNgaySinh;
        }
        #endregion

        //Kiểm tra gioi tinh
        #region
        public int KiemTraGioiTinh()
        {
            int checkGioiTinh;

            if (rdbNam.Checked)
            {
                gioiTinh = rdbNam.Text;
                checkGioiTinh = 1;
            }
            else if (rdbNu.Checked)
            {
                gioiTinh = rdbNu.Text;
                checkGioiTinh = 1;
            }
            else
            {
                checkGioiTinh = -1;
                errorGioiTinh.SetError(pnlGioiTinh, "Vui lòng không để trống");
            }
            return checkGioiTinh;
        }
        #endregion

        //Danh sách tỉnh thành
        public List<string> DanhSachTinhThanh = new List<string>
        {
            "TP Hà Nội",
            "Hải Dương",
            "Hải Phòng",
            "Hưng Yên",
            "Ninh Bình",
            "Phú Thọ",
            "Thái Bình",
            "TP Hồ Chí Minh"
        };

        public Dictionary<string, List<string>> DanhSachHuyen = new Dictionary<string, List<string>>();

        //Danh sách huyện
        public void InitializeDanhSachHuyen()
        {
            DanhSachHuyen.Add("TP Hà Nội", new List<string> { "Đan Phượng", "Gia Lâm", "Đông Anh", "Chương Mỹ", "Hoài Đức", "Ba Vì", "Mỹ Đức", "Phúc Thọ", "Thạch Thất", "Quốc Oai", "Thanh Trì", "Thường Tín", "Thanh Oai", "Phú Xuyên", "Mê Linh", "Sóc Sơn", "Ứng Hòa", "Sơn Tây" });
            DanhSachHuyen.Add("Hải Dương", new List<string> { "Bình Giang", "Cẩm Giàng", "Gia Lộc", "Kim Thành", "Kinh Môn", "Nam Sách", "Ninh Giang", "Thanh Hà", "Thanh Miện", "Tứ Kỳ", "Chí Linh", "TP Hải Dương" });
            DanhSachHuyen.Add("Hải Phòng", new List<string> { "Hồng Bàng", "Lê Chân", "Ngô Quyền", "Kiến An", "Hải An", "Đồ Sơn", "Dương Kinh", "An Dương", "An Lão", "Kiến Thụy", "Tiên Lãng", "Thuỷ Nguyên", "Vĩnh Bảo", "Bạch Long Vĩ", "Cát Hải" });
            DanhSachHuyen.Add("Hưng Yên", new List<string> { "Ân Thi", "Mỹ Hào", "Tiên Lữ", "Phù Cừ", "Yên Mỹ", "Kim Động", "Văn Giang", "Văn Lâm", "Khoái Châu" });
            DanhSachHuyen.Add("Ninh Bình", new List<string> { "TP Ninh Bình", "Tam Điệp", "Gia Viễn", "Hoa Lư", "Kim Sơn", "Nho Quan", "Yên Khánh", "Yên Mô" });
            DanhSachHuyen.Add("Phú Thọ", new List<string> { "Hạ Hòa", "Đoan Hùng", "Thanh Ba", "Phù Ninh", "Lâm Thao", "Tam Nông", "Thanh Thủy", "Cẩm Khê", "Yên Lập", "Thanh Sơn", "Tân Sơn" });
            DanhSachHuyen.Add("Thái Bình", new List<string> { "Hưng Hà", "Đông Hưng", "Quỳnh Phụ", "Thái Thụy", "Tiền Hải", "Kiến Xương", "Vũ Thư", "TP Thái Bình"});
            DanhSachHuyen.Add("TP Hồ Chí Minh", new List<string> { "TP Thủ Đức", "Quận 1", "Quận 2", "Quận 3", "Quận 4", "Quận 5", "Quận 6", "Quận 7", "Quận 8", "Quận 9", "Quận 10", "Quận 11", "Quận 12"});
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}