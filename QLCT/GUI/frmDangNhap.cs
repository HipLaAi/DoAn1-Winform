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

namespace QLCT.GUI
{
    public partial class frmDangNhap : Form
    {
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        public static string TaiKhoan = string.Empty;
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public static bool SizeForm = false;

        private void frmDangNhap_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                SizeForm = true;
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            cboLoaiTaiKhoan.SelectedIndex = 0;
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

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            errorTaiKhoan.Clear();
            errorMatKhau.Clear();
            if (KiemTraMatKhau(txtMatKhau.Text) == 1 && KiemTraTaiKhoan(txtTaiKhoan.Text) == 1)
            {
                if (taiKhoanBUS.DangNhap(txtTaiKhoan.Text, txtMatKhau.Text, cboLoaiTaiKhoan.Text))
                {
                    if(cboLoaiTaiKhoan.Text == "USER")
                    {
                        TaiKhoan = txtTaiKhoan.Text;
                        this.Hide();
                        FRMChinh frmChinh = new FRMChinh();
                        frmChinh.Show();
                    }
                    else
                    {
                        this.Hide();
                        FRMChinhADMIN fRMChinhADMIN = new FRMChinhADMIN();
                        fRMChinhADMIN.Show();
                    }    
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (KiemTraTaiKhoan(txtTaiKhoan.Text) == -1 || KiemTraMatKhau(txtMatKhau.Text) == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin tài khoản, mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Lỗi định dạng tài khoản hoặc mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llbQuenMatKhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuenMatKhau frmQuenMatKhau = new frmQuenMatKhau();
            frmQuenMatKhau.Show();
        }

        private void llbDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangKy frmDangKy = new frmDangKy();
            frmDangKy.Show();
        }
    }
}