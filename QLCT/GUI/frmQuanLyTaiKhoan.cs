using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCT.BUS;

namespace QLCT.GUI
{
    public partial class frmQuanLyTaiKhoan : Form
    {
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        //Load Du Lieu
        private void Data_Load()
        {
            cboTinh.DataSource = DanhSachTinhThanh;
            cboGioiTinh.DataSource = DanhSachGioiTinh;
            if (cboGioiTinh.Text == "Tất cả" && cboTinh.Text == "Tất cả")
            {
                dgvTaiKhoan.DataSource = taiKhoanBUS.DanhSachTaiKhoanTheoLuaChon(txtTenDangNhap.Text, "Nam", "Nữ", "");
            }
            else if(cboGioiTinh.Text == "Tất cả")
            {
                dgvTaiKhoan.DataSource = taiKhoanBUS.DanhSachTaiKhoanTheoLuaChon(txtTenDangNhap.Text, "Nam", "Nữ", cboTinh.Text);
            }
            else if (cboTinh.Text == "Tất cả")
            {
                dgvTaiKhoan.DataSource = taiKhoanBUS.DanhSachTaiKhoanTheoLuaChon(txtTenDangNhap.Text, cboGioiTinh.Text, cboGioiTinh.Text, "");
            }
            else
            {
                dgvTaiKhoan.DataSource = taiKhoanBUS.DanhSachTaiKhoanTheoLuaChon(txtTenDangNhap.Text, cboGioiTinh.Text, cboGioiTinh.Text, cboTinh.Text);
            }
        }

        //Xoa Du Lieu
        private void XoaDuLieu()
        {
            string taiKhoan = string.Empty;
            DataTable dataTable = (DataTable)dgvTaiKhoan.DataSource;
            if (dgvTaiKhoan.CurrentRow != null)
            {
                DataRow dataRow;
                dataRow = dataTable.Rows[dgvTaiKhoan.CurrentRow.Index];
                if (dataRow != null)
                {
                    if (dgvTaiKhoan.Rows[dgvTaiKhoan.CurrentRow.Index].Cells["TenDangNhap"].Value != null || dgvTaiKhoan.Rows[dgvTaiKhoan.CurrentRow.Index].Cells["TenDangNhap"].Value.ToString() != "")
                    {
                        taiKhoan = dgvTaiKhoan.Rows[dgvTaiKhoan.CurrentRow.Index].Cells["TenDangNhap"].Value.ToString();
                        taiKhoanBUS.XoaTaiKhoan(taiKhoan);
                    }
                }
            }
        }

        //Danh sách tỉnh thành
        public List<string> DanhSachTinhThanh = new List<string>
        {
            "Tất cả",
            "TP Hà Nội",
            "Hải Dương",
            "Hải Phòng",
            "Hưng Yên",
            "Ninh Bình",
            "Phú Thọ",
            "Thái Bình",
            "TP Hồ Chí Minh"
        };

        //Danh sách giới tính
        public List<string> DanhSachGioiTinh = new List<string>
        {
            "Tất cả",
            "Nam",
            "Nữ",
        };


        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            Data_Load();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa tài khoản này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                XoaDuLieu();
                Data_Load();
            }
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            Data_Load();
        }

        private void cboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            Data_Load();
        }

        private void cboTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            Data_Load();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboTinh.SelectedIndex = 0;
            cboGioiTinh.SelectedIndex = 0;
            txtTenDangNhap.Text = "";
            Data_Load();
        }

        private void txtTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra ký tự đặc biệt
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false; // Không cho phép ký tự được nhập
            }
            else
            {
                e.Handled = true;
            }


            if (char.IsLetter(e.KeyChar) && e.KeyChar > 127)
            {
                e.Handled = true; // Không cho phép ký tự có dấu được nhập
            }
        }
    }
}
