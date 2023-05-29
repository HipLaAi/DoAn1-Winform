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
    public partial class frmCTGiaoDichThu : Form
    {
        GiaoDichThuBUS giaoDichThuBUS = new GiaoDichThuBUS();
        public frmCTGiaoDichThu()
        {
            InitializeComponent();
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

        //Load DuLieu
        private void Data_Load()
        {
            if (cboBaoCao.SelectedIndex == 0)
            {
                dgvGiaoDichThu.DataSource = giaoDichThuBUS.DanhSachGiaoDichThuTheoThang(frmDangNhap.TaiKhoan);
                if (giaoDichThuBUS.TongTienGiaoDichThuTheoThang(frmDangNhap.TaiKhoan).Rows[0][0].ToString() == "")
                {
                    txtTongTien.Text = "0 VNĐ";
                }
                else
                {
                    txtTongTien.Text = giaoDichThuBUS.TongTienGiaoDichThuTheoThang(frmDangNhap.TaiKhoan).Rows[0][0].ToString() + " VNĐ";
                }
            }
            else if (cboBaoCao.SelectedIndex == 1)
            {
                dgvGiaoDichThu.DataSource = giaoDichThuBUS.DanhSachGiaoDichThuTheoTuan(frmDangNhap.TaiKhoan);
                if (giaoDichThuBUS.TongTienGiaoDichThuTheoTuan(frmDangNhap.TaiKhoan).Rows[0][0].ToString() == "")
                {
                    txtTongTien.Text = "0 VNĐ";
                }
                else
                {
                    txtTongTien.Text = giaoDichThuBUS.TongTienGiaoDichThuTheoTuan(frmDangNhap.TaiKhoan).Rows[0][0].ToString() + " VNĐ";
                }
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
            DataTable dataTable = (DataTable)dgvGiaoDichThu.DataSource;

            for (int i = 0; i < dgvGiaoDichThu.Rows.Count - 1; i++)
            {
                DataRow dataRow;
                dataRow = dataTable.Rows[i];
                if (dataRow.RowState == DataRowState.Added)
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

                    if (dgvGiaoDichThu.Rows[i].Cells["DanhMuc"].Value.ToString() != "" && dgvGiaoDichThu.Rows[i].Cells["PhuongThucThanhToan"].Value.ToString() != "")
                    {
                        GiaoDichDTO giaoDich = new GiaoDichDTO(maDanhMuc, maPhuongThucThanhToan, soTien, moTa, ngayGiaoDich);
                        giaoDichThuBUS.ThemGiaoDichThu(giaoDich, frmDangNhap.TaiKhoan);
                    }

                    else
                    {
                        MessageBox.Show("Vui lòng chọn đầy đủ danh mục giao dịch và phương thức thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }

                if (dataRow.RowState == DataRowState.Modified)
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
        private void frmCTGiaoDichThu_Load(object sender, EventArgs e)
        {
            CBBDanhMuc_Load();
            CBBPhuongThucThanhToan_Load();
            cboBaoCao.SelectedIndex = 0;
            cboBaoCao_SelectedIndexChanged(sender, e);
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Data_Load();
        }

        private void cboBaoCao_SelectedIndexChanged(object sender, EventArgs e)
        {
            Data_Load();
        }
    }
}
