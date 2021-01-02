using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class BanAn_BUS
    {
        public static List<BanAn_DTO> LoadBanAn()
        {
            return BanAn_DAO.LayBanAn();
        }

        public static int layIDBanAn(string tenBanAn)
        {
            return BanAn_DAO.layIDBanAn(tenBanAn);
        }

        public static bool SuaTrangThaiBanAn(int idBan)
        {
            return BanAn_DAO.SuaTrangThaiBanAn(idBan);
        }

        public static bool SuaTrangThaiBanAn2(int idBan)
        {
            return BanAn_DAO.SuaTrangThaiBanAn2(idBan);
        }

        public static bool ThemBanAn(BanAn_DTO banAn)
        {
            return BanAn_DAO.ThemBanAn(banAn);
        }

        public static bool XoaBanAn(BanAn_DTO banAn)
        {
            return BanAn_DAO.XoaBanAn(banAn);
        }

        public static bool SuaBanAn(BanAn_DTO banAn)
        {
            return BanAn_DAO.SuaBanAn(banAn);
        }
        public static List<BanAn_DTO> TimBanAn(string tenBanAn)
        {
            return BanAn_DAO.TimBanAn(tenBanAn);
        }
    }
}
