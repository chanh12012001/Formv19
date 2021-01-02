using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NguyenLieu_DAO
    {
        static SQLiteConnection conn;
        public static List<NguyenLieu_DTO> LoadNguyenLieu()
        {
            string chuoiTruyVan = "Select * From NguyenLieu ";
            conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<NguyenLieu_DTO> lstNguyenLieu = new List<NguyenLieu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NguyenLieu_DTO nguyenlieu = new NguyenLieu_DTO();
                nguyenlieu.MaNL = int.Parse(dt.Rows[i]["MaNL"].ToString());
                nguyenlieu.TenNL = dt.Rows[i]["TenNL"].ToString();
                nguyenlieu.Donvi = dt.Rows[i]["DonVi"].ToString();
                nguyenlieu.Soluong = int.Parse(dt.Rows[i]["SoLuong"].ToString());

                lstNguyenLieu.Add(nguyenlieu);
            }
            DataProvider.CloseConnection(conn);
            return lstNguyenLieu;
        }
        // ------------------------ thêm nguyên liệu -----------------------
        public static bool ThemNguyenLieu(NguyenLieu_DTO nguyenlieu)
        {
            
            string QueryString = string.Format("insert into NguyenLieu(TenNL,DonVi,SoLuong) values('{0}','{1}','{2}')",  nguyenlieu.TenNL, nguyenlieu.Donvi, nguyenlieu.Soluong);
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
        // sửa nguyên liệu
        public static bool SuaNguyenLieu(NguyenLieu_DTO nguyenlieu)
        {
            
            string QueryString = string.Format("update NguyenLieu set TenNL = '{0}',DonVi='{1}',SoLuong='{2}' where MaNL = '{3}'", nguyenlieu.TenNL, nguyenlieu.Donvi, nguyenlieu.Soluong, nguyenlieu.MaNL);
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
        public static bool XoaNguyenLieu(NguyenLieu_DTO nguyenlieu)
        {
            
            string QueryString = string.Format("Delete from NguyenLieu Where TenNL = '{0}'", nguyenlieu.TenNL);
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
        // ---------------- tìm kiếm nguyên liệu ---------------------------
        public static List<NguyenLieu_DTO> TimNguyenLieu(string tenNguyenLieu)
        {
            string QueryString = string.Format("select * from NguyenLieu where  TenNL like '%" + tenNguyenLieu + "%'");
            conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.LayDataTable(QueryString, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<NguyenLieu_DTO> lstNguyenLieu = new List<NguyenLieu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NguyenLieu_DTO nguyenlieu = new NguyenLieu_DTO();

                nguyenlieu.MaNL = int.Parse(dt.Rows[i]["MaNL"].ToString());
                nguyenlieu.TenNL = dt.Rows[i]["TenNL"].ToString();
                nguyenlieu.Donvi = dt.Rows[i]["DonVi"].ToString();
                nguyenlieu.Soluong = int.Parse(dt.Rows[i]["SoLuong"].ToString());

                lstNguyenLieu.Add(nguyenlieu);
            }
            DataProvider.CloseConnection(conn);
            return lstNguyenLieu;
        }
    }
}
