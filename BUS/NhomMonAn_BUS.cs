using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class NhomMonAn_BUS
    {
        public static List<NhomMonAn_DTO> LoadNhomMonAn()
        {
            return NhomMonAn_DAO.LayNhomMonAn();
        }
        public static bool ThemNhomMonAn(NhomMonAn_DTO nhomMonAn)
        {
            return NhomMonAn_DAO.ThemNhomMonAn(nhomMonAn);
        }
        public static bool SuaNhomMonAn(NhomMonAn_DTO nhomMonAn)
        {
            return NhomMonAn_DAO.SuaNhomMonAn(nhomMonAn);
        }
        public static bool XoaNhomMonAn(NhomMonAn_DTO nhomMonAn)
        {
            return NhomMonAn_DAO.XoaNhomMonAn(nhomMonAn);
        }
        public static List<NhomMonAn_DTO> TimNhomMonAn(string tenNhomMonAn)
        {
            return NhomMonAn_DAO.TimNhomMonAn(tenNhomMonAn);
        }
    }
}
