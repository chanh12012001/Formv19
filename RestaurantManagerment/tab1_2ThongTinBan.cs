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

namespace RestaurantManagerment
{
    public partial class tab1_2ThongTinBan : UserControl
    {
        public tab1_2ThongTinBan()
        {
                InitializeComponent();
        }

        private void tab1_1_2ThongTinBan_Load(object sender, EventArgs e)
        {
                LoadBanAn();
        }

        List<BanAn_DTO> lstBanAn;
        private void LoadBanAn()
        {
            lstBanAn = BanAn_BUS.LoadBanAn();
            dtgrvDanhSachBan.DataSource = lstBanAn;

            if (lstBanAn == null)
                return;

            dtgrvDanhSachBan.Columns["ID"].HeaderText = "ID";
            dtgrvDanhSachBan.Columns["TenBan"].HeaderText = "Tên Bàn";
            dtgrvDanhSachBan.Columns["TrangThai"].HeaderText = "Trạng Thái";

            dtgrvDanhSachBan.Columns["TenBan"].Width = 200;
            dtgrvDanhSachBan.Columns["TrangThai"].Width = 200;

            if (lstBanAn != null)
                lbSoBanHienCo.Text = (lstBanAn.Count).ToString();
            else
                lbSoBanHienCo.Text = "0";
        }

        //----------------- chuẩn hóa chuỗi ---------------------------------
        public static string ChuanHoaChuoi(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        // Thêm bàn ăn

        private void btnThemBanAn_Click(object sender, EventArgs e)
        {
            if (txtTenBan.Text == "")
            {
                MessageBox.Show("Nhập tên bàn");
                return;
            }
            BanAn_DTO banAn = new BanAn_DTO();
            banAn.TenBan = txtTenBan.Text.ToString();
            banAn.TrangThai = "Trống";
            if (lstBanAn != null)
            {
                for (int i = 0; i < lstBanAn.Count; i++)
                {
                    if (ChuanHoaChuoi(banAn.TenBan.ToLower()) == ChuanHoaChuoi(lstBanAn[i].TenBan.ToLower()))
                    {
                        MessageBox.Show("Tên đã có rồi");
                        return;
                    }
                }
            }
            if (BanAn_BUS.ThemBanAn(banAn))
            {
                MessageBox.Show("Thêm thành công");
                LoadBanAn();
                if (lstBanAn != null)
                    lbSoBanHienCo.Text = (lstBanAn.Count).ToString();
                else
                    lbSoBanHienCo.Text = "0";
                return;
            }
            MessageBox.Show("Thêm thất bại");
        }

        // sự kiện click của datagirdview bàn ăn
        DataGridViewRow drBan;
        private void dtgrvDanhSachBan_Click_1(object sender, EventArgs e)
        {
            try
            {
                drBan = dtgrvDanhSachBan.SelectedRows[0];
            }
            catch (Exception)
            {
                return;
            }

            txtTenBan.Text = drBan.Cells["TenBan"].Value.ToString();
            if (drBan.Cells["TrangThai"].Value.ToString() == "Trống")
            {
                lbTrangThai.Text = drBan.Cells["TrangThai"].Value.ToString();
                lbTrangThai.ForeColor = Color.Red;
            }
            else
            {
                lbTrangThai.ForeColor = Color.ForestGreen;
                lbTrangThai.Text = drBan.Cells["TrangThai"].Value.ToString();
            }
        }

        //Sửa Bàn Ăn
        private void btnSuaBanAn_Click_1(object sender, EventArgs e)
        {
            if (drBan == null)
            {
                MessageBox.Show("Chọn bàn muốn sửa");
                return;
            }
            BanAn_DTO banAnSua = new BanAn_DTO();
            banAnSua.ID = int.Parse(drBan.Cells["ID"].Value.ToString());
            banAnSua.TenBan = txtTenBan.Text.ToString();

            if (BanAn_BUS.SuaBanAn(banAnSua))
            {
                drBan = null;
                txtTenBan.Text = "";
                lbTrangThai.Text = "";
                MessageBox.Show("Sửa thành công");
                LoadBanAn();
                return;
            }
            MessageBox.Show("Sửa thất bại");
        }

        // Xóa bàn ăn  
        private void btnXoaBanAn_Click_1(object sender, EventArgs e)
        {
            if (drBan == null)
            {
                MessageBox.Show("Chọn bàn muốn xóa");
                return;
            }
            BanAn_DTO banAnXoa = new BanAn_DTO();
            banAnXoa.ID = int.Parse(drBan.Cells["ID"].Value.ToString());
            if (drBan.Cells["TrangThai"].Value.ToString() == "Có Người")
            {
                MessageBox.Show("Không thể xóa bàn đang có người");
                return;
            }

            /*if (MessageBox.Show("Xóa bàn sẽ xóa toàn bộ hóa đơn của bàn đó", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    HoaDon_BUS.XoaHoaDonCoIDBan(banAnXoa.ID); // xóa các hóa đơn có liên quan đến bàn đó
                }
                catch (Exception)
                {
                    return;
                }
            */
            if (BanAn_BUS.XoaBanAn(banAnXoa))
            {
                drBan = null;
                txtTenBan.Text = "";
                lbTrangThai.Text = "";
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBanAn();

                if (lstBanAn != null)
                    lbTrangThai.Text = (lstBanAn.Count).ToString();
                else
                    lbTrangThai.Text = "0";

                return;
            }

            else
                MessageBox.Show("Xóa thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // ------------- tìm kiếm bàn ăn ----------------------------
        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            List<BanAn_DTO> ketQua = BanAn_BUS.TimBanAn(txtTimKiem.Text);
            if (ketQua == null)
                return;
            dtgrvDanhSachBan.DataSource = ketQua;
        }

        private void txtTimKiem_Click_1(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            txtTimKiem.ForeColor = Color.Black;
        }

        private void txtTimKiem_Leave_1(object sender, EventArgs e)
        {
            txtTimKiem.Text = "Nhập tên bàn ăn";
            txtTimKiem.ForeColor = Color.Gray;
        }
    }
}

