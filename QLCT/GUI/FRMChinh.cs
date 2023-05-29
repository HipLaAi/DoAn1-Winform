using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCT.GUI
{
    public partial class FRMChinh : Form
    {
        public FRMChinh()
        {
            InitializeComponent();
        }

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

        // Cài đặt thời gian thông báo
        private void SetTime()
        {
            DateTime currentTime = DateTime.Now;
            DateTime setTime = dtpThoiGian.Value;
            int time = (((setTime.Hour - currentTime.Hour) * (60 * 60 * 1000)) + ((setTime.Minute - currentTime.Minute) * (60 * 1000)) + ((setTime.Second - currentTime.Second) * (1000)));
            if (time > 0)
            {
                tmThongBao.Interval = time;
                tmThongBao.Start();
            }
        }

        //Làm mới button
        private void RestButton()
        {
            btnTrangChu.BackColor = Color.LightGreen;
            btnTimKiem.BackColor = Color.LightGreen;
            btnThongKe.BackColor = Color.LightGreen;
            btnTaiKhoan.BackColor = Color.LightGreen;
        }

        //-----------------------Sự kiện----------------------------------------------
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            RestButton();
            btnTrangChu.BackColor = Color.MediumSeaGreen;
            OpenChildForm(new frmTrangChu());
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            RestButton();
            btnTimKiem.BackColor = Color.MediumSeaGreen;
            OpenChildForm(new frmTimKiem());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            RestButton();
            btnThongKe.BackColor = Color.MediumSeaGreen;
            OpenChildForm(new frmThongKe());
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            RestButton();
            btnTaiKhoan.BackColor = Color.MediumSeaGreen;
            OpenChildForm(new frmTaiKhoan());
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            btnTrangChu_Click(sender, e);
            SetTime();
            if (frmDangNhap.SizeForm)
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void tmThongBao_Tick(object sender, EventArgs e)
        {
            if (!ckbThongBao.Checked)
                return;
            notifyIcon.ShowBalloonTip(10000, "Thông báo", "Hôm nay bạn đã thêm cuộc giao dịch nào chưa", ToolTipIcon.None);
            tmThongBao.Stop();
            ckbThongBao.Checked = false;
        }

        private void dtpThoiGian_ValueChanged(object sender, EventArgs e)
        {
            SetTime();
        }
    }
}
