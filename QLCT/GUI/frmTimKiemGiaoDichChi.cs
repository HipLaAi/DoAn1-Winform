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
    public partial class frmTimKiemGiaoDichChi : Form
    {
        GiaoDichChiBUS giaoDichChiBUS = new GiaoDichChiBUS();
        public frmTimKiemGiaoDichChi()
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
            foreach (DataRow row in giaoDichChiBUS.DanhSachDanhMucChi().Rows)
            {
                string value = row[1].ToString();
                cboDanhMuc.Items.Add(value);
            }
        }

        //Load CBBDanhMuc
        private void CBBDanhMuc_Load()
        {
            DanhMuc.DataSource = giaoDichChiBUS.DanhSachDanhMucChi();
            DanhMuc.DisplayMember = "TenDanhMuc";
            DanhMuc.ValueMember = "MaDanhMuc";
        }

        //Load CBBPhuongThucThanhToan
        private void CBBPhuongThucThanhToan_Load()
        {
            PhuongThucThanhToan.DataSource = giaoDichChiBUS.DanhSachPhuongThucThanhToan();
            PhuongThucThanhToan.DisplayMember = "TenPhuongThucThanhToan";
            PhuongThucThanhToan.ValueMember = "MaPhuongThucThanhToan";
        }

        //Load data
        private void Data_Load()
        {
            if (cboDanhMuc.Text == "Tất cả")
            {
                dgvGiaoDichChi.DataSource = giaoDichChiBUS.TimKiemAllGiaoDichChi(frmDangNhap.TaiKhoan, dtpBatDau.Value, dtpKetThuc.Value);
            }
            else
            {
                string maGiaoDich = giaoDichChiBUS.ChuyenDoiDanhMuc(cboDanhMuc.Text);
                dgvGiaoDichChi.DataSource = giaoDichChiBUS.TimKiemGiaoDichChi(frmDangNhap.TaiKhoan, maGiaoDich, dtpBatDau.Value, dtpKetThuc.Value);
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

            for (int i = 0; i < dgvGiaoDichChi.Rows.Count; i++)
            {
                    if (dgvGiaoDichChi.Rows[i].Cells["MaGiaoDich"].Value != null)
                    {
                        maGiaoDich = dgvGiaoDichChi.Rows[i].Cells["MaGiaoDich"].Value.ToString();
                    }

                    if (dgvGiaoDichChi.Rows[i].Cells["DanhMuc"].Value != null)
                    {
                        maDanhMuc = dgvGiaoDichChi.Rows[i].Cells["DanhMuc"].Value.ToString();
                    }

                    if (dgvGiaoDichChi.Rows[i].Cells["SoTien"].Value != null)
                    {
                        if (dgvGiaoDichChi.Rows[i].Cells["SoTien"].Value.ToString() != "")
                        {
                            soTien = int.Parse(dgvGiaoDichChi.Rows[i].Cells["SoTien"].Value.ToString());
                        }
                        else
                        {
                            soTien = 0;
                        }
                    }

                    if (dgvGiaoDichChi.Rows[i].Cells["MoTa"].Value != null)
                    {
                        moTa = dgvGiaoDichChi.Rows[i].Cells["MoTa"].Value.ToString();
                    }

                    if (dgvGiaoDichChi.Rows[i].Cells["PhuongThucThanhToan"].Value != null)
                    {
                        maPhuongThucThanhToan = dgvGiaoDichChi.Rows[i].Cells["PhuongThucThanhToan"].Value.ToString();
                    }


                    if (dgvGiaoDichChi.Rows[i].Cells["NgayGiaoDich"].Value != null)
                    {
                        if (dgvGiaoDichChi.Rows[i].Cells["NgayGiaoDich"].Value.ToString() != "")
                        {
                            ngayGiaoDich = DateTime.Parse(dgvGiaoDichChi.Rows[i].Cells["NgayGiaoDich"].Value.ToString());
                        }
                    }

                    GiaoDichDTO giaoDich = new GiaoDichDTO(maGiaoDich, maDanhMuc, maPhuongThucThanhToan, soTien, moTa, ngayGiaoDich);
                    giaoDichChiBUS.CapNhapGiaoDichChi(giaoDich, frmDangNhap.TaiKhoan);
            }
        }

        //Xoa Du Lieu
        private void XoaDuLieu()
        {
            string maGiaoDich = string.Empty;
            DataTable dataTable = (DataTable)dgvGiaoDichChi.DataSource;
            if (dgvGiaoDichChi.CurrentRow != null)
            {
                DataRow dataRow;
                dataRow = dataTable.Rows[dgvGiaoDichChi.CurrentRow.Index];
                if (dataRow != null)
                {
                    if (dgvGiaoDichChi.Rows[dgvGiaoDichChi.CurrentRow.Index].Cells["MaGiaoDich"].Value != null || dgvGiaoDichChi.Rows[dgvGiaoDichChi.CurrentRow.Index].Cells["MaGiaoDich"].Value.ToString() != "")
                    {
                        maGiaoDich = dgvGiaoDichChi.Rows[dgvGiaoDichChi.CurrentRow.Index].Cells["MaGiaoDich"].Value.ToString();
                        giaoDichChiBUS.XoaGiaoDichChi(maGiaoDich);
                    }
                }
            }
        }

        //----------------------------------------------------------------------------
        private void frmTimKiemGiaoDichChi_Load(object sender, EventArgs e)
        {
            LayNgayDauTienCuaThang();
            CBBDanhMucTimKiem_Load();
            CBBDanhMuc_Load();
            CBBPhuongThucThanhToan_Load();
            cboDanhMuc.SelectedIndex = 0;
            cboDanhMuc_SelectedIndexChanged(sender,e);
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

        private void cboDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Data_Load();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Data_Load();
        }
    }
}
