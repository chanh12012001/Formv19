using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class NhanVien_BUS
    {
        public static List<NhanVien_DTO> LoadNhanVien()
        {
            return NhanVien_DAO.LoadNhanVien();
        }
        public static bool ThemNhanVien(NhanVien_DTO nhanVien)
        {
            return NhanVien_DAO.ThemNhanVien(nhanVien);
        }
        public static bool SuaNhanVien(NhanVien_DTO nhanVien)
        {
            return NhanVien_DAO.SuaNhanVien(nhanVien);
        }
        public static bool XoaNhanVien(NhanVien_DTO nhanVien)
        {
            return NhanVien_DAO.XoaNhanVien(nhanVien);
        }
        public static List<NhanVien_DTO> TimNhanVien(string tenNhanVien)
        {
            return NhanVien_DAO.TimNhanVien(tenNhanVien);
        }
    }
}
