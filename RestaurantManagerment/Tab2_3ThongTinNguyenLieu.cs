using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Text.RegularExpressions;
using System.Data.SQLite;
using DAO;

namespace RestaurantManagerment
{
    public partial class Tab2_3ThongTinNguyenLieu : UserControl
    {
        public Tab2_3ThongTinNguyenLieu()
        {
            InitializeComponent();
            txtSoLuong.ReadOnly = true;
        }
        List<int> ID = new List<int>();
        List<NguyenLieu_DTO> dsnguyenlieu;
        DataGridViewRow drvNL;
        private void LoadNguyenLieu()
        {
            

            dsnguyenlieu = NguyenLieu_BUS.LoadNguyenLieu();
            if (dsnguyenlieu != null)
            {
                foreach (NguyenLieu_DTO nl in dsnguyenlieu)
                {
                    ID.Add(nl.MaNL);
                }
            }
            dtgrvDanhSachNL.DataSource = dsnguyenlieu;

            if (dsnguyenlieu == null)
                return;

            dtgrvDanhSachNL.Columns["MaNL"].HeaderText = "Mã Nguyên Liệu";
            dtgrvDanhSachNL.Columns["TenNL"].HeaderText = "Tên Nguyên Liệu";
            dtgrvDanhSachNL.Columns["Donvi"].HeaderText = "Đơn Vị";
            dtgrvDanhSachNL.Columns["Soluong"].HeaderText = "Số Lượng";


            for (int i = 0; i < 3; i++) dtgrvDanhSachNL.AutoResizeColumn(i);

        }
        //----------------- chuẩn hóa chuỗi ---------------------------------
        public static string ChuanHoaChuoi(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
        public void DsSoluong()
        {
            SQLiteConnection conn = DataProvider.OpenConnection();
            string query = "Select SoLuong From DsPhieuNhap Where MaNL=2 " ;
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            cmd.CommandText = query;

            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtSoLuong.Text = dr["SoLuong"].ToString();
                

            }
        }
        // Button thêm
        private void gABThem_Click(object sender, EventArgs e)
        {
            if (txtTenNL.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên nguyên liệu !");
                return;
            }
            if (txtDonVi.Text == "")
            {
                MessageBox.Show("Vui Lòng nhập đơn vị tính !");
                return;
            }
            
            

            NguyenLieu_DTO nguyenlieu = new NguyenLieu_DTO();
            nguyenlieu.TenNL = txtTenNL.Text;
            nguyenlieu.Donvi = txtDonVi.Text.ToString();
            nguyenlieu.Soluong = int.Parse(txtSoLuong.Text.ToString());
            
            if (dsnguyenlieu != null)
            {
                for (int i = 0; i < dsnguyenlieu.Count; i++)
                {
                    if (ChuanHoaChuoi(nguyenlieu.TenNL.ToLower()) == ChuanHoaChuoi(dsnguyenlieu[i].TenNL.ToLower()))
                    {
                        MessageBox.Show("Nguyên Liệu đã có rồi !");
                        return;
                    }
                }
            }
            if (NguyenLieu_BUS.ThemNguyenLieu(nguyenlieu))
            {
                LoadNguyenLieu();
                MessageBox.Show("Đã Thêm");
                return;
            }
            MessageBox.Show("Thêm thất bại !");
        }
        // sự kiện click vào 1 dòng
        private void dtgrvDanhSachNL_Click(object sender, EventArgs e)
        {
            try
            {
                drvNL = dtgrvDanhSachNL.SelectedRows[0];
            }
            catch (Exception)
            {
                return;
            }
            if (drvNL.Cells["MaNL"].Value.ToString() != "0001")
            {
                txtTenNL.Text = drvNL.Cells["TenNL"].Value.ToString();
                txtDonVi.Text = drvNL.Cells["Donvi"].Value.ToString();
                DsSoluong();
                

            }
        }

        private void Tab2_3ThongTinNguyenLieu_Load(object sender, EventArgs e)
        {
            LoadNguyenLieu();
        }

        private void gABCapNhat_Click(object sender, EventArgs e)
        {
            if (drvNL == null)
            {
                MessageBox.Show("Chọn Món Ăn Muốn Sửa");
                return;
            }

            NguyenLieu_DTO nguyenLieu = new NguyenLieu_DTO();

            nguyenLieu.MaNL = int.Parse(drvNL.Cells["MaNL"].Value.ToString());
            nguyenLieu.TenNL = txtTenNL.Text;
            nguyenLieu.Donvi = txtDonVi.Text;
            nguyenLieu.Soluong = int.Parse(txtSoLuong.Text);
            

            if (NguyenLieu_BUS.SuaNguyenLieu(nguyenLieu))
            {

                drvNL = null;
                txtTenNL.Text = "";
                txtDonVi.Text = "";
                txtSoLuong.Text = "";

                LoadNguyenLieu();
                MessageBox.Show("Sửa thành công");
                return;
            }
            MessageBox.Show("Sửa thất bại");
        }

        private void gABXoa_Click(object sender, EventArgs e)
        {
            if (drvNL == null)
            {
                MessageBox.Show("Chọn món ăn muốn xóa");
                return;
            }

            NguyenLieu_DTO nguyenLieu = new NguyenLieu_DTO();
            nguyenLieu.TenNL = txtTenNL.Text;
            nguyenLieu.Donvi = txtDonVi.Text;
            nguyenLieu.Soluong = int.Parse(txtSoLuong.Text);


            if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dsnguyenlieu == null)
                    dtgrvDanhSachNL.DataSource = null;
                if (NguyenLieu_BUS.XoaNguyenLieu(nguyenLieu))
                {
                    drvNL = null;
                    txtTenNL.Text = "";
                    txtDonVi.Text = "";
                    txtSoLuong.Text = "";                                     
                    LoadNguyenLieu();
                    MessageBox.Show("Xóa thành công");
                    return;
                }
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            List<NguyenLieu_DTO> ketQua = NguyenLieu_BUS.TimNguyenLieu(txtTimKiem.Text);
            if (ketQua == null)
                return;
            dtgrvDanhSachNL.DataSource = ketQua;
        }
    }
}
