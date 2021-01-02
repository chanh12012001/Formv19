using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhap_DTO
    {
        private int maPN;
        private int maNL;
        private string tenNL;
        private string donVi;
        private int soluong;
        private int dongia;
        private DateTime ngaynhap;
        private string donvicungcap;
        private string thukho;

        public int MaPN { get => maPN; set => maPN = value; }
        public int MaNL { get => maNL; set => maNL = value; }
        public string TenNL { get => tenNL; set => tenNL = value; }
        public string DonVi { get => donVi; set => donVi = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Dongia { get => dongia; set => dongia = value; }
        public DateTime Ngaynhap { get => ngaynhap; set => ngaynhap = value; }
        public string Donvicungcap { get => donvicungcap; set => donvicungcap = value; }
        public string Thukho { get => thukho; set => thukho = value; }
    }
}
