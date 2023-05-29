using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using QLCT.BUS;

namespace QLCT.GUI
{
    public partial class frmCapNhatMatKhau : Form
    {
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public frmCapNhatMatKhau()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtXacNhanMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtXacNhanMatKhau.Text == "Xác nhận mật khẩu")
            {
                txtXacNhanMatKhau.Text = "";
                txtXacNhanMatKhau.ForeColor = Color.Black;
            }
        }

        private void txtXacNhanMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtXacNhanMatKhau.Text == "")
            {
                txtXacNhanMatKhau.Text = "Xác nhận mật khẩu";
                txtXacNhanMatKhau.ForeColor = Color.Silver;
            }
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //-------------------------------------------------
        //Kiểm tra mật khẩu
        #region
        private int KiemTraMatKhau()
        {
            int checkMatKhau;
            if (txtMatKhau.Text == "Nhập mật khẩu" || txtMatKhau.Text == "")
            {
                checkMatKhau = -1;
            }
            else
            {
                if (Regex.IsMatch(txtMatKhau.Text, @"[ ]")) //Kiểm tra chứa ký tự cách
                {
                    checkMatKhau = 0;
                }
                else
                {
                    checkMatKhau = 1;
                }
            }
            return checkMatKhau;
        }
        #endregion

        //Kiểm tra xác nhận mật khẩu
        #region
        private int KiemTraXacNhanMatKhau()
        {
            int checkMatKhau;
            if (txtXacNhanMatKhau.Text == "Xác nhận mật khẩu" || txtXacNhanMatKhau.Text == "")
            {
                checkMatKhau = -1;
            }
            else
            {
                if (txtXacNhanMatKhau.Text != txtMatKhau.Text) //Kiểm tra chứa ký tự cách
                {
                    checkMatKhau = 0;
                }
                else
                {
                    checkMatKhau = 1;
                }
            }
            return checkMatKhau;
        }
        #endregion

        private void btnAn_Click(object sender, EventArgs e)
        {
            btnAn.Visible = false;
            btnHienThi.Visible = true;
            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            btnHienThi.Visible = false;
            btnAn.Visible = true;
            txtMatKhau.UseSystemPasswordChar = false;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (KiemTraXacNhanMatKhau() == 1 && KiemTraMatKhau() == 1)
            {
                if (taiKhoanBUS.ThayDoiMatKhau(frmDangNhap.TaiKhoan, txtXacNhanMatKhau.Text))
                {
                    if (MessageBox.Show("Cập nhật mật khẩu thành công\n Bạn có muốn khởi động lại ứng dụng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else
                    {
                        btnHuy_Click(sender, e);
                    }
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
            else if(KiemTraXacNhanMatKhau() == 0)
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Mật khẩu không đúng định dạng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && e.KeyChar > 127)
            {
                e.Handled = true; // Không cho phép ký tự có dấu được nhập
            }
        }
    }
}
