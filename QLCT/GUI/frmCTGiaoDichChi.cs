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
    public partial class frmCTGiaoDichChi : Form
    {
        GiaoDichChiBUS giaoDichChiBUS = new GiaoDichChiBUS();
        public frmCTGiaoDichChi()
        {
            InitializeComponent();
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

        //Load DuLieu
        private void Data_Load()
        {
            if(cboBaoCao.SelectedIndex == 0)
            {
                dgvGiaoDichChi.DataSource = giaoDichChiBUS.DanhSachGiaoDichChiTheoThang(frmDangNhap.TaiKhoan);
                if (giaoDichChiBUS.TongTienGiaoDichChiTheoThang(frmDangNhap.TaiKhoan).Rows[0][0].ToString() == "")
                {
                    txtTongTien.Text = "0 VNĐ";
                }
                else
                {
                    txtTongTien.Text = giaoDichChiBUS.TongTienGiaoDichChiTheoThang(frmDangNhap.TaiKhoan).Rows[0][0].ToString() + " VNĐ";
                }
            }
            else if (cboBaoCao.SelectedIndex == 1)
            {
                dgvGiaoDichChi.DataSource = giaoDichChiBUS.DanhSachGiaoDichChiTheoTuan(frmDangNhap.TaiKhoan);
                if (giaoDichChiBUS.TongTienGiaoDichChiTheoTuan(frmDangNhap.TaiKhoan).Rows[0][0].ToString() == "")
                {
                    txtTongTien.Text = "0 VNĐ";
                }
                else
                {
                    txtTongTien.Text = giaoDichChiBUS.TongTienGiaoDichChiTheoTuan(frmDangNhap.TaiKhoan).Rows[0][0].ToString() + " VNĐ";
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
            System.Data.DataTable dataTable = (System.Data.DataTable)dgvGiaoDichChi.DataSource;

            for (int i = 0; i < dgvGiaoDichChi.Rows.Count-1; i++)
            {
                DataRow dataRow;
                dataRow = dataTable.Rows[i];
                if (dataRow.RowState == DataRowState.Added)
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

                    if (dgvGiaoDichChi.Rows[i].Cells["DanhMuc"].Value.ToString() != "" && dgvGiaoDichChi.Rows[i].Cells["PhuongThucThanhToan"].Value.ToString() != "")
                    {
                        GiaoDichDTO giaoDich = new GiaoDichDTO(maDanhMuc, maPhuongThucThanhToan, soTien, moTa, ngayGiaoDich);
                        giaoDichChiBUS.ThemGiaoDichChi(giaoDich, frmDangNhap.TaiKhoan);
                    }

                    else
                    {
                        MessageBox.Show("Vui lòng chọn đầy đủ danh mục giao dịch và phương thức thanh toán", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Question);
                    }
                }

                if (dataRow.RowState == DataRowState.Modified)
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
                        if(dgvGiaoDichChi.Rows[i].Cells["SoTien"].Value.ToString() != "")
                        {
                            soTien = int.Parse(dgvGiaoDichChi.Rows[i].Cells["SoTien"].Value.ToString());
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
        }

        //Xoa Du Lieu
        private void XoaDuLieu()
        {
            string maGiaoDich = string.Empty;
            System.Data.DataTable dataTable = (System.Data.DataTable)dgvGiaoDichChi.DataSource;
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

        private void frmTrangChu_Load(object sender, EventArgs e)
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
            if(MessageBox.Show("Bạn có chắc muốn xóa giao dịch này?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
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
