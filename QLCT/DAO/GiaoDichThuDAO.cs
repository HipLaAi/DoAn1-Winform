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
    class GiaoDichThuDAO : Connect
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
        public DataTable DanhSachGiaoDichThuTheoTuan(string tenDangNhap)
        {
            string query = "select * from CTGiaoDichThu where TenDangNhap = '" + tenDangNhap + "' and year(NgayGiaoDich) = year(getdate()) and datepart(week,NgayGiaoDich) = datepart(week,getdate())";
            return Table(query);
        }

        public DataTable DanhSachGiaoDichThuTheoThang(string tenDangNhap)
        {
            string query = "select * from CTGiaoDichThu where TenDangNhap = '" + tenDangNhap + "' and year(NgayGiaoDich) = year(getdate()) and month(NgayGiaoDich) = month(getdate())";
            return Table(query);
        }

        public DataTable TongTienGiaoDichThuTheoTuan(string tenDangNhap)
        {
            string query = "select sum(SoTien) from CTGiaoDichThu where TenDangNhap = '" + tenDangNhap + "' and year(NgayGiaoDich) = year(getdate()) and datepart(week,NgayGiaoDich) = datepart(week,getdate())";
            return Table(query);
        }

        public DataTable TongTienGiaoDichThuTheoThang(string tenDangNhap)
        {
            string query = "select sum(SoTien) from CTGiaoDichThu where TenDangNhap = '" + tenDangNhap + "' and year(NgayGiaoDich) = year(getdate()) and month(NgayGiaoDich) = month(getdate())";
            return Table(query);
        }

        public DataTable DanhSachDanhMucThu()
        {
            string query = "select * from DanhMucThu order by case when ISNUMERIC(SUBSTRING(MaDanhMuc, 4, LEN(MaDanhMuc))) = 1 THEN CAST(SUBSTRING(MaDanhMuc, 4, LEN(MaDanhMuc)) AS INT) ELSE NULL END";
            return Table(query);
        }
        public DataTable DanhSachPhuongThucThanhToan()
        {
            string query = "select * from PhuongThucThanhToan";
            return Table(query);
        }

        public void CapNhapGiaoDichThu(GiaoDichDTO giaoDich, string taiKhoan)
        {
            getConnection.Open();
            sqlCommand = new SqlCommand("CapNhatGiaoDichThu", getConnection);
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

        public void ThemGiaoDichThu(GiaoDichDTO giaoDich, string taiKhoan)
        {
            getConnection.Open();
            sqlCommand = new SqlCommand("ThemGiaoDichThu", getConnection);
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

        public void XoaGiaoDichThu(string maGiaoDich)
        {
            getConnection.Open();
            string query = "delete from CTGiaoDichThu where MaGiaoDich = @magiaodich";
            sqlCommand = new SqlCommand(query, getConnection);
            sqlCommand.Parameters.AddWithValue("@magiaodich", maGiaoDich);
            sqlCommand.ExecuteNonQuery();
            getConnection.Close();
        }

        public DataTable TimKiemAllGiaoDichThu(string tenDangNhap, DateTime batDau, DateTime ketThuc)
        {
            string ngayBatDau = string.Format("{0}-{1}-{2}", batDau.Month, batDau.Day, batDau.Year);
            string ngayKetThuc = string.Format("{0}-{1}-{2}", ketThuc.Month, ketThuc.Day, ketThuc.Year);
            string query = "select * from CTGiaoDichThu where TenDangNhap = '" + tenDangNhap + "' and NgayGiaoDich >= '" + ngayBatDau + "' and NgayGiaoDich <= '" + ngayKetThuc + "' ";
            return Table(query);
        }

        public DataTable TimKiemGiaoDichThu(string tenDangNhap, string maDanhMuc, DateTime batDau, DateTime ketThuc)
        {
            string ngayBatDau = string.Format("{0}-{1}-{2}", batDau.Month, batDau.Day, batDau.Year);
            string ngayKetThuc = string.Format("{0}-{1}-{2}", ketThuc.Month, ketThuc.Day, ketThuc.Year);
            string query = "select * from CTGiaoDichThu where MaDanhMuc = '" + maDanhMuc + "' and TenDangNhap = '" + tenDangNhap + "' and NgayGiaoDich >= '" + ngayBatDau + "' and NgayGiaoDich <= '" + ngayKetThuc + "' ";
            return Table(query);
        }

        public string ChuyenDoiDanhMuc(string tenDanhMuc)
        {
            string query = "select MaDanhMuc from DanhMucThu where TenDanhMuc = N'" + tenDanhMuc + "'";
            return Table(query).Rows[0][0].ToString();
        }
    }
}