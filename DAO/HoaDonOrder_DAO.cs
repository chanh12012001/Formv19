using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class HoaDonOrder_DAO
    {
        static SQLiteConnection conn;
        // load hoa don
        public static List<HoaDonOrder_DTO> LoadHoaDon(int idBan)
        {
            string chuoiTruyVan = "select HoaDonInFo.ID,MonAn.TenMonAn,HoaDonInFo.SoLuong,MonAn.Gia, (HoaDonInFo.SoLuong * MonAn.Gia) as ThanhTien from BanAn, HoaDon, MonAn, HoaDonInFo where HoaDonInFo.IDMonAn = MonAn.ID AND HoaDonInFo.IDHoaDon = HoaDon.ID and HoaDon.IDBan = BanAn.ID AND BanAn.ID = " + idBan;
            conn = DataProvider.OpenConnection();
            DataTable dtHoaDon = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dtHoaDon.Rows.Count == 0)
                return null;

            List<HoaDonOrder_DTO> lstHoaDon = new List<HoaDonOrder_DTO>();

            for (int i = 0; i < dtHoaDon.Rows.Count; i++)
            {
                HoaDonOrder_DTO hoaDon = new HoaDonOrder_DTO();
                hoaDon.ID = int.Parse(dtHoaDon.Rows[i]["ID"].ToString());
                hoaDon.TenMonAn = dtHoaDon.Rows[i]["TenMonAn"].ToString();
                hoaDon.SoLuong = int.Parse(dtHoaDon.Rows[i]["SoLuong"].ToString());
                hoaDon.Gia = int.Parse(dtHoaDon.Rows[i]["Gia"].ToString());
                hoaDon.ThanhTien = int.Parse(dtHoaDon.Rows[i]["ThanhTien"].ToString());

                lstHoaDon.Add(hoaDon);
            }
            DataProvider.CloseConnection(conn);
            return lstHoaDon;
        }        

        // thêm hóa đơn
        public static bool ThemHoaDon(int idBan)
        {
            // chuỗi truy vấn thêm 1 hóa đơn vào bảng HoaDon
            string chuoiTruyVan = string.Format("insert into HoaDon(IDBan,TinhTrang) values({0},{1})", idBan, 0);
            conn = DataProvider.OpenConnection();
            try
            {
                DataProvider.ThucThiTruyVanNonQuery(chuoiTruyVan, conn);
                DataProvider.CloseConnection(conn);
                return true;
            }
            catch (Exception)
            {
                DataProvider.CloseConnection(conn);
                return false;
            }
        }

        // Lấy id của hóa đơn
        public static int layIDHoaDon(int iDban)
        {
            string chuoiTruyVan = "Select HoaDon.ID from BanAn,HoaDon where HoaDon.IDBan = " + iDban + " AND TinhTrang = 0";
            conn = DataProvider.OpenConnection();
            DataTable dtIDHoaDon = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dtIDHoaDon.Rows.Count == 0)
                return -1;
            int iDHoaHon = int.Parse(dtIDHoaDon.Rows[0]["ID"].ToString());
            DataProvider.CloseConnection(conn);
            return iDHoaHon;
        }

        // xóa hêt thông tin hóa đơn của bàn
        public static bool XoaThongTinHoaDon(int IDHoaDon)
        {
            // chuỗi truy vấn xóa thông tin hóa đơn
            string chuoiTruyVan = string.Format("Delete from HoaDonInFo where HoaDonInFo.IDHoaDon = {0}", IDHoaDon);
            conn = DataProvider.OpenConnection();
            try
            {
                DataProvider.ThucThiTruyVanNonQuery(chuoiTruyVan, conn);
                DataProvider.CloseConnection(conn);
                return true;
            }
            catch (Exception)
            {
                DataProvider.CloseConnection(conn);
                return false;
            }
        }

        // update số tiền cho hóa đơn
        public static bool UpdateHoaDon(int tinhTrang, string ngayThanhToan, int soTien, int idBan)
        {
            // chuỗi truy vấn update lại bảng hóa đơn
            string chuoiTruyVan = string.Format("Update HoaDon Set TinhTrang = {0}, NgayThanhToan = '{1}', SoTien = {2} Where IDBan = {3} AND TinhTrang = 0", tinhTrang, ngayThanhToan, soTien, idBan);
            conn = DataProvider.OpenConnection();
            try
            {
                DataProvider.ThucThiTruyVanNonQuery(chuoiTruyVan, conn);
                DataProvider.CloseConnection(conn);
                return true;
            }
            catch (Exception)
            {
                DataProvider.CloseConnection(conn);
                return false;
            }
        }

        // thêm thông tin cho hóa đơn
        public static bool ThemThongTinHoaDon(int iDHoaDon, int iDMonAn, int soLuong)
        {
            string chuoiTruyVan = string.Format("insert into HoaDonInFo(IDHoaDon,IDMonAn,SoLuong) values({0},{1},{2})", iDHoaDon, iDMonAn, soLuong);
            conn = DataProvider.OpenConnection();
            try
            {
                DataProvider.ThucThiTruyVanNonQuery(chuoiTruyVan, conn);
                DataProvider.CloseConnection(conn);
                return true;
            }
            catch (Exception)
            {
                DataProvider.CloseConnection(conn);
                return false;
            }
        }

        // cập nhật số lượng món ăn
        public static bool CapNhatSoLuongMonAn(int soLuong, int IDHoaDon, int IDMonAn)
        {
            // chuỗi truy vấn thêm 1 hóa đơn vào bảng HoaDon
            string chuoiTruyVan = string.Format("Update HoaDonInFo Set SoLuong = {0} Where IDHoaDon = {1} AND IDMonAn = {2}", soLuong, IDHoaDon, IDMonAn);
            conn = DataProvider.OpenConnection();
            try
            {
                DataProvider.ThucThiTruyVanNonQuery(chuoiTruyVan, conn);
                DataProvider.CloseConnection(conn);
                return true;
            }
            catch (Exception)
            {
                DataProvider.CloseConnection(conn);
                return false;
            }
        }

        // xóa món ăn khỏi hóa đơn
        public static bool XoaMonAn(int IDHoaDon, int IDMonAn)
        {
            // chuỗi truy vấn xóa 1 món ăn
            string chuoiTruyVan = string.Format("Delete from HoaDonInFo where HoaDonInFo.IDHoaDon = {0} AND HoaDonInFo.IDMonAn = {1}", IDHoaDon, IDMonAn);
            conn = DataProvider.OpenConnection();
            try
            {
                DataProvider.ThucThiTruyVanNonQuery(chuoiTruyVan, conn);
                DataProvider.CloseConnection(conn);
                return true;
            }
            catch (Exception)
            {
                DataProvider.CloseConnection(conn);
                return false;
            }
        }

        // chuyển bàn 
        public static bool ChuyenBan(int idFromTable, int idToTable)
        {
            // chuỗi truy vấn update lại bảng hóa đơn
            string chuoiTruyVan = string.Format("Update HoaDon Set IDBan = {0} Where IDBan = {1} AND TinhTrang = 0", idToTable, idFromTable);
            conn = DataProvider.OpenConnection();
            try
            {
                DataProvider.ThucThiTruyVanNonQuery(chuoiTruyVan, conn);
                DataProvider.CloseConnection(conn);
                return true;
            }
            catch (Exception)
            {
                DataProvider.CloseConnection(conn);
                return false;
            }
        }
        public static List<QuanLiHoaDon_DTO> DanhSachHoaDon()
        {
            string chuoiTruyVan = "select HoaDon.ID,BanAn.TenBan,HoaDon.NgayThanhToan,HoaDon.SoTien from HoaDon,BanAn where HoaDon.IDBan = BanAn.ID AND TinhTrang = 1 ";
            conn = DataProvider.OpenConnection();
            DataTable dtHoaDon = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dtHoaDon.Rows.Count == 0)
                return null;

            List<QuanLiHoaDon_DTO> danhSachHoaDon = new List<QuanLiHoaDon_DTO>();

            for (int i = 0; i < dtHoaDon.Rows.Count; i++)
            {
                QuanLiHoaDon_DTO hoaDon = new QuanLiHoaDon_DTO();
                hoaDon.IDHoaDon = int.Parse(dtHoaDon.Rows[i]["ID"].ToString());
                hoaDon.TenBan = dtHoaDon.Rows[i]["TenBan"].ToString();
                hoaDon.TinhTrangThanhToan = "Đã thanh toán";
                string ngayTT =  dtHoaDon.Rows[i]["NgayThanhToan"].ToString();
                hoaDon.NgayThanhToan = DateTime.ParseExact(ngayTT, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                hoaDon.SoTien = dtHoaDon.Rows[i]["SoTien"].ToString();

                danhSachHoaDon.Add(hoaDon);
            }
            DataProvider.CloseConnection(conn);
            return danhSachHoaDon;
        }

        // lọc danh sách hóa đơn
        public static List<QuanLiHoaDon_DTO> LocHoaDon(string tuNgay, string denNgay)
        {
            string chuoiTruyVan = "select HoaDon.ID,BanAn.TenBan,HoaDon.NgayThanhToan,HoaDon.SoTien from HoaDon,BanAn where HoaDon.IDBan = BanAn.ID AND TinhTrang = 1 AND NgayThanhToan >= '" + tuNgay + "' AND NgayThanhToan <= '" + denNgay + "'";
            conn = DataProvider.OpenConnection();
            DataTable dtHoaDon = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dtHoaDon.Rows.Count == 0)
                return null;

            List<QuanLiHoaDon_DTO> danhSachHoaDon = new List<QuanLiHoaDon_DTO>();

            for (int i = 0; i < dtHoaDon.Rows.Count; i++)
            {
                QuanLiHoaDon_DTO hoaDon = new QuanLiHoaDon_DTO();
                hoaDon.IDHoaDon = int.Parse(dtHoaDon.Rows[i]["ID"].ToString());
                hoaDon.TenBan = dtHoaDon.Rows[i]["TenBan"].ToString();
                hoaDon.TinhTrangThanhToan = "Đã thanh toán";
                string ngayTT = dtHoaDon.Rows[i]["NgayThanhToan"].ToString();
                hoaDon.NgayThanhToan = DateTime.ParseExact(ngayTT, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                hoaDon.SoTien = dtHoaDon.Rows[i]["SoTien"].ToString();

                danhSachHoaDon.Add(hoaDon);
            }
            DataProvider.CloseConnection(conn);
            return danhSachHoaDon;
        }

        //-------------- Xóa Hóa Đơn ------------------
        public static bool XoaHoaDon(int IDHoaDon)
        {
            // chuỗi truy vấn xóa thông tin hóa đơn
            string chuoiTruyVan = string.Format("Delete from HoaDon where HoaDon.ID = {0}", IDHoaDon);
            conn = DataProvider.OpenConnection();
            try
            {
                DataProvider.ThucThiTruyVanNonQuery(chuoiTruyVan, conn);
                DataProvider.CloseConnection(conn);
                return true;
            }
            catch (Exception)
            {
                DataProvider.CloseConnection(conn);
                return false;
            }
        }
        public static bool XoaToanBoHoaDon()
        {
            // chuỗi truy vấn xóa toàn bộ dữ liệu bảng món ăn
            string chuoiTruyVan = string.Format("Delete from HoaDon");
            conn = DataProvider.OpenConnection();
            try
            {
                DataProvider.ThucThiTruyVanNonQuery(chuoiTruyVan, conn);
                DataProvider.CloseConnection(conn);
                return true;
            }
            catch (Exception)
            {
                DataProvider.CloseConnection(conn);
                return false;
            }
        }
    }
}
