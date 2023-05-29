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
    public partial class frmThayMatKhau : Form
    {
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        public frmThayMatKhau()
        {
            InitializeComponent();
        }

        private void txtMatKhauMoi_Enter(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Text == "Nhập mật khẩu")
            {
                txtMatKhauMoi.Text = "";
                txtMatKhauMoi.ForeColor = Color.Black;
            }
        }

        private void txtMatKhauMoi_Leave(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Text == "")
            {
                txtMatKhauMoi.Text = "Nhập mật khẩu";
                txtMatKhauMoi.ForeColor = Color.Silver;
            }
        }

        //Kiểm tra mật khẩu
        #region
        private int KiemTraMatKhau()
        {
            int checkMatKhau;
            if (txtMatKhauMoi.Text == "Nhập mật khẩu" || txtMatKhauMoi.Text == "")
            {
                btnMatKhauMoi.FlatAppearance.BorderSize = 2;
                errorMatKhauMoi.SetError(btnMatKhauMoi, "Vui lòng không để trống");
                checkMatKhau = -1;
            }
            else
            {
                if (Regex.IsMatch(txtMatKhauMoi.Text, @"[ ]")) //Kiểm tra chứa ký tự cách
                {
                    btnMatKhauMoi.FlatAppearance.BorderSize = 2;
                    errorMatKhauMoi.SetError(btnMatKhauMoi, "Lỗi định dạng");
                    checkMatKhau = 0;
                }
                else
                {
                    btnMatKhauMoi.FlatAppearance.BorderSize = 0;
                    checkMatKhau = 1;
                }
            }
            return checkMatKhau;
        }
        #endregion

        private void txtXacNhanMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtXacNhanMatKhau.Text == "Xác nhận lại mật khẩu")
            {
                txtXacNhanMatKhau.Text = "";
                txtXacNhanMatKhau.ForeColor = Color.Black;
            }
        }

        private void txtXacNhanMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtXacNhanMatKhau.Text == "")
            {
                txtXacNhanMatKhau.Text = "Xác nhận lại mật khẩu";
                txtXacNhanMatKhau.ForeColor = Color.Silver;
            }
        }

        //Kiểm tra xác nhận mật khẩu
        #region
        private int KiemTraXacNhanMatKhau()
        {
            int checkMatKhau;
            if (txtXacNhanMatKhau.Text == "Xác nhận lại mật mật khẩu" || txtXacNhanMatKhau.Text == "")
            {
                btnXacNhanMatKhau.FlatAppearance.BorderSize = 2;
                errorXacNhanMatKhau.SetError(btnXacNhanMatKhau, "Vui lòng không để trống");
                checkMatKhau = -1;
            }
            else
            {
                if (txtXacNhanMatKhau.Text != txtMatKhauMoi.Text) //Kiểm tra chứa ký tự cách
                {
                    btnXacNhanMatKhau.FlatAppearance.BorderSize = 2;
                    errorXacNhanMatKhau.SetError(btnXacNhanMatKhau, "Mật khẩu xác nhận không khớp");
                    checkMatKhau = 0;
                }
                else
                {
                    btnXacNhanMatKhau.FlatAppearance.BorderSize = 0;
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
            txtMatKhauMoi.UseSystemPasswordChar = true;
        }

        private void btnAn_Click(object sender, EventArgs e)
        {
            btnAn.Visible = false;
            btnHienThi.Visible = true;
            txtMatKhauMoi.UseSystemPasswordChar = false;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            errorMatKhauMoi.Clear();
            errorXacNhanMatKhau.Clear();
            if (KiemTraXacNhanMatKhau() == 1 && KiemTraMatKhau() == 1)
            {
                if (taiKhoanBUS.ThayDoiMatKhau(frmQuenMatKhau.taiKhoan,txtMatKhauMoi.Text))
                {
                    MessageBox.Show("Thay đổi mật khẩu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Thay đổi mật khẩu không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (KiemTraMatKhau() == -1 || KiemTraXacNhanMatKhau() == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Lỗi định dạng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMatKhauMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtMatKhauMoi.Text.Length <= 20 || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                errorMatKhauMoi.Clear();
                btnMatKhauMoi.FlatAppearance.BorderSize = 0;
            }
            else
            {
                e.Handled = true;
                errorMatKhauMoi.SetError(btnMatKhauMoi, "Quá ký tự cho phép");
                btnMatKhauMoi.FlatAppearance.BorderSize = 2;
            }

            if (char.IsLetter(e.KeyChar) && e.KeyChar > 127)
            {
                e.Handled = true; // Không cho phép ký tự có dấu được nhập
            }
        }

        private void txtXacNhanMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtXacNhanMatKhau.Text.Length <= 20 || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                errorXacNhanMatKhau.Clear();
                btnXacNhanMatKhau.FlatAppearance.BorderSize = 0;
            }
            else
            {
                e.Handled = true;
                errorMatKhauMoi.SetError(btnXacNhanMatKhau, "Quá ký tự cho phép");
                btnXacNhanMatKhau.FlatAppearance.BorderSize = 2;
            }

            if (char.IsLetter(e.KeyChar) && e.KeyChar > 127)
            {
                e.Handled = true; // Không cho phép ký tự có dấu được nhập
            }
        }
    }
}
