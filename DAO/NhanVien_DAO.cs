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
    public class NhanVien_DAO
    {
        static SQLiteConnection conn;
        public static List<NhanVien_DTO> LoadNhanVien()
        {
            string QueryString = "Select * From NhanVien";
            conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.LayDataTable(QueryString, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<NhanVien_DTO> danhSachNhanVien = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nhanVien = new NhanVien_DTO();

                nhanVien.MaNhanVien = dt.Rows[i]["MaNV"].ToString();
                nhanVien.TenNhanVien = dt.Rows[i]["Họ và tên"].ToString();
                nhanVien.NgaySinh = dt.Rows[i]["Ngày sinh"].ToString();
                nhanVien.GioiTinh = dt.Rows[i]["Giới tính"].ToString();
                nhanVien.SoDienThoai = dt.Rows[i]["Số điện thoại"].ToString();
                nhanVien.ChucVu = dt.Rows[i]["Chức vụ"].ToString();
                nhanVien.Luong = dt.Rows[i]["Lương"].ToString();
                nhanVien.DiaChi = dt.Rows[i]["Địa chỉ"].ToString();

                danhSachNhanVien.Add(nhanVien);
            }
            DataProvider.OpenConnection();
            return danhSachNhanVien;
        }

        //------------- thêm nhân viên ---------------
        public static bool ThemNhanVien(NhanVien_DTO nhanVien)
        {
            // chuỗi truy vấn thêm 1 món ăn vào bảng Món Ăn
            string QueryString = $" INSERT INTO NhanVien ([Địa chỉ],[Lương],[Chức vụ],[Số điện thoại],[Giới tính],[Ngày sinh],[Họ và tên],MaNV) "
                + $"VALUES('{nhanVien.DiaChi}','{nhanVien.Luong}','{nhanVien.ChucVu}','{nhanVien.SoDienThoai}','{nhanVien.GioiTinh}','{nhanVien.NgaySinh}','{nhanVien.TenNhanVien}','{nhanVien.MaNhanVien}'); ";
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
        //------------------------ sửa nhân viên ---------------------------------
        public static bool SuaNhanVien(NhanVien_DTO nhanVien)
        {
            // chuỗi truy vấn sửa món ăn
            string QueryString = string.Format("UPDATE NhanVien set [Họ và tên]='{0}', [Ngày sinh]='{1}', [Giới tính]='{2}', [Số điện thoại]='{3}', [Chức vụ]='{4}', [Lương]='{5}', [Địa chỉ]='{6}' where MaNV='{7}'", nhanVien.TenNhanVien, nhanVien.NgaySinh, nhanVien.GioiTinh, nhanVien.SoDienThoai, nhanVien.ChucVu, nhanVien.Luong, nhanVien.DiaChi, nhanVien.MaNhanVien);
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

       //---------------- xóa nhân viên ---------------------------------
        public static bool XoaNhanVien(NhanVien_DTO nhanVien)
        {
            // chuỗi truy vấn nhân viên
            string QueryString = string.Format("DELETE FROM NhanVien where MaNV ='{0}'", nhanVien.MaNhanVien);
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

        // ---------------- tìm kiếm nhân viên ---------------------------
        public static List<NhanVien_DTO> TimNhanVien(string tenNhanVien)
        {
            string QueryString = string.Format("select * from NhanVien where  [Họ và tên] like '%" + tenNhanVien + "%'");
            conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.LayDataTable(QueryString, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<NhanVien_DTO> lstNhanVien = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nhanVien = new NhanVien_DTO();

                nhanVien.MaNhanVien = dt.Rows[i]["MaNV"].ToString();
                nhanVien.TenNhanVien = dt.Rows[i]["Họ và tên"].ToString();
                nhanVien.NgaySinh = dt.Rows[i]["Ngày sinh"].ToString();
                nhanVien.GioiTinh = dt.Rows[i]["Giới tính"].ToString();
                nhanVien.SoDienThoai = dt.Rows[i]["Số điện thoại"].ToString();
                nhanVien.ChucVu = dt.Rows[i]["Chức vụ"].ToString();
                nhanVien.Luong = dt.Rows[i]["Lương"].ToString();
                nhanVien.DiaChi = dt.Rows[i]["Địa chỉ"].ToString();

                lstNhanVien.Add(nhanVien);
            }
            DataProvider.CloseConnection(conn);
            return lstNhanVien;
        }
    }
}
