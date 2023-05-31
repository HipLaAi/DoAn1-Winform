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
    public partial class frmThongKeTaiKhoan : Form
    {
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        public frmThongKeTaiKhoan()
        {
            InitializeComponent();
        }

        //Load biểu đồ
        private void Data_Load()
        {
            chartSoLuongNguoiTheoTinh.Series["Số lượng người dùng"].Points.Clear(); //Làm mới biểu đồ

            foreach (DataRow row in taiKhoanBUS.SoLuongTheoTinh().Rows) //Biểu đồ cột thống kê theo tỉnh thành
            {
                chartSoLuongNguoiTheoTinh.Series["Số lượng người dùng"].IsValueShownAsLabel = true;
                chartSoLuongNguoiTheoTinh.Series["Số lượng người dùng"].Points.AddXY(row[0], row[1]);
            }

            if (chartSoLuongNguoiTheoTinh.Series["Số lượng người dùng"].Points.Count == 0)
            {
                chartSoLuongNguoiTheoTinh.Series["Số lượng người dùng"].IsValueShownAsLabel = false;
                chartSoLuongNguoiTheoTinh.Series["Số lượng người dùng"].Points.AddXY("Tên tỉnh thành", 0);
            }

            chartSoLuongTheoDoTuoi.Series["Độ tuổi"].Points.Clear(); //Làm mới biểu đồ
            string tinhThanh = cboTinh.Text;
            if (tinhThanh == "Tất cả")
                tinhThanh = "";
            foreach (DataRow row in taiKhoanBUS.SoLuongDoTuoi(tinhThanh).Rows) //Biểu đồ tròn thống kê theo độ tuổi
            {
                chartSoLuongTheoDoTuoi.Series["Độ tuổi"].IsValueShownAsLabel = true;
                chartSoLuongTheoDoTuoi.Series["Độ tuổi"].Points.AddXY(row[1], row[0]);
            }

            if (chartSoLuongTheoDoTuoi.Series["Độ tuổi"].Points.Count == 0)
            {
                chartSoLuongTheoDoTuoi.Series["Độ tuổi"].IsValueShownAsLabel = false;
                chartSoLuongTheoDoTuoi.Series["Độ tuổi"].Points.AddXY("Độ tuổi", 100);
            }
        }

        private void frmThongKeTaiKhoan_Load(object sender, EventArgs e)
        {
            cboTinh.DataSource = DanhSachTinhThanh;
            Data_Load();
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

        private void cboTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            Data_Load();
        }
    }
}
