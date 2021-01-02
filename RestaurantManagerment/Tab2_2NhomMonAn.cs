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
using DAO;
using System.Text.RegularExpressions;

namespace RestaurantManagerment
{
    public partial class Tab2_2NhomMonAn : UserControl
    {
        public Tab2_2NhomMonAn()
        {
            InitializeComponent();
        }

        private void Tab2_2NhomMonAn_Load(object sender, EventArgs e)
        {
            LoadNhomMonAn();
        }


        List<NhomMonAn_DTO> danhSachNhomMonAn;
        private void LoadNhomMonAn()
        {

            danhSachNhomMonAn = NhomMonAn_BUS.LoadNhomMonAn();
            dtgrvDanhSachNhomMon.DataSource = danhSachNhomMonAn;

            if (danhSachNhomMonAn == null)
                return;
            dtgrvDanhSachNhomMon.Columns["MaNhomMonAn"].HeaderText = "Mã Nhóm";
            dtgrvDanhSachNhomMon.Columns["TenNhomMonAn"].HeaderText = "Tên Nhóm";

        }

        //----------------- chuẩn hóa chuỗi ---------------------------------
        public static string ChuanHoaChuoi(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        //======================== Thêm Nhóm Món Ăn =============================
        private void btnThemNhomMon_Click(object sender, EventArgs e)
        {
            if (txtMaNhomMon.Text == "")
            {
                MessageBox.Show("Nhập Mã Nhóm");
                return;
            }

            if (txtTenNhom.Text == "")
            {
                MessageBox.Show("Nhập Tên Nhóm");
                return;
            }
            NhomMonAn_DTO nhomMonAn = new NhomMonAn_DTO();
            nhomMonAn.MaNhomMonAn = txtMaNhomMon.Text.ToString();
            nhomMonAn.TenNhomMonAn = txtTenNhom.Text.ToString();
            if (danhSachNhomMonAn != null)
            {
                foreach (NhomMonAn_DTO nm in danhSachNhomMonAn)
                {
                    if (nhomMonAn.MaNhomMonAn == nm.MaNhomMonAn)
                    {
                        MessageBox.Show("Mã nhóm món ăn đã có rồi");
                        return;
                    }
                }
            }
            if (NhomMonAn_BUS.ThemNhomMonAn(nhomMonAn))
            {
                LoadNhomMonAn();
                MessageBox.Show("Thêm thành công");
                return;
            }
            MessageBox.Show("Thêm thất bại");
        }

        // sự kiện click của datagirdview Nhóm Món Ăn
        DataGridViewRow drNhomMonAn;
        private void dtgrvDanhSachNhomMon_Click(object sender, EventArgs e)
        {
            try
            {
                drNhomMonAn = dtgrvDanhSachNhomMon.SelectedRows[0];
            }
            catch (Exception)
            {
                return;
            }

            txtMaNhomMon.Text = drNhomMonAn.Cells["MaNhomMonAn"].Value.ToString();
            txtTenNhom.Text = drNhomMonAn.Cells["TenNhomMonAn"].Value.ToString();
        }

        //Sửa Nhóm Món Ăn
        private void btnSuaNhomMonAn_Click(object sender, EventArgs e)
        {
            if (drNhomMonAn == null)
            {
                MessageBox.Show("Chọn Nhóm Món Ăn Muốn Sửa");
                return;
            }

            NhomMonAn_DTO nhomMonAn = new NhomMonAn_DTO();

            nhomMonAn.MaNhomMonAn = drNhomMonAn.Cells["MaNhomMonAn"].Value.ToString();
            nhomMonAn.TenNhomMonAn = txtTenNhom.Text;
            if (NhomMonAn_BUS.SuaNhomMonAn(nhomMonAn))
            {

                drNhomMonAn = null;
                txtMaNhomMon.Text = "";
                txtTenNhom.Text = "";
                LoadNhomMonAn();
                MessageBox.Show("Sửa thành công");
                return;
            }
            MessageBox.Show("Sửa thất bại");
        }

        // Xóa nhóm Món ăn 
        private void btnXoaNhomMonAn_Click(object sender, EventArgs e)
        {
            if (drNhomMonAn == null)
            {
                MessageBox.Show("Chọn Nhóm Món Ăn Muốn Xóa");
                return;
            }
            NhomMonAn_DTO nhomMonAnXoa = new NhomMonAn_DTO();
            nhomMonAnXoa.MaNhomMonAn = txtMaNhomMon.Text;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (danhSachNhomMonAn == null)
                    dtgrvDanhSachNhomMon.DataSource = null;
                if (NhomMonAn_BUS.XoaNhomMonAn(nhomMonAnXoa))
                {
                    drNhomMonAn = null;
                    txtMaNhomMon.Text = "";
                    txtTenNhom.Text = "";
                    MessageBox.Show("Xóa thành công");
                    LoadNhomMonAn();
                    return;
                }
                MessageBox.Show("Xóa thất bại");
            }
        }

        // ------------- tìm kiếm bàn ăn ----------------------------
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            List<NhomMonAn_DTO> ketQua = NhomMonAn_BUS.TimNhomMonAn(txtTimKiem.Text);
            if (ketQua == null)
                return;
            dtgrvDanhSachNhomMon.DataSource = ketQua;
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            txtTimKiem.Text = "Nhập tên nhóm ..";
            txtTimKiem.ForeColor = Color.Gray;
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            txtTimKiem.ForeColor = Color.Black;
        }
    }
}
