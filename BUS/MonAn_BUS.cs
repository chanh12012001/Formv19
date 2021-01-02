using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Drawing;
namespace BUS
{
    public class MonAn_BUS
    {
        public static List<MonAn_DTO> LoadMonAn()
        {
            return MonAn_DAO.LoadMonAn();
        }
        public static bool ThemMonAn(MonAn_DTO monAn)
        {
            return MonAn_DAO.ThemMonAn(monAn);
        }
        public static bool SuaMonAn(MonAn_DTO monAn)
        {
            return MonAn_DAO.SuaMonAn(monAn);
        }
        public static bool XoaMonAn(MonAn_DTO monAn)
        {
            return MonAn_DAO.XoaMonAn(monAn);
        }
        public static int layIDMonAn(string tenMonAn)
        {
            return MonAn_DAO.layIDMonAn(tenMonAn);
        }
        public static List<MonAn_DTO> TimMonAn(string tenMonAn)
        {
            return MonAn_DAO.TimMonAn(tenMonAn);
        }
        public static List<MonAn_DTO> LocMonAnTheoNhom(string tenNhomMon)
        {
            return MonAn_DAO.LocNhomMonAn(tenNhomMon);
        }
    }
}
