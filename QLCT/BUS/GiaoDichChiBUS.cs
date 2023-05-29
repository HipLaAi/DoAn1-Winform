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
    class GiaoDichChiBUS
    {
        GiaoDichChiDAO giaoDichChiDAO = new GiaoDichChiDAO();
        public DataTable DanhSachGiaoDichChiTheoTuan(string tenDangNhap)
        {
            return giaoDichChiDAO.DanhSachGiaoDichChiTheoTuan(tenDangNhap);
        }

        public DataTable DanhSachGiaoDichChiTheoThang(string tenDangNhap)
        {
            return giaoDichChiDAO.DanhSachGiaoDichChiTheoThang(tenDangNhap);
        }

        public DataTable TongTienGiaoDichChiTheoThang(string tenDangNhap)
        {
            return giaoDichChiDAO.TongTienGiaoDichChiTheoThang(tenDangNhap);
        }

        public DataTable TongTienGiaoDichChiTheoTuan(string tenDangNhap)
        {
            return giaoDichChiDAO.TongTienGiaoDichChiTheoTuan(tenDangNhap);
        }

        public DataTable DanhSachDanhMucChi()
        {
            return giaoDichChiDAO.DanhSachDanhMucChi();
        }

        public DataTable DanhSachPhuongThucThanhToan()
        {
            return giaoDichChiDAO.DanhSachPhuongThucThanhToan();
        }

        public void CapNhapGiaoDichChi(GiaoDichDTO giaoDich, string taiKhoan)
        {
            giaoDichChiDAO.CapNhapGiaoDichChi(giaoDich, taiKhoan);
        }

        public void ThemGiaoDichChi(GiaoDichDTO giaoDich, string taiKhoan)
        {
            giaoDichChiDAO.ThemGiaoDichChi(giaoDich, taiKhoan);
        }

        public void XoaGiaoDichChi(string maGiaoDich)
        {
            giaoDichChiDAO.XoaGiaoDichChi(maGiaoDich);
        }

        public DataTable TimKiemAllGiaoDichChi(string tenDangNhap, DateTime batDau, DateTime ketThuc)
        {
            return giaoDichChiDAO.TimKiemAllGiaoDichChi(tenDangNhap, batDau, ketThuc);

        }

        public DataTable TimKiemGiaoDichChi(string tenDangNhap, string maDanhMuc, DateTime batDau, DateTime ketThuc)
        {
            return giaoDichChiDAO.TimKiemGiaoDichChi(tenDangNhap, maDanhMuc, batDau, ketThuc);
        }

        public string ChuyenDoiDanhMuc(string tenDanhMuc)
        {
            return giaoDichChiDAO.ChuyenDoiDanhMuc(tenDanhMuc);
        }

        public DataTable DoThiTongTien(string taiKhoan, int thang)
        {
            return giaoDichChiDAO.DoThiTongTien(taiKhoan, thang);
        }

        public string ChuyenDoiSangTenDanhMuc(string maDanhMuc)
        {
            return giaoDichChiDAO.ChuyenDoiSangTenDanhMuc(maDanhMuc);
        }

        public DataTable DoThiTongDanhMucTheoThang(string taiKhoan, int thang)
        {
            return giaoDichChiDAO.DoThiTongDanhMucTheoThang(taiKhoan, thang);
        }

        public DataTable DoThiTongDanhMucTheoNgay(string taiKhoan, int thang)
        {
            return giaoDichChiDAO.DoThiTongDanhMucTheoNgay(taiKhoan, thang);
        }
    }
}
