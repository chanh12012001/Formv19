using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonAn_DTO
    {
        private int iD;
        private Image image;
        private string tenNhomMon;
        private string tenMonAn;
        private string donViTinh;
        private int gia;

        public int ID { get => iD; set => iD = value; }
        public string TenNhomMon { get => tenNhomMon; set => tenNhomMon = value; }
        public string TenMonAn { get => tenMonAn; set => tenMonAn = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public int Gia { get => gia; set => gia = value; }
        public Image IMAGE { get => image; set => image = value; }


        public MonAn_DTO()
        {

        }

        public MonAn_DTO(int ID, string TenMonAn, string DonViTinh, int Gia)
        {
            this.ID = ID;
            this.TenMonAn = TenMonAn;
            this.DonViTinh = DonViTinh;
            this.Gia = Gia;
        }
    }
}