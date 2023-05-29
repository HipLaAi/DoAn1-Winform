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
    public class TaiKhoanDAO : Connect
    {
        private SqlCommand sqlCommand;
        private SqlDataAdapter dataAdapter;

        private DataTable Table(string query)
        {
            DataTable dataTable = new DataTable();
            getConnection.Open();
            dataAdapter = new SqlDataAdapter(query, getConnection);
            dataAdapter.Fill(dataTable);
            getConnection.Close();
            return dataTable;
        }

        public bool DangNhap(string taiKhoan, string matKhau, string loaiTaiKhoan)
        {
            getConnection.Open();

            sqlCommand = new SqlCommand("CheckTaiKhoan", getConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@taikhoan", taiKhoan);
            sqlCommand.Parameters.AddWithValue("@matkhau", matKhau);
            sqlCommand.Parameters.AddWithValue("@loai", loaiTaiKhoan);

            int count = (int)sqlCommand.ExecuteScalar();
            getConnection.Close();
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool QuenMatKhau(string taiKhoan, string soDienThoai)
        {
            getConnection.Open();
            var query = "select * from TaiKhoan where TenDangNhap = @taikhoan and SDT = @sdt";
            sqlCommand = new SqlCommand(query, getConnection);
            sqlCommand.Parameters.AddWithValue("taikhoan", taiKhoan);
            sqlCommand.Parameters.AddWithValue("sdt", soDienThoai);
            var count = sqlCommand.ExecuteReader();
            bool hasRows = false;
            if (count.Read())
            {
                hasRows = true;
            }
            getConnection.Close();
            return hasRows;
        }

        public bool ThayDoiMatKhau(string taiKhoan, string matKhauMoi)
        {
            getConnection.Open();

            sqlCommand = new SqlCommand("DoiMatKhauTaiKhoan", getConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@taikhoan", taiKhoan);
            sqlCommand.Parameters.AddWithValue("@matkhaumoi", matKhauMoi);

            int count = (int)sqlCommand.ExecuteScalar();
            getConnection.Close();
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable ThongTinTaiKhoan(string taiKhoan)
        {
            string query = "select * from TaiKhoan where TenDangNhap = '"+taiKhoan+"'";
            return Table(query);
        }

        public DataTable DanhSachTaiKhoanTheoLuaChon(string taiKhoan, string gioiTinhNam,string gioiTinhNu, string DiaChi)
        {
            string query = "select * from TaiKhoan where TenDangNhap like '%"+ taiKhoan + "%' and GioiTinh in (N'"+ gioiTinhNam + "',N'" + gioiTinhNu + "') and DiaChi like N'%"+ DiaChi + "%' and LoaiTaiKhoan = 'USER'";
            return Table(query);
        }

        public bool CapNhatTaiKhoan(string taiKhoan, string hoTen, string gioiTinh, string sDt, string diaChi, DateTime ngaySinh)
        {
            getConnection.Open();

            sqlCommand = new SqlCommand("CapNhatTaiKhoan", getConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@taikhoan", taiKhoan);
            sqlCommand.Parameters.AddWithValue("@hoten", hoTen);
            sqlCommand.Parameters.AddWithValue("@gioitinh", gioiTinh);
            string ngaysinh = string.Format("{0}-{1}-{2}", ngaySinh.Month, ngaySinh.Day, ngaySinh.Year);
            sqlCommand.Parameters.AddWithValue("@ngaysinh", ngaysinh);
            sqlCommand.Parameters.AddWithValue("@sdt", sDt);
            sqlCommand.Parameters.AddWithValue("@diachi", diaChi);

            int count = (int)sqlCommand.ExecuteScalar();
            getConnection.Close();
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool XoaTaiKhoan(string taiKhoan)
        {
            getConnection.Open();
            var query = "delete from TaiKhoan where TenDangNhap = @taikhoan";
            sqlCommand = new SqlCommand(query, getConnection);
            sqlCommand.Parameters.AddWithValue("taikhoan", taiKhoan);
            var count = sqlCommand.ExecuteReader();
            bool hasRows = false;
            if (count.Read())
            {
                hasRows = true;
            }
            getConnection.Close();
            return hasRows;
        }

        public bool DangKy(string taiKhoan,string matKhau, string hoTen, string gioiTinh, string sDt, string diaChi, DateTime ngaySinh, string loaiTaiKhoan)
        {
            getConnection.Open();

            sqlCommand = new SqlCommand("ThemTaiKhoan", getConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@taikhoan", taiKhoan);
            sqlCommand.Parameters.AddWithValue("@matkhau", matKhau);
            sqlCommand.Parameters.AddWithValue("@hoten", hoTen);
            sqlCommand.Parameters.AddWithValue("@gioitinh", gioiTinh);
            string ngaysinh = string.Format("{0}-{1}-{2}", ngaySinh.Month, ngaySinh.Day, ngaySinh.Year);
            sqlCommand.Parameters.AddWithValue("@ngaysinh", ngaysinh);
            sqlCommand.Parameters.AddWithValue("@sdt", sDt);
            sqlCommand.Parameters.AddWithValue("@diachi", diaChi);
            sqlCommand.Parameters.AddWithValue("@loaitaikhoan", loaiTaiKhoan);

            int count = (int)sqlCommand.ExecuteNonQuery();
            getConnection.Close();
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable SoLuongTheoTinh()
        {
            string query = "select * from TinhThanh";
            return Table(query);
        }

        public DataTable SoLuongDoTuoi(string tinhThanh)
        {
            getConnection.Open();
            sqlCommand = new SqlCommand("DoTuoi", getConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@tinhthanh", tinhThanh);
            sqlCommand.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dataTable);
            getConnection.Close();
            return dataTable;
        }
    }
}