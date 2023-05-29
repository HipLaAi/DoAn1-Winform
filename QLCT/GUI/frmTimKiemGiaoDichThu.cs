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
using QLCT.DTO;

namespace QLCT.GUI
{
    public partial class frmTimKiemGiaoDichThu : Form
    {
        GiaoDichThuBUS giaoDichThuBUS = new GiaoDichThuBUS();
        public frmTimKiemGiaoDichThu()
        {
            InitializeComponent();
        }

        //Lay ngay dau tien trong thang
        private void LayNgayDauTienCuaThang()
        {
            DateTime ngayDauTien = dtpBatDau.Value;
            DateTime firstDayOfMonth = new DateTime(ngayDauTien.Year, ngayDauTien.Month, 1);
            dtpBatDau.Value = firstDayOfMonth;
        }

        //Load combobox danh muc tim kiem
        private void CBBDanhMucTimKiem_Load()
        {
            cboDanhMuc.Items.Add("Tất cả");
            foreach (DataRow row in giaoDichThuBUS.DanhSachDanhMucThu().Rows)
            {
                string value = row[1].ToString();
                cboDanhMuc.Items.Add(value);
            }
        }

        //Load CBBDanhMuc
        private void CBBDanhMuc_Load()
        {
            DanhMuc.DataSource = giaoDichThuBUS.DanhSachDanhMucThu();
            DanhMuc.DisplayMember = "TenDanhMuc";
            DanhMuc.ValueMember = "MaDanhMuc";
        }

        //Load CBBPhuongThucThanhToan
        private void CBBPhuongThucThanhToan_Load()
        {
            PhuongThucThanhToan.DataSource = giaoDichThuBUS.DanhSachPhuongThucThanhToan();
            PhuongThucThanhToan.DisplayMember = "TenPhuongThucThanhToan";
            PhuongThucThanhToan.ValueMember = "MaPhuongThucThanhToan";
        }

        //Load data
        private void Data_Load()
        {
            if (cboDanhMuc.Text == "Tất cả")
            {
                dgvGiaoDichThu.DataSource = giaoDichThuBUS.TimKiemAllGiaoDichThu(frmDangNhap.TaiKhoan, dtpBatDau.Value, dtpKetThuc.Value);
            }
            else
            {
                string maGiaoDich = giaoDichThuBUS.ChuyenDoiDanhMuc(cboDanhMuc.Text);
                dgvGiaoDichThu.DataSource = giaoDichThuBUS.TimKiemGiaoDichThu(frmDangNhap.TaiKhoan, maGiaoDich, dtpBatDau.Value, dtpKetThuc.Value);
            }
        }

        //Luu Du Lieu
        private void LuuDuLieu()
        {
            string maGiaoDich = string.Empty;
            string maDanhMuc = string.Empty;
            int soTien = 0;
            string moTa = string.Empty;
            string maPhuongThucThanhToan = string.Empty;
            DateTime ngayGiaoDich = DateTime.Today;

            for (int i = 0; i < dgvGiaoDichThu.Rows.Count; i++)
            {
                if (dgvGiaoDichThu.Rows[i].Cells["MaGiaoDich"].Value != null)
                {
                    maGiaoDich = dgvGiaoDichThu.Rows[i].Cells["MaGiaoDich"].Value.ToString();
                }

                if (dgvGiaoDichThu.Rows[i].Cells["DanhMuc"].Value != null)
                {
                    maDanhMuc = dgvGiaoDichThu.Rows[i].Cells["DanhMuc"].Value.ToString();
                }

                if (dgvGiaoDichThu.Rows[i].Cells["SoTien"].Value != null)
                {
                    if (dgvGiaoDichThu.Rows[i].Cells["SoTien"].Value.ToString() != "")
                    {
                        soTien = int.Parse(dgvGiaoDichThu.Rows[i].Cells["SoTien"].Value.ToString());
                    }
                    else
                    {
                        soTien = 0;
                    }
                }

                if (dgvGiaoDichThu.Rows[i].Cells["MoTa"].Value != null)
                {
                    moTa = dgvGiaoDichThu.Rows[i].Cells["MoTa"].Value.ToString();
                }

                if (dgvGiaoDichThu.Rows[i].Cells["PhuongThucThanhToan"].Value != null)
                {
                    maPhuongThucThanhToan = dgvGiaoDichThu.Rows[i].Cells["PhuongThucThanhToan"].Value.ToString();
                }


                if (dgvGiaoDichThu.Rows[i].Cells["NgayGiaoDich"].Value != null)
                {
                    if (dgvGiaoDichThu.Rows[i].Cells["NgayGiaoDich"].Value.ToString() != "")
                    {
                        ngayGiaoDich = DateTime.Parse(dgvGiaoDichThu.Rows[i].Cells["NgayGiaoDich"].Value.ToString());
                    }
                }

                GiaoDichDTO giaoDich = new GiaoDichDTO(maGiaoDich, maDanhMuc, maPhuongThucThanhToan, soTien, moTa, ngayGiaoDich);
                giaoDichThuBUS.CapNhapGiaoDichThu(giaoDich, frmDangNhap.TaiKhoan);
            }
        }

        //Xoa Du Lieu
        private void XoaDuLieu()
        {
            string maGiaoDich = string.Empty;
            DataTable dataTable = (DataTable)dgvGiaoDichThu.DataSource;
            if (dgvGiaoDichThu.CurrentRow != null)
            {
                DataRow dataRow;
                dataRow = dataTable.Rows[dgvGiaoDichThu.CurrentRow.Index];
                if (dataRow != null)
                {
                    if (dgvGiaoDichThu.Rows[dgvGiaoDichThu.CurrentRow.Index].Cells["MaGiaoDich"].Value != null || dgvGiaoDichThu.Rows[dgvGiaoDichThu.CurrentRow.Index].Cells["MaGiaoDich"].Value.ToString() != "")
                    {
                        maGiaoDich = dgvGiaoDichThu.Rows[dgvGiaoDichThu.CurrentRow.Index].Cells["MaGiaoDich"].Value.ToString();
                        giaoDichThuBUS.XoaGiaoDichThu(maGiaoDich);
                    }
                }
            }
        }
        //----------------------------------------------------------------------------


        private void frmTimKiemGiaoDichThu_Load(object sender, EventArgs e)
        {
            LayNgayDauTienCuaThang();
            CBBDanhMucTimKiem_Load();
            CBBDanhMuc_Load();
            CBBPhuongThucThanhToan_Load();
            cboDanhMuc.SelectedIndex = 0;
            cboDanhMuc_SelectedIndexChanged(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            LuuDuLieu();
            Data_Load();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa giao dịch này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                XoaDuLieu();
                Data_Load();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Data_Load();
        }

        private void cboDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Data_Load();
        }
    }
}
