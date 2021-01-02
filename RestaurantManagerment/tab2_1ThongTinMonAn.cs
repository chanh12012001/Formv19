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
using DAO;
using BUS;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.IO;

namespace RestaurantManagerment
{
    public partial class tab2_1ThongTinMonAn : UserControl
    {
        public tab2_1ThongTinMonAn()
        {
            InitializeComponent();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {

            //UpLoad Image Từ Máy Tính
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private List<NhomMonAn_DTO> listNhomMonAn;
        private void LoadNhomMonAn()
        {
            listNhomMonAn = NhomMonAn_DAO.LayNhomMonAn();
            for (int i = 0; i < listNhomMonAn.Count; i++)
            {
                string str = listNhomMonAn[i].TenNhomMonAn;
                cbNhomMon.Items.Add(str);
                cbFillNhomMon.Items.Add(str);
            }
        }

        private void tab2_1ThongTinMonAn_Load(object sender, EventArgs e)
        {
            this.Controls.Add(this.dtgrvDanhSachMonAn);
            LoadNhomMonAn();
            LoadMonAn();
        }

        List<MonAn_DTO> lstMonAn;
        private void LoadMonAn()
        {
            lstMonAn = MonAn_BUS.LoadMonAn();
            dtgrvDanhSachMonAn.DataSource = lstMonAn;

            if (lstMonAn == null)
                return;


            dtgrvDanhSachMonAn.Columns["ID"].HeaderText = "ID";
            dtgrvDanhSachMonAn.Columns["TenNhomMon"].HeaderText = "Tên Nhóm Món";
            dtgrvDanhSachMonAn.Columns["TenMonAn"].HeaderText = "Tên Món";
            dtgrvDanhSachMonAn.Columns["DonViTinh"].HeaderText = "Đơn Vị Tính";
            dtgrvDanhSachMonAn.Columns["Gia"].HeaderText = "Giá";
        }

        //----------------- chuẩn hóa chuỗi ---------------------------------
        public static string ChuanHoaChuoi(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        //--------------------Thêm Món Ăn-------------------------------
        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            if (cbNhomMon.Text == "")
            {
                MessageBox.Show("Chon nhom mon an");
                return;
            }
            if (txtTenMonAn.Text == "")
            {
                MessageBox.Show("Nhập tên món ăn");
                return;
            }
            if (txtDonViTinh.Text == "")
            {
                MessageBox.Show("Nhập đơn vị tính");
                return;
            }
            if (txtDonGia.Text == "")
            {
                MessageBox.Show("Nhập đơn giá");
                return;
            }

            MonAn_DTO monAn = new MonAn_DTO();
            monAn.TenNhomMon = cbNhomMon.Text;
            monAn.TenMonAn = txtTenMonAn.Text.ToString();
            monAn.DonViTinh = txtDonViTinh.Text.ToString();
            monAn.IMAGE = pictureBox1.Image;
            try
            {
                monAn.Gia = int.Parse(txtDonGia.Text.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu nhập có lỗi. Xin kiểm tra lại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lstMonAn != null)
            {
                for (int i = 0; i < lstMonAn.Count; i++)
                {
                    if (ChuanHoaChuoi(monAn.TenMonAn.ToLower()) == ChuanHoaChuoi(lstMonAn[i].TenMonAn.ToLower()))
                    {
                        MessageBox.Show("Món ăn đã có trong thực đơn rồi");
                        return;
                    }
                }
            }
            if (MonAn_BUS.ThemMonAn(monAn))
            {
                LoadMonAn();
                MessageBox.Show("Đã Thêm");
                return;
            }
            MessageBox.Show("Thêm thất bại !");
        }

        //----------------Sự kiện kích vào 1 dòng datagirgview Mon An-------------------
        DataGridViewRow drMonAn;
        private void dtgrvDanhSachMonAn_Click(object sender, EventArgs e)
        {
            try
            {
                drMonAn = dtgrvDanhSachMonAn.SelectedRows[0];
            }
            catch (Exception)
            {
                return;
            }

            cbNhomMon.Text = drMonAn.Cells["TenNhomMon"].Value.ToString();
            txtTenMonAn.Text = drMonAn.Cells["TenMonAn"].Value.ToString();
            txtDonViTinh.Text = drMonAn.Cells["DonViTinh"].Value.ToString();
            txtDonGia.Text = drMonAn.Cells["Gia"].Value.ToString();
            pictureBox1.Image = DataProvider.LoadImage(DataProvider.OpenConnection(), $"select Image from MonAn where ID='{MonAn_DAO.layIDMonAn(txtTenMonAn.Text)}'");
        }

        //--------------------------Sửa Món Ăn---------------------------------
        private void btnSuaMonAn_Click(object sender, EventArgs e)
        {
            if (drMonAn == null)
            {
                MessageBox.Show("Chọn Món Ăn Muốn Sửa");
                return;
            }

            MonAn_DTO monAn = new MonAn_DTO();

            monAn.ID = int.Parse(drMonAn.Cells["ID"].Value.ToString());
            monAn.TenNhomMon = cbNhomMon.Text;
            monAn.TenMonAn = txtTenMonAn.Text;
            monAn.DonViTinh = txtDonViTinh.Text;
            monAn.Gia = int.Parse(txtDonGia.Text);
            monAn.IMAGE = pictureBox1.Image;

            if (MonAn_BUS.SuaMonAn(monAn))
            {

                drMonAn = null;
                cbNhomMon.Text = "";
                txtTenMonAn.Text = "";
                txtDonViTinh.Text = "";
                txtDonGia.Text = "";
                pictureBox1.Image = null;
                LoadMonAn();
                MessageBox.Show("Sửa thành công");
                return;
            }
            MessageBox.Show("Sửa thất bại");
        }

        private void btnXoaMonAn_Click(object sender, EventArgs e)
        {
            if (drMonAn == null)
            {
                MessageBox.Show("Chọn món ăn muốn xóa");
                return;
            }

            MonAn_DTO monAn = new MonAn_DTO();
            monAn.TenNhomMon = cbNhomMon.Text;
            monAn.TenMonAn = txtTenMonAn.Text;
            monAn.DonViTinh = txtDonViTinh.Text;
            monAn.Gia = int.Parse(txtDonGia.Text);

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (lstMonAn == null)
                    dtgrvDanhSachMonAn.DataSource = null;
                if (MonAn_BUS.XoaMonAn(monAn))
                {
                    drMonAn = null;
                    cbNhomMon.Text = "";
                    txtTenMonAn.Text = "";
                    txtDonViTinh.Text = "";
                    txtDonGia.Text = "";
                    pictureBox1.Image = null;
                    LoadMonAn();
                    MessageBox.Show("Xóa thành công");
                    return;
                }
                MessageBox.Show("Xóa thất bại");
            }
        }

        //----------------------Tìm Kiếm Món An theo tên-----------------

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            List<MonAn_DTO> ketQua = MonAn_BUS.TimMonAn(txtTimKiem.Text);
            if (ketQua == null)
                return;
            dtgrvDanhSachMonAn.DataSource = ketQua;
        }
        private void txtTimKiem_Leave_1(object sender, EventArgs e)
        {
            txtTimKiem.Text = "Nhập tên món ăn ...";
            txtTimKiem.ForeColor = Color.Gray;
        }

        private void txtTimKiem_Click_1(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            txtTimKiem.ForeColor = Color.Black;
        }

        private void cbFillNhomMon_TextChanged(object sender, EventArgs e)
        {
            string s = NhomMonAn_DAO.layIDNhomMonAn(cbFillNhomMon.Text);
            List<MonAn_DTO> kq = MonAn_BUS.LocMonAnTheoNhom(s);
            if (kq == null)
                return;
            dtgrvDanhSachMonAn.DataSource = kq;
        }

        private void cbFillNhomMon_Leave(object sender, EventArgs e)
        {
            cbFillNhomMon.Text = "- Tất Cả -";
            cbFillNhomMon.ForeColor = Color.Gray;
        }
    }
}
