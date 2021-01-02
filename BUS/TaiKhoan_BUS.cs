using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TaiKhoan_BUS
    {
        public static List<TaiKhoan_DTO> LoadTK()
        {
            return TaiKhoan_DAO.LoadTaiKhoan();
        }
        public static bool ThemTaiKhoan(TaiKhoan_DTO taikhoan)
        {
            return TaiKhoan_DAO.ThemTaiKhoan(taikhoan);
        }
        public static bool SuaTaiKhoan(TaiKhoan_DTO taikhoan)
        {
            return TaiKhoan_DAO.SuaTaiKhoan(taikhoan);
        }
        public static bool XoaTaiKhoan(TaiKhoan_DTO taikhoan)
        {
            return TaiKhoan_DAO.XoaTaiKhoan(taikhoan);
        }
        public static List<TaiKhoan_DTO> LoadTK(string tenTK)
        {
            return TaiKhoan_DAO.LoadTaiKhoan(tenTK);
        }
    }
}
