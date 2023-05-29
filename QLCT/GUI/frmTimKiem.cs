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
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
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

        private void RestButton()
        {
            btnGiaoDichChi.BackColor = Color.Gainsboro;
            btnGiaoDichThu.BackColor = Color.Gainsboro;
        }
        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            btnGiaoDichChi_Click(sender, e);
        }

        private void btnGiaoDichChi_Click(object sender, EventArgs e)
        {
            RestButton();
            btnGiaoDichChi.BackColor = Color.White;
            OpenChildForm(new frmTimKiemGiaoDichChi());
        }

        private void btnGiaoDichThu_Click(object sender, EventArgs e)
        {
            RestButton();
            btnGiaoDichThu.BackColor = Color.White;
            OpenChildForm(new frmTimKiemGiaoDichThu());
        }
    }
}
