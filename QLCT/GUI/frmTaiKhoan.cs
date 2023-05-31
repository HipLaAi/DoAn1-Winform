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
using System.Text.RegularExpressions;


namespace QLCT.GUI
{
    public partial class frmTaiKhoan : Form
    {
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        public frmTaiKhoan()
        {
            InitializeComponent();
            InitializeDanhSachHuyen();
        }
        bool check = false;
        string sdt;
        // Load data
        private void Data_Load(object sender, EventArgs e)
        {
            check = false;

            //Load dữ liệu vào các textbox, datetimepicker, marktextbox
            txtHoTen.Text = taiKhoanBUS.ThongTinTaiKhoan(frmDangNhap.TaiKhoan).Rows[0][2].ToString(); 
            dtpNgaySinh.Value = Convert.ToDateTime(taiKhoanBUS.ThongTinTaiKhoan(frmDangNhap.TaiKhoan).Rows[0][4]);
            mtxtSDT.Text = sdt = taiKhoanBUS.ThongTinTaiKhoan(frmDangNhap.TaiKhoan).Rows[0][5].ToString();

            cboTinh.DataSource = DanhSachTinhThanh; //Truyền danh sách tỉnh thành vào combobox
            //InitializeDanhSachHuyen();
            string diachi = taiKhoanBUS.ThongTinTaiKhoan(frmDangNhap.TaiKhoan).Rows[0][6].ToString();
            char separator = '-';
            string[] result = diachi.Split(separator);

            cboTinh.SelectedItem = result[1];

            cboTinh_SelectedIndexChanged(sender, e);
            cboHuyen.SelectedItem = result[0];

            string gioiTinh = taiKhoanBUS.ThongTinTaiKhoan(frmDangNhap.TaiKhoan).Rows[0][3].ToString();
            if(gioiTinh == "Nam")
            {
                rdbNam.Checked = true;
            }
            if (gioiTinh == "Nữ")
            {
                rdbNu.Checked = true;
            }
        }

        // Load cap nhat tai khoan
        private void CapNhatTaiKhoan()
        {
            string gioiTinh = String.Empty; //kiểm tra giới tính
            if (rdbNam.Checked)
            {
                gioiTinh = "Nam";
            }
            else if (rdbNu.Checked)
            {
                gioiTinh = "Nữ";
            }

            string SDT = mtxtSDT.Text.Replace("-", "").Replace(" ", ""); //Chuyển xâu ký tự điện thoại từ "-" thành ""

            string diaChi = cboHuyen.Text + "-" + cboTinh.Text; //Nối xâu địa chỉ

            if(txtHoTen.Text != "" && SDT != "") //Kiểm tra hoten rỗng
            {
                if ((Regex.IsMatch(SDT, @"[XXX]"))) //Kiểm tra SDT nếu có chữa ký tự X
                {
                    if (taiKhoanBUS.CapNhatTaiKhoan(frmDangNhap.TaiKhoan, txtHoTen.Text, gioiTinh, sdt, diaChi, dtpNgaySinh.Value))
                    {
                        MessageBox.Show("Cập nhật thông tin tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin tài khoản không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (taiKhoanBUS.CapNhatTaiKhoan(frmDangNhap.TaiKhoan, txtHoTen.Text, gioiTinh, SDT, diaChi, dtpNgaySinh.Value))
                    {
                        MessageBox.Show("Cập nhật thông tin tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin tài khoản không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }    
            else
            {
                MessageBox.Show("Cập nhật thông tin tài khoản không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Khoa chuc nang
        private void ResetTextBox()
        {
            txtHoTen.Enabled = false;
            rdbNam.Enabled = false;
            rdbNu.Enabled = false;
            cboTinh.Enabled = false;
            cboHuyen.Enabled = false;
            mtxtSDT.Enabled = false;
            dtpNgaySinh.Enabled = false;
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            Data_Load(sender,e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (check)
            {
                CapNhatTaiKhoan();
                ResetTextBox();
                mtxtSDT.Mask = "0000-000-XXX";
                mtxtSDT.Text = taiKhoanBUS.ThongTinTaiKhoan(frmDangNhap.TaiKhoan).Rows[0][5].ToString().Substring(0, 7);
            }
            else
            {
                ResetTextBox();
                mtxtSDT.Mask = "0000-000-XXX";
                mtxtSDT.Text = taiKhoanBUS.ThongTinTaiKhoan(frmDangNhap.TaiKhoan).Rows[0][5].ToString().Substring(0, 7);
            }
            Data_Load(sender, e);
        }

        private void btnHoTen_Click(object sender, EventArgs e)
        {
            check = true;
            ResetTextBox();
            txtHoTen.Enabled = true;
        }

        private void btnGioiTinh_Click(object sender, EventArgs e)
        {
            check = true;
            ResetTextBox();
            rdbNam.Enabled = true;
            rdbNu.Enabled = true;
        }

        private void btnDiaChi_Click(object sender, EventArgs e)
        {
            check = true;
            ResetTextBox();
            cboTinh.Enabled = true;
            cboHuyen.Enabled = true;
        }

        private void btnSDT_Click(object sender, EventArgs e)
        {
            check = true;
            ResetTextBox();
            frmKiemTraSDT frmKiemTraSDT = new frmKiemTraSDT();
            frmKiemTraSDT.ShowDialog();
            if(frmKiemTraSDT.kiemTraSDT == "Hủy")
            {
                mtxtSDT.Enabled = false;
                mtxtSDT.Mask = "0000-000-XXX";
                mtxtSDT.Text = sdt;
            }
            else
            {
                mtxtSDT.Enabled = true;
                mtxtSDT.Mask = "0000-000-000";
                mtxtSDT.Text = taiKhoanBUS.ThongTinTaiKhoan(frmDangNhap.TaiKhoan).Rows[0][5].ToString();
            }
        }

        private void btnNgaySinh_Click(object sender, EventArgs e)
        {
            check = true;
            ResetTextBox();
            dtpNgaySinh.Enabled = true;
        }

        private void btnThayDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmCapNhatMatKhau frmCapNhatMatKhau = new frmCapNhatMatKhau();
            frmCapNhatMatKhau.ShowDialog();
        }


        //Danh sách tỉnh thành
        public List<string> DanhSachTinhThanh = new List<string>
        {
            "TP Hà Nội",
            "Hải Dương",
            "Hải Phòng",
            "Hưng Yên",
            "Ninh Bình",
            "Phú Thọ",
            "Thái Bình",
            "TP Hồ Chí Minh"
        };

        public Dictionary<string, List<string>> DanhSachHuyen = new Dictionary<string, List<string>>();

        //Danh sách huyện
        public void InitializeDanhSachHuyen()
        {
            DanhSachHuyen.Add("TP Hà Nội", new List<string> { "Đan Phượng", "Gia Lâm", "Đông Anh", "Chương Mỹ", "Hoài Đức", "Ba Vì", "Mỹ Đức", "Phúc Thọ", "Thạch Thất", "Quốc Oai", "Thanh Trì", "Thường Tín", "Thanh Oai", "Phú Xuyên", "Mê Linh", "Sóc Sơn", "Ứng Hòa", "Sơn Tây" });
            DanhSachHuyen.Add("Hải Dương", new List<string> { "Bình Giang", "Cẩm Giàng", "Gia Lộc", "Kim Thành", "Kinh Môn", "Nam Sách", "Ninh Giang", "Thanh Hà", "Thanh Miện", "Tứ Kỳ", "Chí Linh", "TP Hải Dương" });
            DanhSachHuyen.Add("Hải Phòng", new List<string> { "Hồng Bàng", "Lê Chân", "Ngô Quyền", "Kiến An", "Hải An", "Đồ Sơn", "Dương Kinh", "An Dương", "An Lão", "Kiến Thụy", "Tiên Lãng", "Thuỷ Nguyên", "Vĩnh Bảo", "Bạch Long Vĩ", "Cát Hải" });
            DanhSachHuyen.Add("Hưng Yên", new List<string> { "Ân Thi", "Mỹ Hào", "Tiên Lữ", "Phù Cừ", "Yên Mỹ", "Kim Động", "Văn Giang", "Văn Lâm", "Khoái Châu" });
            DanhSachHuyen.Add("Ninh Bình", new List<string> { "TP Ninh Bình", "Tam Điệp", "Gia Viễn", "Hoa Lư", "Kim Sơn", "Nho Quan", "Yên Khánh", "Yên Mô" });
            DanhSachHuyen.Add("Phú Thọ", new List<string> { "Hạ Hòa", "Đoan Hùng", "Thanh Ba", "Phù Ninh", "Lâm Thao", "Tam Nông", "Thanh Thủy", "Cẩm Khê", "Yên Lập", "Thanh Sơn", "Tân Sơn" });
            DanhSachHuyen.Add("Thái Bình", new List<string> { "Hưng Hà", "Đông Hưng", "Quỳnh Phụ", "Thái Thụy", "Tiền Hải", "Kiến Xương", "Vũ Thư", "TP Thái Bình" });
            DanhSachHuyen.Add("TP Hồ Chí Minh", new List<string> { "TP Thủ Đức", "Quận 1", "Quận 2", "Quận 3", "Quận 4", "Quận 5", "Quận 6", "Quận 7", "Quận 8", "Quận 9", "Quận 10", "Quận 11", "Quận 12" });
        }

        private void cboTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTinhThanh = cboTinh.SelectedItem.ToString();

            // Kiểm tra xem có danh sách huyện/quận cho tỉnh/thành phố đã chọn hay không
            if (DanhSachHuyen.ContainsKey(selectedTinhThanh))
            {
                List<string> DanhSachhuyen = DanhSachHuyen[selectedTinhThanh];

                // Cập nhật danh sách huyện/quận cho ComboBox huyện/quận
                cboHuyen.DataSource = DanhSachhuyen;
            }
            else
            {
                // Nếu không có danh sách huyện/quận, xóa danh sách hiện tại của ComboBox huyện/quận
                cboHuyen.DataSource = null;
            }
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho ký tự số được nhập vào TextBox
            }
        }
    }
}
