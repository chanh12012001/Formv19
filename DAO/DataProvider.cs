using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        public static SQLiteConnection OpenConnection()
        {
            //Lấy file path mà chương trình chạy(VD:C:\...\bai1\bin\debug
            string CurrentDirectory = System.Environment.CurrentDirectory;
            //Lấy file path đã bỏ đi bin\debug -> Đây là địa chỉ của toàn bộ project
            string CurrentProjectD = Directory.GetParent(CurrentDirectory).Parent.FullName;
            string QueryString = @"Data Source=" + CurrentProjectD + @"\Database\NHAHANG.db;";
            SQLiteConnection conn = new SQLiteConnection(QueryString);
            conn.Open();
            return conn;
        }

        public static void CloseConnection(SQLiteConnection conn)
        {
            conn.Close();
        }

        public static DataTable LayDataTable(string QueryString, SQLiteConnection conn)
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter(QueryString, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static bool ThucThiTruyVanNonQuery(string QueryString, SQLiteConnection conn)
        {
            try
            {
                SQLiteCommand cm = new SQLiteCommand(QueryString, conn);
                cm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static byte[] ImageToByte(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        }
        public static Image ByteToImage(byte[] imageBytes)
        {
            // Convert byte[] to Image
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);
            return image;
        }

        public static void SaveImage(byte[] pic, SQLiteConnection conn,string QueryString)
        {
            SQLiteCommand cmd = new SQLiteCommand(QueryString,conn);
            SQLiteParameter param = new SQLiteParameter("@0", System.Data.DbType.Binary);
            param.Value = pic;
            cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();
        }
        public static Image LoadImage(SQLiteConnection conn,string query)
        {
            byte[] a = null;
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            IDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (!(rdr[0] is System.DBNull))
                {
                    a = (System.Byte[])rdr[0];
                }
            }
            if (a != null)
                return ByteToImage(a);
            else return null;
        }

       
    }
}
