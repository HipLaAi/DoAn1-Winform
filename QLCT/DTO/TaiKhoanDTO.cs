using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCT.DTO
{
    class TaiKhoanDTO
    {
        public string tendangnhap;

        public string matkhau;

        public string hoten;

        public string gioitinh;

        public string sdt;

        public string diachi;

        public string loaitaikhoan;

        public DateTime ngaysinh;

        public string Tendangnhap { get => tendangnhap; set => tendangnhap = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Loaitaikhoan { get => loaitaikhoan; set => loaitaikhoan = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }


        public TaiKhoanDTO() { }

        public TaiKhoanDTO(string tendangnhap, string matkhau, string hoten, string gioitinh, string sdt, string diachi, string loaitaikhoan, DateTime ngaysinh)
        {
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.sdt = sdt;
            this.diachi = diachi;
            this.loaitaikhoan = loaitaikhoan;
            this.ngaysinh = ngaysinh;
        }

        public TaiKhoanDTO(string tendangnhap, string hoten, string gioitinh, string sdt, string diachi, string loaitaikhoan, DateTime ngaysinh)
        {
            this.tendangnhap = tendangnhap;
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.sdt = sdt;
            this.diachi = diachi;
            this.loaitaikhoan = loaitaikhoan;
            this.ngaysinh = ngaysinh;
        }
    }
}
