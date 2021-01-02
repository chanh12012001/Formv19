using BUS;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagerment
{
    public partial class Tab3_2QuanLiTaiKhoan : UserControl
    {
        string TaiKhoangDN;
        public Tab3_2QuanLiTaiKhoan(string TKDN)
        {
            TaiKhoangDN = TKDN;
            InitializeComponent();
        }
        DataGridViewRow drvTK;
        private void cbLoaiTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        List<TaiKhoan_DTO> dstaikhoan;

        private void LoadTaiKhoan()
        {
            if (TaiKhoangDN.Substring(0, 2) == "NV")
            {
                dstaikhoan = TaiKhoan_BUS.LoadTK(TaiKhoangDN);
            }
            else dstaikhoan = TaiKhoan_BUS.LoadTK();
            dtgrvDanhTaiKhoan.DataSource = dstaikhoan;

            if (dstaikhoan == null)
                return;
            dtgrvDanhTaiKhoan.Columns["TenTK"].HeaderText = "Tài Khoản";
            dtgrvDanhTaiKhoan.Columns["MatKhau"].HeaderText = "Mật Khẩu";
            dtgrvDanhTaiKhoan.Columns["LoaiTK"].HeaderText = "Loại Tài Khoản";
            for (int i = 0; i < 3; i++) dtgrvDanhTaiKhoan.AutoResizeColumn(i);

        }
        //Button sửa
        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            if (drvTK == null)
            {
                MessageBox.Show("Chọn tài khoản muốn cập nhật");
                return;
            }

            TaiKhoan_DTO taikhoan = new TaiKhoan_DTO();
            taikhoan.Matkhau = txtMatKhau.Text;
            taikhoan.Tentk = txtTenTaiKhoan.Text;
            if (TaiKhoan_BUS.SuaTaiKhoan(taikhoan))
            {
                drvTK = null;
                txtTenTaiKhoan.Text = "";
                txtMatKhau.Text = "";
                LoadTaiKhoan();
                MessageBox.Show("Sửa thành công");

            }
            else MessageBox.Show("Sửa thất bại");
            return;
        }


        // sự kiện click vào 1 dòng
        private void dtgrvDanhTaiKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                drvTK = dtgrvDanhTaiKhoan.SelectedRows[0];
            }
            catch (Exception)
            {
                return;
            }
            txtTenTaiKhoan.Text = drvTK.Cells["TenTK"].Value.ToString();
            txtMatKhau.Text = drvTK.Cells["MatKhau"].Value.ToString();
        }
        private void Tab3_2QuanLiTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadTaiKhoan();
        }
    }
}



