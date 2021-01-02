using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class HoaDonOrder_BUS
    {
        public static List<HoaDonOrder_DTO> LoadHoaDon(int idBan)
        {
            return HoaDonOrder_DAO.LoadHoaDon(idBan);
        }
        public static bool ThemHoaDon(int idBan)
        {
            return HoaDonOrder_DAO.ThemHoaDon(idBan);
        }

        public static int layIDHoaDon(int iDban)
        {
            return HoaDonOrder_DAO.layIDHoaDon(iDban);
        }

        public static bool UpdateHoaDon(int tinhTrang, string ngayThanhToan, int soTien, int idBan)
        {
            return HoaDonOrder_DAO.UpdateHoaDon(tinhTrang, ngayThanhToan, soTien, idBan);
        }

        public static bool XoaThongTinHoaDon(int IDHoaDon)
        {
            return HoaDonOrder_DAO.XoaThongTinHoaDon(IDHoaDon);
        }

        public static bool ThemThongTinHoaDon(int iDHoaDon, int iDMonAn, int soLuong)
        {
            return HoaDonOrder_DAO.ThemThongTinHoaDon(iDHoaDon, iDMonAn, soLuong);
        }

        public static bool CapNhatSoLuongMonAn(int soLuong, int IDHoaDon, int IDMonAn)
        {
            return HoaDonOrder_DAO.CapNhatSoLuongMonAn(soLuong, IDHoaDon, IDMonAn);
        }

        public static bool XoaMonAn(int IDHoaDon, int IDMonAn)
        {
            return HoaDonOrder_DAO.XoaMonAn(IDHoaDon, IDMonAn);
        }

        public static bool ChuyenBan(int idFromTable, int idToTable)
        {
            return HoaDonOrder_DAO.ChuyenBan(idFromTable, idToTable);
        }
        public static bool XoaToanBoHoaDon()
        {
            return HoaDonOrder_DAO.XoaToanBoHoaDon();
        }
        public static List<QuanLiHoaDon_DTO> DanhSachHoaDon()
        {
            return HoaDonOrder_DAO.DanhSachHoaDon();
        }

        // lọc hóa đơn
        public static List<QuanLiHoaDon_DTO> LocHoaDon(string tuNgay, string denNgay)
        {
            return HoaDonOrder_DAO.LocHoaDon(tuNgay, denNgay);
        }

        // xóa hóa đơn
        public static bool XoaHoaDon(int IDHoaDon)
        {
            return HoaDonOrder_DAO.XoaHoaDon(IDHoaDon);
        }
    }
}
