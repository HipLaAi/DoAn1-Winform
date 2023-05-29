using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCT.DTO;
using QLCT.DAO;
using System.Data;

namespace QLCT.BUS
{
    class TaiKhoanBUS
    {
        TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
        public bool DangNhap(string taiKhoan, string matKhau, string loaiTaiKhoan)
        {
            if (taiKhoanDAO.DangNhap(taiKhoan, matKhau, loaiTaiKhoan))
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
            if(taiKhoanDAO.QuenMatKhau(taiKhoan, soDienThoai))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ThayDoiMatKhau(string taiKhoan, string matKhauMoi)
        {
            if (taiKhoanDAO.ThayDoiMatKhau(taiKhoan, matKhauMoi))
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
            return taiKhoanDAO.ThongTinTaiKhoan(taiKhoan);
        }

        public bool CapNhatTaiKhoan(string taiKhoan, string hoTen, string gioiTinh, string sDt, string diaChi, DateTime ngaySinh)
        {
            return taiKhoanDAO.CapNhatTaiKhoan(taiKhoan, hoTen, gioiTinh, sDt, diaChi, ngaySinh);
        }

        public bool DangKy(string taiKhoan, string matKhau, string hoTen, string gioiTinh, string sDt, string diaChi, DateTime ngaySinh, string loaiTaiKhoan)
        {
            return taiKhoanDAO.DangKy(taiKhoan, matKhau, hoTen, gioiTinh, sDt, diaChi, ngaySinh, loaiTaiKhoan);   
        }

        public bool XoaTaiKhoan(string taiKhoan)
        {
            return taiKhoanDAO.XoaTaiKhoan(taiKhoan);
        }

        public DataTable DanhSachTaiKhoanTheoLuaChon(string taiKhoan, string gioiTinhNam, string gioiTinhNu, string DiaChi)
        {
            return taiKhoanDAO.DanhSachTaiKhoanTheoLuaChon(taiKhoan, gioiTinhNam, gioiTinhNu, DiaChi);
        }

        public DataTable SoLuongTheoTinh()
        {
            return taiKhoanDAO.SoLuongTheoTinh();
        }

        public DataTable SoLuongDoTuoi(string tinhThanh)
        {
            return taiKhoanDAO.SoLuongDoTuoi(tinhThanh);
        }
    }
}
