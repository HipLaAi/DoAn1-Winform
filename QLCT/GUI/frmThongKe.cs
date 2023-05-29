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
using System.Windows.Forms.DataVisualization.Charting;


namespace QLCT.GUI
{
    public partial class frmThongKe : Form
    {
        GiaoDichChiBUS giaoDichChiBUS = new GiaoDichChiBUS();
        public frmThongKe()
        {
            InitializeComponent();
        }

        //Load data
        private void Data_Load()
        {
            chartDoThiTongTien.Series["Tổng tiền"].Points.Clear();

            foreach (DataRow row in giaoDichChiBUS.DoThiTongTien(frmDangNhap.TaiKhoan, int.Parse(cboThang.Text)).Rows)
            {
                DateTime xValue = Convert.ToDateTime(row[0]);
                chartDoThiTongTien.Series["Tổng tiền"].IsValueShownAsLabel = true;
                chartDoThiTongTien.Series["Tổng tiền"].Points.AddXY(xValue.ToString("dd/MM/yyyy"), row[1]);
            }

            if (chartDoThiTongTien.Series["Tổng tiền"].Points.Count == 0)
            {
                chartDoThiTongTien.Series["Tổng tiền"].IsValueShownAsLabel = false;
                chartDoThiTongTien.Series["Tổng tiền"].Points.AddXY("Ngày giao dịch", 0);
            }

            chartDoThiDanhMucTheoThang.Series["DanhMuc"].Points.Clear();

            foreach (DataRow row in giaoDichChiBUS.DoThiTongDanhMucTheoThang(frmDangNhap.TaiKhoan, int.Parse(cboThang.Text)).Rows)
            {
                chartDoThiDanhMucTheoThang.Series["DanhMuc"].IsValueShownAsLabel = true;
                chartDoThiDanhMucTheoThang.Series["DanhMuc"].Points.AddXY(row[0], row[1]);
            }

            if (chartDoThiDanhMucTheoThang.Series["DanhMuc"].Points.Count == 0)
            {
                chartDoThiDanhMucTheoThang.Series["DanhMuc"].IsValueShownAsLabel = false;
                chartDoThiDanhMucTheoThang.Series["DanhMuc"].Points.AddXY("Danh mục", 100);
            }

        }

        //Load DateTimePicker
        private void DatetimePicker_Load()
        {
            chartDoThiDanhMucTheoNgay.Series["DanhMuc"].Points.Clear();

            foreach (DataRow row in giaoDichChiBUS.DoThiTongDanhMucTheoNgay(frmDangNhap.TaiKhoan, dateTimePicker.Value.Day).Rows)
            {
                chartDoThiDanhMucTheoNgay.Series["DanhMuc"].IsValueShownAsLabel = true;
                chartDoThiDanhMucTheoNgay.Series["DanhMuc"].Points.AddXY(row[0], row[1]);
            }

            if (chartDoThiDanhMucTheoNgay.Series["DanhMuc"].Points.Count == 0)
            {
                chartDoThiDanhMucTheoNgay.Series["DanhMuc"].IsValueShownAsLabel = false;
                chartDoThiDanhMucTheoNgay.Series["DanhMuc"].Points.AddXY("Danh mục", 100);
            }
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            int month = currentDate.Month;

            cboThang.SelectedIndex = month -1;
            cboThang_SelectedIndexChanged(sender,e);
            dateTimePicker_ValueChanged(sender, e);
        }

        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            Data_Load();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DatetimePicker_Load();
        }
    }
}
