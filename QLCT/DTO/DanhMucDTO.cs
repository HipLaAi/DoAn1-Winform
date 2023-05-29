using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCT.DTO
{
    class DanhMucDTO
    {
        string tendanhmuc;

        string madanhmuc;

        public string Tendanhmuc { get => tendanhmuc; set => tendanhmuc = value; }
        public string Madanhmuc { get => madanhmuc; set => madanhmuc = value; }

        public DanhMucDTO() { }

        public DanhMucDTO(string tendanhmuc, string madanhmuc)
        {
            this.tendanhmuc = tendanhmuc;
            this.madanhmuc = madanhmuc;
        }
    }
}
