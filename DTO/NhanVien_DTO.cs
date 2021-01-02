using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        private string maNhanVien;
        private string tenNhanVien;
        private string ngaySinh;
        private string gioiTinh;
        private string soDienThoai;
        private string chucVu;
        private string luong;
        private string diaChi;

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string Luong { get => luong; set => luong = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }

        public NhanVien_DTO()
        {

        }
    }
}
