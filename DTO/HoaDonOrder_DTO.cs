using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonOrder_DTO
    {
        private int iD;
        private string tenMonAn;
        private int soLuong;
        private int gia;
        private int thanhTien;

        public int ID { get => iD; set => iD = value; }
        public string TenMonAn { get => tenMonAn; set => tenMonAn = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int Gia { get => gia; set => gia = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
