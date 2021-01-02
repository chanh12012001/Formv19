using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DSphieunhap_DAO
    {
        static SQLiteConnection conn;
        public static List<PhieuNhap_DTO> LoadPhieuNhap()
        {
            string chuoiTruyVan = "Select DsPhieuNhap.MaPN,DsPhieuNhap.MaNL,NguyenLieu.TenNL,NguyenLieu.DonVi,NguyenLieu.SoLuong,DsPhieuNhap.DonGia,DsPhieuNhap.NgayNhap,DsPhieuNhap.CungCap,DsPhieuNhap.ThuKho From DsPhieuNhap,NguyenLieu Where DsPhieuNhap.MaNL = NguyenLieu.MaNL";
            conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<PhieuNhap_DTO> lstPhieuNhap = new List<PhieuNhap_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhieuNhap_DTO phieunhap = new PhieuNhap_DTO();
                phieunhap.MaPN = int.Parse(dt.Rows[i]["MaPN"].ToString());
                phieunhap.MaNL = int.Parse(dt.Rows[i]["MaNL"].ToString());
                phieunhap.TenNL = dt.Rows[i]["TenNL"].ToString();
                phieunhap.DonVi = dt.Rows[i]["DonVi"].ToString();
                phieunhap.Soluong = int.Parse(dt.Rows[i]["Soluong"].ToString());
                phieunhap.Dongia = int.Parse(dt.Rows[i]["Dongia"].ToString());
                phieunhap.Ngaynhap = DateTime.ParseExact(dt.Rows[i]["NgayNhap"].ToString(), "dd/MM/yyyy hh:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                phieunhap.Donvicungcap = dt.Rows[i]["CungCap"].ToString();
                phieunhap.Thukho = dt.Rows[i]["ThuKho"].ToString();

                lstPhieuNhap.Add(phieunhap);
            }
            DataProvider.CloseConnection(conn);
            return lstPhieuNhap;
        }
        public static List<PhieuNhap_DTO> LocPhieuNhap(DateTime checkin , DateTime checkout)
        {
            string chuoiTruyVan = string.Format("Select DsPhieuNhap.MaPN,DsPhieuNhap.MaNL,NguyenLieu.TenNL,NguyenLieu.DonVi,NguyenLieu.SoLuong,DsPhieuNhap.DonGia,DsPhieuNhap.NgayNhap,DsPhieuNhap.CungCap,DsPhieuNhap.ThuKho From DsPhieuNhap,NguyenLieu Where DsPhieuNhap.MaNL = NguyenLieu.MaNL AND DsPhieuNhap.NgayNhap >= '{0}' AND DsPhieuNhap.NgayNhap <= '{1}'",checkin,checkout);
            conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<PhieuNhap_DTO> lstPhieuNhap = new List<PhieuNhap_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhieuNhap_DTO phieunhap = new PhieuNhap_DTO();
                phieunhap.MaPN = int.Parse(dt.Rows[i]["MaPN"].ToString());
                phieunhap.MaNL = int.Parse(dt.Rows[i]["MaNL"].ToString());
                phieunhap.TenNL = dt.Rows[i]["TenNL"].ToString();
                phieunhap.DonVi = dt.Rows[i]["DonVi"].ToString();
                phieunhap.Soluong = int.Parse(dt.Rows[i]["Soluong"].ToString());
                phieunhap.Dongia = int.Parse(dt.Rows[i]["Dongia"].ToString());
                phieunhap.Ngaynhap = DateTime.Parse(dt.Rows[i]["NgayNhap"].ToString());
                phieunhap.Donvicungcap = dt.Rows[i]["CungCap"].ToString();
                phieunhap.Thukho = dt.Rows[i]["ThuKho"].ToString();

                lstPhieuNhap.Add(phieunhap);
            }
            DataProvider.CloseConnection(conn);
            return lstPhieuNhap;
        }
        // ------------------------ thêm món ăn -----------------------
        public static bool ThemPhieuNhap(PhieuNhap_DTO phieunhap)
        {

            string QueryString = string.Format("insert into DsPhieuNhap(MaNL,TenNL,DonVi,SoLuong,DonGia,NgayNhap,CungCap,ThuKho) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",phieunhap.MaNL ,phieunhap.TenNL, phieunhap.DonVi, phieunhap.Soluong, phieunhap.Dongia, phieunhap.Ngaynhap, phieunhap.Donvicungcap, phieunhap.Thukho);
            conn = DataProvider.OpenConnection();
            try
            {
                DataProvider.ThucThiTruyVanNonQuery(QueryString, conn);
                DataProvider.CloseConnection(conn);
                return true;
            }
            catch (Exception)
            {
                DataProvider.CloseConnection(conn);
                return false;
            }
        }      
        

        // xóa nguyên liệu
        public static bool XoaPhieuNhap(PhieuNhap_DTO phieunhap)
        {

            string QueryString = string.Format("Delete from DsPhieuNhap Where MaPN = '{0}'", phieunhap.MaPN);
            conn = DataProvider.OpenConnection();
            try
            {
                DataProvider.ThucThiTruyVanNonQuery(QueryString, conn);
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
