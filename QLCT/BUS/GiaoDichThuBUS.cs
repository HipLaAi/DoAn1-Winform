using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCT.DAO;
using System.Data;
using QLCT.DTO;

namespace QLCT.BUS
{
    class GiaoDichThuBUS
    {
        GiaoDichThuDAO giaoDichThuDAO = new GiaoDichThuDAO();
        public DataTable DanhSachGiaoDichThuTheoTuan(string tenDangNhap)
        {
            return giaoDichThuDAO.DanhSachGiaoDichThuTheoTuan(tenDangNhap);
        }

        public DataTable DanhSachGiaoDichThuTheoThang(string tenDangNhap)
        {
            return giaoDichThuDAO.DanhSachGiaoDichThuTheoThang(tenDangNhap);
        }

        public DataTable TongTienGiaoDichThuTheoThang(string tenDangNhap)
        {
            return giaoDichThuDAO.TongTienGiaoDichThuTheoThang(tenDangNhap);
        }

        public DataTable TongTienGiaoDichThuTheoTuan(string tenDangNhap)
        {
            return giaoDichThuDAO.TongTienGiaoDichThuTheoTuan(tenDangNhap);
        }

        public DataTable DanhSachDanhMucThu()
        {
            return giaoDichThuDAO.DanhSachDanhMucThu();
        }

        public DataTable DanhSachPhuongThucThanhToan()
        {
            return giaoDichThuDAO.DanhSachPhuongThucThanhToan();
        }

        public void CapNhapGiaoDichThu(GiaoDichDTO giaoDich, string taiKhoan)
        {
            giaoDichThuDAO.CapNhapGiaoDichThu(giaoDich, taiKhoan);
        }

        public void ThemGiaoDichThu(GiaoDichDTO giaoDich, string taiKhoan)
        {
            giaoDichThuDAO.ThemGiaoDichThu(giaoDich, taiKhoan);
        }

        public void XoaGiaoDichThu(string maGiaoDich)
        {
            giaoDichThuDAO.XoaGiaoDichThu(maGiaoDich);
        }

        public DataTable TimKiemAllGiaoDichThu(string tenDangNhap, DateTime batDau, DateTime ketThuc)
        {
            return giaoDichThuDAO.TimKiemAllGiaoDichThu(tenDangNhap, batDau, ketThuc);

        }

        public DataTable TimKiemGiaoDichThu(string tenDangNhap, string maDanhMuc, DateTime batDau, DateTime ketThuc)
        {
            return giaoDichThuDAO.TimKiemGiaoDichThu(tenDangNhap, maDanhMuc, batDau, ketThuc);
        }

        public string ChuyenDoiDanhMuc(string tenDanhMuc)
        {
            return giaoDichThuDAO.ChuyenDoiDanhMuc(tenDanhMuc);
        }
    }
}
