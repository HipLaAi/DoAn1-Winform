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
    public partial class FRMChinhADMIN : Form
    {
        public FRMChinhADMIN()
        {
            InitializeComponent();
        }
        //Làm mới button
        private void RestButton()
        {
            btnThongKe.BackColor = Color.Salmon;
            btnTaiKhoan.BackColor = Color.Salmon;
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

        //-----------------------Sự kiện----------------------------------------------

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            RestButton();
            btnTaiKhoan.BackColor = Color.Brown;
            OpenChildForm(new frmQuanLyTaiKhoan());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            RestButton();
            btnThongKe.BackColor = Color.Brown;
            OpenChildForm(new frmThongKeTaiKhoan());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void FRMChinhADMIN_Load(object sender, EventArgs e)
        {
            btnThongKe_Click(sender, e);
            if (frmDangNhap.SizeForm)
            {
                WindowState = FormWindowState.Maximized;
            }
        }
    }
}
