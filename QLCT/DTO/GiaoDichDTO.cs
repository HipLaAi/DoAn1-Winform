using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCT.DTO
{
    class GiaoDichDTO
    {
        public string maGiaoDich;

        public string maDanhMuc;

        public string maPhuongThucThanhToan;

        public int soTien;

        public string moTa;

        public DateTime ngayGiaoDich;

        public string MaGiaoDich { get => maGiaoDich; set => maGiaoDich = value; }
        public string MaDanhMuc { get => maDanhMuc; set => maDanhMuc = value; }
        public string MaPhuongThucThanhToan { get => maPhuongThucThanhToan; set => maPhuongThucThanhToan = value; }

        public int SoTien { get => soTien; set => soTien = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public DateTime NgayGiaoDich { get => ngayGiaoDich; set => ngayGiaoDich = value; }

        public GiaoDichDTO() { }

        public GiaoDichDTO(string maGiaoDich, string maDanhMuc, string maPhuongThucThanhToan, int soTien, string moTa, DateTime ngayGiaoDich)
        {
            this.maGiaoDich = maGiaoDich;

            this.maDanhMuc = maDanhMuc;

            this.maPhuongThucThanhToan = maPhuongThucThanhToan;

            this.soTien = soTien;

            this.moTa = moTa;

            this.ngayGiaoDich = ngayGiaoDich;
        }

        public GiaoDichDTO( string maDanhMuc, string maPhuongThucThanhToan, int soTien, string moTa, DateTime ngayGiaoDich)
        {
            this.maDanhMuc = maDanhMuc;

            this.maPhuongThucThanhToan = maPhuongThucThanhToan;

            this.soTien = soTien;

            this.moTa = moTa;

            this.ngayGiaoDich = ngayGiaoDich;
        }
    }
}
