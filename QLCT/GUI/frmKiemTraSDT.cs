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
using QLCT.BUS;

namespace QLCT.GUI
{
    public partial class frmKiemTraSDT : Form
    {
        public static string kiemTraSDT;
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public frmKiemTraSDT()
        {
            InitializeComponent();
        }
        private void frmKiemTraSDT_Load(object sender, EventArgs e)
        {
            kiemTraSDT = "";
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            kiemTraSDT = "Hủy";
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string sDt = mtxtSDT.Text.Replace("-", "").Replace(" ", "");
            if (KiemTraSoDienThoai(frmDangNhap.TaiKhoan, sDt))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Số điện thoại liên kết không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //----------------------------------------
        private bool KiemTraSoDienThoai(string taiKhoan,string sDT)
        {
            return taiKhoanBUS.QuenMatKhau(taiKhoan, sDT);
        }
    }
}
