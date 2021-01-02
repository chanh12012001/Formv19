using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class NhomMonAn_DAO
    {
        static SQLiteConnection conn;
        public static List<NhomMonAn_DTO> LayNhomMonAn()
        {
            string QueryString = "Select * From NhomMon";
            conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.LayDataTable(QueryString, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<NhomMonAn_DTO> danhSachNhomMonAn = new List<NhomMonAn_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhomMonAn_DTO nhomMonAn = new NhomMonAn_DTO();

                nhomMonAn.MaNhomMonAn = dt.Rows[i]["MaNhom"].ToString();
                nhomMonAn.TenNhomMonAn = dt.Rows[i]["TenNhom"].ToString();

                danhSachNhomMonAn.Add(nhomMonAn);
            }
            DataProvider.CloseConnection(conn);
            return danhSachNhomMonAn;
        }

        // ------------  lấy id của nhóm món ăn dựa vào tên --------------------------
        public static string layIDNhomMonAn(string tenNhomMonAn)
        {
            string QueryString = string.Format("Select MaNhom from NhomMon where TenNhom = '{0}'", tenNhomMonAn);
            conn = DataProvider.OpenConnection();
            DataTable dtIDNhomMonAn = DataProvider.LayDataTable(QueryString, conn);
            if (dtIDNhomMonAn.Rows.Count == 0)
                return "";
            string idNhomMonAn = dtIDNhomMonAn.Rows[0]["MaNhom"].ToString();
            DataProvider.CloseConnection(conn);
            return idNhomMonAn;
        }

        // ------------  lấy tên của nhóm món ăn dựa vào MaNhomMon --------------------------
        public static string layTenNhomMonAn(string maNhomMonAn)
        {
            string QueryString = string.Format("Select NhomMon.TenNhom from MonAn, NhomMon where NhomMon.MaNhom = '{0}'", maNhomMonAn);
            conn = DataProvider.OpenConnection();
            DataTable dttenNhomMonAn = DataProvider.LayDataTable(QueryString, conn);
            if (dttenNhomMonAn.Rows.Count == 0)
                return "";
            string tenNhomMonAn = dttenNhomMonAn.Rows[0]["TenNhom"].ToString();
            DataProvider.CloseConnection(conn);
            return tenNhomMonAn;
        }

        // Thêm nhom mon ăn
        public static bool ThemNhomMonAn(NhomMonAn_DTO nhomMonAn)
        {
            // chuỗi truy vấn thêm 1 Nhom mon An vào bảng nhom Món Ăn
            string QueryString = string.Format("insert into NhomMon(MaNhom,TenNhom) values('{0}','{1}')", nhomMonAn.MaNhomMonAn, nhomMonAn.TenNhomMonAn);
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

        // sửa Nhóm Món Ăn
        public static bool SuaNhomMonAn(NhomMonAn_DTO nhomMonAn)
        {
            // chuỗi truy vấn sửa nhóm Món ăn
            string QueryString = string.Format("update NhomMon set TenNhom = '{0}' where MaNhom = '{1}'", nhomMonAn.TenNhomMonAn, nhomMonAn.MaNhomMonAn);
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

        // xóa Nhóm Món Ăn
        public static bool XoaNhomMonAn(NhomMonAn_DTO nhomMonAn)
        {
            // chuỗi truy vấn xóa 1 hàng trong bảng Nhóm Món
            string QueryString = string.Format("Delete from NhomMon Where MaNhom = '{0}'", nhomMonAn.MaNhomMonAn);
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

        // ---------------- tìm kiếm nhóm món ăn ---------------------------
        public static List<NhomMonAn_DTO> TimNhomMonAn(string tenNhomMonAn)
        {
            string QueryString = string.Format("select * from NhomMon where TenNhom like '%" + tenNhomMonAn + "%'");
            conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.LayDataTable(QueryString, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<NhomMonAn_DTO> lstNhomMonAn = new List<NhomMonAn_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhomMonAn_DTO nhomMonAn = new NhomMonAn_DTO();

                nhomMonAn.MaNhomMonAn = dt.Rows[i]["MaNhom"].ToString();
                nhomMonAn.TenNhomMonAn = dt.Rows[i]["TenNhom"].ToString();
                lstNhomMonAn.Add(nhomMonAn);
            }
            DataProvider.CloseConnection(conn);
            return lstNhomMonAn;
        }
    }
}
