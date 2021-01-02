using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhomMonAn_DTO
    {
        private string maNhomMonAn;
        private string tenNhomMonAn;

        public string MaNhomMonAn { get => maNhomMonAn; set => maNhomMonAn = value; }
        public string TenNhomMonAn { get => tenNhomMonAn; set => tenNhomMonAn = value; }
    }
}
