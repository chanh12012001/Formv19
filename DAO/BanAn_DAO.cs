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
    public class BanAn_DAO
    {
        static SQLiteConnection conn;

        public static List<BanAn_DTO> LayBanAn()
        {
            string QueryString = "Select * From BanAn";
            conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.LayDataTable(QueryString, conn);
            if (dt.Rows.Count == 0)
                return null;
            List<BanAn_DTO> lstBanAn = new List<BanAn_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BanAn_DTO banAn = new BanAn_DTO();

                banAn.ID = int.Parse(dt.Rows[i]["ID"].ToString());
                banAn.TenBan = dt.Rows[i]["TenBan"].ToString();
                banAn.TrangThai = dt.Rows[i]["TrangThai"].ToString();

                lstBanAn.Add(banAn);
            }
            DataProvider.CloseConnection(conn);
            return lstBanAn;
        }

        public static int tableWidth = 90;
        public static int tableHeight = 90;

        // ------------  lấy id của món ăn dựa vào tên --------------------------
        public static int layIDBanAn(string tenBanAn)
        {
            string chuoiTruyVan = string.Format("Select BanAn.ID from BanAn where TenBan = '{0}'", tenBanAn);
            conn = DataProvider.OpenConnection();
            DataTable dtIDBanAn = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dtIDBanAn.Rows.Count == 0)
                return -1;
            int idBanAn = int.Parse(dtIDBanAn.Rows[0]["ID"].ToString());
            DataProvider.CloseConnection(conn);
            return idBanAn;
        }

        // sửa trạng thái bàn ăn thành trạng thái có người
        public static bool SuaTrangThaiBanAn(int idBan)
        {
            // chuỗi truy vấn thêm 1 hóa đơn vào bảng HoaDon
            string chuoiTruyVan = string.Format("Update BanAn Set TrangThai = 'Có Người' Where ID = {0}", idBan);
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

        // sửa thành trạng thái thành trống
        public static bool SuaTrangThaiBanAn2(int idBan)
        {
            // chuỗi truy vấn thêm 1 hóa đơn vào bảng HoaDon
            string chuoiTruyVan = string.Format("Update BanAn Set TrangThai = 'Trống' Where ID = {0}", idBan);
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

        // Thêm bàn ăn
        public static bool ThemBanAn(BanAn_DTO banAn)
        {
            // chuỗi truy vấn thêm 1 Ban An vào bảng Món Ăn
            string QueryString = string.Format("insert into BanAn(TenBan,TrangThai) values('{0}','{1}')", banAn.TenBan, banAn.TrangThai);
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

        // sửa bàn ăn
        public static bool SuaBanAn(BanAn_DTO banAn)
        {
            // chuỗi truy vấn sửa bàn ăn
            string QueryString = string.Format("Update BanAn Set TenBan = '{0}' Where ID = {1}", banAn.TenBan, banAn.ID);
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

        // xóa bàn ăn
        public static bool XoaBanAn(BanAn_DTO banAn)
        {
            // chuỗi truy vấn xóa 1 hàng trong bảng ban
            string QueryString = string.Format("Delete from BanAn Where ID = {0}", banAn.ID);
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

        // tìm bàn ăn 
        public static List<BanAn_DTO> TimBanAn(string tenBanAn)
        {
            string chuoiTruyVan = "Select * From BanAn where TenBan like '%" + tenBanAn + "%'";
            conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<BanAn_DTO> lstBanAn = new List<BanAn_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BanAn_DTO banAn = new BanAn_DTO();
                banAn.ID = int.Parse(dt.Rows[i]["ID"].ToString());
                banAn.TenBan = dt.Rows[i]["TenBan"].ToString();
                banAn.TrangThai = dt.Rows[i]["TrangThai"].ToString();

                lstBanAn.Add(banAn);
            }
            DataProvider.CloseConnection(conn);
            return lstBanAn;
        }
    }
}
