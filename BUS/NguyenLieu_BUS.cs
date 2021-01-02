using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NguyenLieu_BUS
    {
        public static List<NguyenLieu_DTO> LoadNguyenLieu()
        {
            return NguyenLieu_DAO.LoadNguyenLieu();
        }
        public static bool ThemNguyenLieu(NguyenLieu_DTO nguyenlieu)
        {
            return NguyenLieu_DAO.ThemNguyenLieu(nguyenlieu);
        }
        public static bool SuaNguyenLieu(NguyenLieu_DTO nguyenlieu)
        {
            return NguyenLieu_DAO.SuaNguyenLieu(nguyenlieu);
        }
        public static bool XoaNguyenLieu(NguyenLieu_DTO nguyenlieu)
        {
            return NguyenLieu_DAO.XoaNguyenLieu(nguyenlieu);
        }
        public static List<NguyenLieu_DTO> TimNguyenLieu(string tenNguyenLieu)
        {
            return NguyenLieu_DAO.TimNguyenLieu(tenNguyenLieu);
        }
    }
}
