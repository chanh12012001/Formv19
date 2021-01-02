using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BanAn_DTO
    {
        private int iD;
        private string tenBan;
        private string trangThai;

        public int ID { get => iD; set => iD = value; }
        public string TenBan { get => tenBan; set => tenBan = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
