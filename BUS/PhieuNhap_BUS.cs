using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuNhap_BUS
    {
        public static List<PhieuNhap_DTO> LoadPhieuNhap()
        {
            return DSphieunhap_DAO.LoadPhieuNhap();
        }
        public static List<PhieuNhap_DTO> LocPhieuNhap(DateTime checkin, DateTime checkout)
        {
            return DSphieunhap_DAO.LocPhieuNhap(checkin,checkout);
        }
        public static bool ThemPhieuNhap(PhieuNhap_DTO phieunhap)
        {
            return DSphieunhap_DAO.ThemPhieuNhap(phieunhap);
        }
        public static bool XoaPhieuNhap(PhieuNhap_DTO phieunhap)
        {
            return DSphieunhap_DAO.XoaPhieuNhap(phieunhap);
        }
    }
}
