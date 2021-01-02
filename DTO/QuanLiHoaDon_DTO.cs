using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuanLiHoaDon_DTO
    {
        private int iDHoaDon;
        private string tenBan;
        private string tinhTrangThanhToan;
        private DateTime ngayThanhToan;
        private string soTien;

        public int IDHoaDon { get => iDHoaDon; set => iDHoaDon = value; }
        public string TenBan { get => tenBan; set => tenBan = value; }
        public string TinhTrangThanhToan { get => tinhTrangThanhToan; set => tinhTrangThanhToan = value; }
        public DateTime NgayThanhToan { get => ngayThanhToan; set => ngayThanhToan = value; }
        public string SoTien { get => soTien; set => soTien = value; }

        public QuanLiHoaDon_DTO()
        {

        }

    }
}
