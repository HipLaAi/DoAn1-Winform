using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QLCT.DTO;

namespace QLCT.DAO
{
    class GiaoDichChiDAO : Connect
    {
        private SqlDataAdapter dataAdapter;
        private SqlCommand sqlCommand;

        private DataTable Table(string query)
        {
            DataTable dataTable = new DataTable();
            getConnection.Open();
            dataAdapter = new SqlDataAdapter(query, getConnection);
            dataAdapter.Fill(dataTable);
            getConnection.Close();
            return dataTable;
        }
        public DataTable DanhSachGiaoDichChiTheoTuan(string tenDangNhap)
        {
            string query = "select * from CTGiaoDichChi where TenDangNhap = '"+ tenDangNhap + "' and year(NgayGiaoDich) = year(getdate()) and datepart(week,NgayGiaoDich) = datepart(week,getdate())";
            return Table(query);
        }

        public DataTable DanhSachGiaoDichChiTheoThang(string tenDangNhap)
        {
            string query = "select * from CTGiaoDichChi where TenDangNhap = '" + tenDangNhap + "' and year(NgayGiaoDich) = year(getdate()) and month(NgayGiaoDich) = month(getdate())";
            return Table(query);
        }

        public DataTable TongTienGiaoDichChiTheoTuan(string tenDangNhap)
        {
            string query = "select sum(SoTien) from CTGiaoDichChi where TenDangNhap = '" + tenDangNhap + "' and year(NgayGiaoDich) = year(getdate()) and datepart(week,NgayGiaoDich) = datepart(week,getdate())";
            return Table(query);
        }

        public DataTable TongTienGiaoDichChiTheoThang(string tenDangNhap)
        {
            string query = "select sum(SoTien) from CTGiaoDichChi where TenDangNhap = '" + tenDangNhap + "' and year(NgayGiaoDich) = year(getdate()) and month(NgayGiaoDich) = month(getdate())";
            return Table(query);
        }

        public DataTable DanhSachDanhMucChi()
        {
            string query = "select * from DanhMucChi order by case when ISNUMERIC(SUBSTRING(MaDanhMuc, 4, LEN(MaDanhMuc))) = 1 THEN CAST(SUBSTRING(MaDanhMuc, 4, LEN(MaDanhMuc)) AS INT) ELSE NULL END";
            return Table(query);
        }
        public DataTable DanhSachPhuongThucThanhToan()
        {
            string query = "select * from PhuongThucThanhToan";
            return Table(query);
        }

        public void CapNhapGiaoDichChi(GiaoDichDTO giaoDich, string taiKhoan)
        {
            getConnection.Open();
            sqlCommand = new SqlCommand("CapNhatGiaoDichChi", getConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@magiaodich", giaoDich.MaGiaoDich);
            sqlCommand.Parameters.AddWithValue("@taikhoan", taiKhoan);
            sqlCommand.Parameters.AddWithValue("@madanhmuc", giaoDich.MaDanhMuc);
            sqlCommand.Parameters.AddWithValue("@maphuongthucthanhtoan", giaoDich.MaPhuongThucThanhToan);
            sqlCommand.Parameters.AddWithValue("@sotien", giaoDich.SoTien);
            sqlCommand.Parameters.AddWithValue("@mota", giaoDich.MoTa);
            string ngayGiaoDich = string.Format("{0}-{1}-{2}", giaoDich.NgayGiaoDich.Month, giaoDich.NgayGiaoDich.Day, giaoDich.NgayGiaoDich.Year);
            sqlCommand.Parameters.AddWithValue("@ngaygiaodich", ngayGiaoDich);
            sqlCommand.ExecuteNonQuery();
            getConnection.Close();
        }

        public void ThemGiaoDichChi(GiaoDichDTO giaoDich,string taiKhoan)
        {
            getConnection.Open();
            sqlCommand = new SqlCommand("ThemGiaoDichChi", getConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@taikhoan", taiKhoan);
            sqlCommand.Parameters.AddWithValue("@madanhmuc", giaoDich.MaDanhMuc);
            sqlCommand.Parameters.AddWithValue("@maphuongthucthanhtoan", giaoDich.MaPhuongThucThanhToan);
            sqlCommand.Parameters.AddWithValue("@sotien", giaoDich.SoTien);
            sqlCommand.Parameters.AddWithValue("@mota", giaoDich.MoTa);
            string ngayGiaoDich = string.Format("{0}-{1}-{2}", giaoDich.NgayGiaoDich.Month, giaoDich.NgayGiaoDich.Day, giaoDich.NgayGiaoDich.Year);
            sqlCommand.Parameters.AddWithValue("@ngaygiaodich", ngayGiaoDich);
            sqlCommand.ExecuteNonQuery();
            getConnection.Close();
        }

        public void XoaGiaoDichChi(string maGiaoDich)
        {
            getConnection.Open();
            string query = "delete from CTGiaoDichChi where MaGiaoDich = @magiaodich";
            sqlCommand = new SqlCommand(query,getConnection);
            sqlCommand.Parameters.AddWithValue("@magiaodich", maGiaoDich);
            sqlCommand.ExecuteNonQuery();
            getConnection.Close();
        }
        public DataTable TimKiemAllGiaoDichChi(string tenDangNhap, DateTime batDau, DateTime ketThuc)
        {
            string ngayBatDau = string.Format("{0}-{1}-{2}", batDau.Month, batDau.Day, batDau.Year);
            string ngayKetThuc = string.Format("{0}-{1}-{2}", ketThuc.Month, ketThuc.Day, ketThuc.Year);
            string query = "select * from CTGiaoDichChi where TenDangNhap = '" + tenDangNhap + "' and NgayGiaoDich >= '" + ngayBatDau + "' and NgayGiaoDich <= '" + ngayKetThuc + "' ";
            return Table(query);
        }

        public DataTable TimKiemGiaoDichChi(string tenDangNhap, string maDanhMuc, DateTime batDau, DateTime ketThuc)
        {
            string ngayBatDau = string.Format("{0}-{1}-{2}", batDau.Month, batDau.Day, batDau.Year);
            string ngayKetThuc = string.Format("{0}-{1}-{2}", ketThuc.Month, ketThuc.Day, ketThuc.Year);
            string query = "select * from CTGiaoDichChi where MaDanhMuc = '" + maDanhMuc + "' and TenDangNhap = '" + tenDangNhap + "' and NgayGiaoDich >= '" + ngayBatDau + "' and NgayGiaoDich <= '" + ngayKetThuc + "' ";
            return Table(query);
        }

        public string ChuyenDoiDanhMuc(string tenDanhMuc)
        {
            string query = "select MaDanhMuc from DanhMucChi where TenDanhMuc = N'" + tenDanhMuc + "'";
            return Table(query).Rows[0][0].ToString();
        }

        public DataTable DoThiTongTien(string taiKhoan, int thang)
        {
            string query = "select NgayGiaoDich, sum(SoTien) AS TongSoTien from CTGiaoDichChi where TenDangNhap = '"+ taiKhoan + "' and month(NgayGiaoDich) = '"+thang+"' group by NgayGiaoDich order by NgayGiaoDich asc";
            return Table(query);
        }

        public string ChuyenDoiSangTenDanhMuc(string maDanhMuc)
        {
            string query = "select TenDanhMuc from DanhMucChi where MaDanhMuc = '" + maDanhMuc + "'";

            return Table(query).Rows[0][0].ToString();
        }

        public DataTable DoThiTongDanhMucTheoThang(string taiKhoan, int thang)
        {
            string query = "select TenDanhMuc, sum(SoTien) AS TongSoTien from CTGiaoDichChi, DanhMucChi where DanhMucChi.MaDanhMuc = CTGiaoDichChi.MaDanhMuc and TenDangNhap = '"+ taiKhoan + "' and month(NgayGiaoDich) = '"+ thang + "'group by  CTGiaoDichChi.MaDanhMuc ,TenDanhMuc";
            return Table(query);
        }

        public DataTable DoThiTongDanhMucTheoNgay(string taiKhoan, int thang)
        {
            string query = "select TenDanhMuc, sum(SoTien) AS TongSoTien from CTGiaoDichChi, DanhMucChi where DanhMucChi.MaDanhMuc = CTGiaoDichChi.MaDanhMuc and TenDangNhap = '" + taiKhoan + "' and day(NgayGiaoDich) = '" + thang + "'group by  CTGiaoDichChi.MaDanhMuc ,TenDanhMuc";
            return Table(query);
        }
    }
}