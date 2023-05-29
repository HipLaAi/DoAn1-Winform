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
    public partial class frmQuenMatKhau : Form
    {
        public frmQuenMatKhau()
        {
            InitializeComponent();
        }
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();

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

        private void txtSoDienThoai_Enter(object sender, EventArgs e)
        {
            if (txtSoDienThoai.Text == "Nhập số điện thoại")
            {
                txtSoDienThoai.Text = "";
                txtSoDienThoai.ForeColor = Color.Black;
            }
        }


        private void txtSoDienThoai_Leave(object sender, EventArgs e)
        {
            if (txtSoDienThoai.Text == "")
            {
                txtSoDienThoai.Text = "Nhập số điện thoại";
                txtSoDienThoai.ForeColor = Color.Silver;
            }
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSoDienThoai.Text.Length <= 15 || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                errorSoDienThoai.Clear();
                btnSoDienThoai.FlatAppearance.BorderSize = 0;
            }
            else
            {
                e.Handled = true;
                errorSoDienThoai.SetError(btnSoDienThoai, "Quá ký tự cho phép");
                btnSoDienThoai.FlatAppearance.BorderSize = 2;
            }
        }

        //Kiểm tra tài khoản
        #region
        private int KiemTraTaiKhoan()
        {
            int checkTaiKhoan;
            if (txtTaiKhoan.Text == "Nhập tên đăng nhập" || txtTaiKhoan.Text == "") //Kiểm tra rỗng
            {
                btnTaiKhoan.FlatAppearance.BorderSize = 2;
                errorTaiKhoan.SetError(btnTaiKhoan, "Vui lòng không để trống");
                checkTaiKhoan = -1;
            }
            else
            {
                if (Regex.IsMatch(txtTaiKhoan.Text, @"[!@#$%^&*()+{}| :""<>,.?/'[\]\\`~-]") || char.IsDigit(txtTaiKhoan.Text[0])) //Kiểm tra chứa ký tự đạc biệt và kiểm tra ký tự đầu khác số
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

        //Kiểm tra số điện thoại
        #region
        int checkSoDienThoai;
        private int KiemTraSoDienThoai()
        {
            if (txtSoDienThoai.Text == "Nhập số điện thoại" || txtSoDienThoai.Text == "") //Kiểm tra rỗng
            {
                btnSoDienThoai.FlatAppearance.BorderSize = 2;
                errorSoDienThoai.SetError(btnSoDienThoai, "Vui lòng không để trống");
                checkSoDienThoai = -1;
            }
            else
            {
                //kiểm tra ký tự là số
                long so;
                if (long.TryParse(txtSoDienThoai.Text, out so))
                {
                    btnSoDienThoai.FlatAppearance.BorderSize = 0;
                    checkSoDienThoai = 1;
                }
                else
                {
                    btnSoDienThoai.FlatAppearance.BorderSize = 2;
                    errorSoDienThoai.SetError(btnSoDienThoai, "Lỗi định dạng");
                    checkSoDienThoai = 0;
                }
            }
            return checkSoDienThoai;
        }
        #endregion

        // Thêm Form
        #region
        private Form CrrentformChild;
        private void OpenChildForm(Form formchild)
        {
            if (CrrentformChild != null)
            {
                CrrentformChild.Close();
            }
            CrrentformChild = formchild;
            formchild.TopLevel = false;
            formchild.FormBorderStyle = FormBorderStyle.None;
            formchild.Dock = DockStyle.Fill;
            pnlThan.Controls.Add(formchild);
            pnlThan.Tag = formchild;
            formchild.BringToFront();
            formchild.Show();
        }
        #endregion

        public static string taiKhoan;
        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
            errorTaiKhoan.Clear();
            errorSoDienThoai.Clear();
            if (KiemTraSoDienThoai() == 1 && KiemTraTaiKhoan() == 1)
            {
                if (taiKhoanBUS.QuenMatKhau(txtTaiKhoan.Text, txtSoDienThoai.Text))
                {
                    taiKhoan = txtTaiKhoan.Text;
                    OpenChildForm(new frmThayMatKhau()); 
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (KiemTraTaiKhoan() == -1 || KiemTraSoDienThoai() == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin tài khoản, số điện thoại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Lỗi định dạng tài khoản hoặc số điện thoại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //Check Size Form
        private void frmQuenMatKhau_Load(object sender, EventArgs e)
        {
            if (frmDangNhap.SizeForm)
            {
                WindowState = FormWindowState.Maximized;
            }
        }
    }
}
