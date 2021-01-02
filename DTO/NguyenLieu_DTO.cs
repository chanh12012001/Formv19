using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguyenLieu_DTO
    {
        private int maNL;
        private string tenNL;
        private string donvi;
        private int soluong;

        public int MaNL { get => maNL; set => maNL = value; }
        public string TenNL { get => tenNL; set => tenNL = value; }
        public string Donvi { get => donvi; set => donvi = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        
    }
}
