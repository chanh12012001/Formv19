using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Drawing;

namespace DAO
{
    public class MonAn_DAO
    {
        static SQLiteConnection conn;
        public static List<MonAn_DTO> LoadMonAn()
        {
            string chuoiTruyVan = "Select ID, TenMonAn, DonViTinh, Gia, TenNhom From MonAn, NhomMon where MaNhomMon = MaNhom order by ID ASC";
            conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<MonAn_DTO> lstMonAn = new List<MonAn_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MonAn_DTO monAn = new MonAn_DTO();
                monAn.ID = int.Parse(dt.Rows[i]["ID"].ToString());
                monAn.TenMonAn = dt.Rows[i]["TenMonAn"].ToString();
                monAn.DonViTinh = dt.Rows[i]["DonViTinh"].ToString();
                monAn.Gia = int.Parse(dt.Rows[i]["Gia"].ToString());
                monAn.TenNhomMon = dt.Rows[i]["TenNhom"].ToString();
                monAn.IMAGE = DataProvider.LoadImage(conn,$"select Image from MonAn where ID='{monAn.ID}'");
                lstMonAn.Add(monAn);
            }
            DataProvider.CloseConnection(conn);
            return lstMonAn;
        }
        // ------------------------ thêm món ăn -----------------------
        public static bool ThemMonAn(MonAn_DTO monAn)
        {
            string maNHOM = NhomMonAn_DAO.layIDNhomMonAn(monAn.TenNhomMon);;
            string QueryString = string.Format("insert into MonAn(MaNhomMon,TenMonAn,DonViTinh,Gia,Image) values('{0}','{1}','{2}','{3}',@0)", maNHOM, monAn.TenMonAn, monAn.DonViTinh, monAn.Gia,monAn.IMAGE);
            conn = DataProvider.OpenConnection();
            try
            {
                DataProvider.SaveImage(DataProvider.ImageToByte(monAn.IMAGE, System.Drawing.Imaging.ImageFormat.Jpeg), conn,QueryString);
                DataProvider.CloseConnection(conn);
                return true;
            }
            catch (Exception)
            {
                DataProvider.CloseConnection(conn);
                return false;
            }
        }
        // ------------  lấy id của món ăn dựa vào tên --------------------------
        public static int layIDMonAn(string tenMonAn)
        {
            string QueryString = string.Format("Select MonAn.ID from MonAn where TenMonAn = '{0}'", tenMonAn);
            conn = DataProvider.OpenConnection();
            DataTable dtIDMonAn = DataProvider.LayDataTable(QueryString, conn);
            if (dtIDMonAn.Rows.Count == 0)
                return -1;
            int idMonAn = int.Parse(dtIDMonAn.Rows[0]["ID"].ToString());
            DataProvider.CloseConnection(conn);
            return idMonAn;
        }

        //------------------------ sửa món ăn ---------------------------------
        public static bool SuaMonAn(MonAn_DTO monAn)
        {
            // chuỗi truy vấn sửa món ăn
            string maNHOM = NhomMonAn_DAO.layIDNhomMonAn(monAn.TenNhomMon);
            string QueryString = string.Format("UPDATE MonAn set MaNhomMon = '{0}', TenMonAn = '{1}', DonViTinh = '{2}', Gia = {3}, Image = @0 where ID = " + monAn.ID + "", maNHOM, monAn.TenMonAn, monAn.DonViTinh, monAn.Gia, monAn.IMAGE);
            conn = DataProvider.OpenConnection();
            try
            {
                DataProvider.SaveImage(DataProvider.ImageToByte(monAn.IMAGE, System.Drawing.Imaging.ImageFormat.Jpeg), conn, QueryString);
                DataProvider.CloseConnection(conn);
                return true;
            }
            catch (Exception)
            {
                DataProvider.CloseConnection(conn);
                return false;
            }
        }

        // xóa món ăn
        public static bool XoaMonAn(MonAn_DTO monAn)
        {
            // chuỗi truy vấn xóa 1 hàng trong bảng món Ăn
            string QueryString = string.Format("Delete from MonAn Where TenMonAn = '{0}'", monAn.TenMonAn);
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

        // ----------- tìm món ăn tên --------------------------
        public static List<MonAn_DTO> TimMonAn(string tenMonAn)
        {
            string chuoiTruyVan = "Select * From MonAn where TenMonAn like '%" + tenMonAn + "%'";
            conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<MonAn_DTO> lstMonAn = new List<MonAn_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MonAn_DTO monAn = new MonAn_DTO();
                monAn.ID = int.Parse(dt.Rows[i]["ID"].ToString());
                monAn.TenNhomMon = NhomMonAn_DAO.layTenNhomMonAn(dt.Rows[i]["MaNhomMon"].ToString());
                monAn.TenMonAn = dt.Rows[i]["TenMonAn"].ToString();
                monAn.DonViTinh = dt.Rows[i]["DonViTinh"].ToString();
                monAn.Gia = int.Parse(dt.Rows[i]["Gia"].ToString());
                monAn.IMAGE = DataProvider.LoadImage(conn, $"select Image from MonAn where ID='{monAn.ID}'");
                lstMonAn.Add(monAn);
            }
            DataProvider.CloseConnection(conn);
            return lstMonAn;
        }

        public static List<MonAn_DTO> LocNhomMonAn(string tenNhomMon)
        {
            string chuoiTruyVan = "Select * From MonAn where MaNhomMon like '%" + tenNhomMon + "%'";
            conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<MonAn_DTO> lstMonAn = new List<MonAn_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MonAn_DTO monAn = new MonAn_DTO();
                monAn.ID = int.Parse(dt.Rows[i]["ID"].ToString());
                monAn.TenNhomMon = NhomMonAn_DAO.layTenNhomMonAn(dt.Rows[i]["MaNhomMon"].ToString());
                monAn.TenMonAn = dt.Rows[i]["TenMonAn"].ToString();
                monAn.DonViTinh = dt.Rows[i]["DonViTinh"].ToString();
                monAn.Gia = int.Parse(dt.Rows[i]["Gia"].ToString());
                monAn.IMAGE = DataProvider.LoadImage(conn, $"select Image from MonAn where ID='{monAn.ID}'");
                lstMonAn.Add(monAn);
            }
            DataProvider.CloseConnection(conn);
            return lstMonAn;
        }
    }
}
