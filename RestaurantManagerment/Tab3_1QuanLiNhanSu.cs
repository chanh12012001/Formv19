using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Globalization;
using DTO;
using BUS;
using DAO;

namespace RestaurantManagerment
{
    public partial class Tab3_1QuanLiNhanSu : UserControl
    {
        List<int> ID = new List<int>();
        public Tab3_1QuanLiNhanSu()
        {
            InitializeComponent();
        }
        private void Tab3QuanLiNhanSu_Load(object sender, EventArgs e)
        {
            this.gunaShadowPanel1.Controls.Add(this.dgvDanhSachNhanVien);
            LoadNhanVien();
        }

        List<NhanVien_DTO> danhSachNhanVien;
        List<TaiKhoan_DTO> danhSachTaiKhoan;
        private void LoadNhanVien()
        {

            ID.Clear();
            danhSachNhanVien = NhanVien_BUS.LoadNhanVien();
            danhSachTaiKhoan = TaiKhoan_BUS.LoadTK();
            if (danhSachNhanVien != null)
            {
                foreach (NhanVien_DTO nv in danhSachNhanVien)
                {
                    ID.Add(int.Parse(nv.MaNhanVien.Substring(2)));
                }
            }
            gunaDataGridView1.DataSource = danhSachNhanVien;

            if (danhSachNhanVien == null)
                return;

            for (int i = 0; i < 7; i++) gunaDataGridView1.AutoResizeColumn(i);

        }

        private string GTCheck()
        {
            if (rdNam.Checked)
            {
                return "Nam";
            }
            return "Nữ";
        }

        private void ClearThongTin()
        {
            txtHoTen.Text = "";
            dtpNgaySinh.Text = "";
            rdNam.Checked = true;
            txtSoDienThoai.Text = "";
            txtChucVu.Text = "";
            txtBacLuong.Text = "";
            rtxtDiaChi.Text = "";
        }
        private string XacDinhMaNV()
        {
            if (!ID.Contains(1))
            {
                return TaoMaNV(1);
            }
            else
            {
                for (int i = 0; i < ID.Count - 1; i++)
                {
                    if (ID[i] + 1 != ID[i + 1])
                    {
                        return TaoMaNV((ID[i] + 1));
                    }
                }
                return TaoMaNV((ID[ID.Count - 1] + 1));
            }
        }
        private string TaoMaNV(int MaNV)
        {
            string s;
            s = MaNV.ToString();
            while (s.Length < 3)
            {
                s = s.Insert(0, "0");
            }
            if (cbLoaiCV.Text == "Nhân viên")
            {
                s = "NV" + s;
            }
            else s = "QL" + s;
            return s;
        }
        //Button Thêm
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (rtxtDiaChi.Text == "" || txtBacLuong.Text == "" || txtChucVu.Text == "" || txtSoDienThoai.Text == "" || txtHoTen.Text == ""||cbLoaiCV.Text=="")
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin ...");
                return;
            }
            NhanVien_DTO nhanVien = new NhanVien_DTO();
            nhanVien.MaNhanVien = XacDinhMaNV();
            nhanVien.TenNhanVien = txtHoTen.Text;
            nhanVien.NgaySinh = dtpNgaySinh.Text;
            if (rdNam.Checked)
                nhanVien.GioiTinh = "Nam";
            else
                nhanVien.GioiTinh = "Nữ";
            nhanVien.SoDienThoai = txtSoDienThoai.Text;
            nhanVien.ChucVu = txtChucVu.Text;
            nhanVien.Luong = txtBacLuong.Text;
            nhanVien.DiaChi = rtxtDiaChi.Text;
            if (danhSachNhanVien != null)
            {
                foreach (NhanVien_DTO nv in danhSachNhanVien)
                {
                    if (nhanVien.MaNhanVien == nv.MaNhanVien)
                    {
                        MessageBox.Show("Mã nhân viên đã có rồi");
                        return;
                    }
                }
            }
            //Thêm nhân viên và tài khoản của nhân viên với tên là mã số nv
            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.Tentk = nhanVien.MaNhanVien;
            tk.Matkhau =nhanVien.SoDienThoai;
            tk.Loaitk = nhanVien.MaNhanVien.Substring(0, 2);
            if (NhanVien_BUS.ThemNhanVien(nhanVien) && TaiKhoan_BUS.ThemTaiKhoan(tk))
            {
                LoadNhanVien();
                MessageBox.Show("Thêm thành công");
                return;
            }
            MessageBox.Show("Thêm thất bại");



        }
        //-------------- không cho phép nhập chữ ----------------------------
        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBacLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Button Cập Nhật
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (drNhanVien == null)
            {
                MessageBox.Show("Chọn nhân viên muốn cập nhật");
                return;
            }

            NhanVien_DTO nhanVien = new NhanVien_DTO();
            nhanVien.MaNhanVien = drNhanVien.Cells["MaNhanVien"].Value.ToString();
            nhanVien.TenNhanVien = txtHoTen.Text;
            nhanVien.NgaySinh = dtpNgaySinh.Text;
            if (rdNam.Checked)
                nhanVien.GioiTinh = "Nam";
            else
                nhanVien.GioiTinh = "Nữ";
            nhanVien.SoDienThoai = txtSoDienThoai.Text;
            nhanVien.ChucVu = txtChucVu.Text;
            nhanVien.Luong = txtBacLuong.Text;
            nhanVien.DiaChi = rtxtDiaChi.Text;

            if (NhanVien_BUS.SuaNhanVien(nhanVien))
            {

                drNhanVien = null;
                txtHoTen.Text = "";
                txtSoDienThoai.Text = "";
                txtChucVu.Text = "";
                txtBacLuong.Text = "";
                rtxtDiaChi.Text = "";

                LoadNhanVien();
                MessageBox.Show("Sửa thành công");
                return;
            }
            MessageBox.Show("Sửa thất bại");
        }

        //Button Xóa
        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            if (drNhanVien == null)
            {
                MessageBox.Show("Chọn nhân viên muốn xóa");
                return;
            }
            else if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                NhanVien_DTO nhanVien = new NhanVien_DTO();
                nhanVien.MaNhanVien = drNhanVien.Cells[0].Value.ToString();
                if (danhSachNhanVien == null)
                    gunaDataGridView1.DataSource = null;
                //Xóa nhân viên và tài khoản của nhân viên đó
                TaiKhoan_DTO tk = new TaiKhoan_DTO();
                tk.Tentk = nhanVien.MaNhanVien;
                if (NhanVien_BUS.XoaNhanVien(nhanVien)||TaiKhoan_BUS.XoaTaiKhoan(tk))
                {
                    drNhanVien = null;
                    txtHoTen.Text = "";
                    txtSoDienThoai.Text = "";
                    txtChucVu.Text = "";
                    txtBacLuong.Text = "";
                    rtxtDiaChi.Text = "";
                    LoadNhanVien();
                    MessageBox.Show("Xóa thành công");
                    return;
                }
                MessageBox.Show("Xóa thất bại");
            }
        }



        // -------- sự kiện click vào 1 dòng
        DataGridViewRow drNhanVien;
        private void gunaDataGridView1_Click(object sender, EventArgs e)
        {

            try
            {
                drNhanVien = gunaDataGridView1.SelectedRows[0];
            }
            catch (Exception)
            {
                return;
            }
            if (drNhanVien.Cells["MaNhanVien"].Value.ToString() != "0001")
            {
                txtHoTen.Text = drNhanVien.Cells["TenNhanVien"].Value.ToString();
                dtpNgaySinh.Value = DateTime.ParseExact(gunaDataGridView1.CurrentRow.Cells["NgaySinh"].Value.ToString(), "dd/MM/yyyy", new CultureInfo("en-CA"));
                if (drNhanVien.Cells["GioiTinh"].Value.ToString() == "Nam")
                    rdNam.Checked = true;
                else
                    rdNu.Checked = true;
                txtSoDienThoai.Text = drNhanVien.Cells["SoDienThoai"].Value.ToString();
                txtChucVu.Text = drNhanVien.Cells["ChucVu"].Value.ToString();
                txtBacLuong.Text = drNhanVien.Cells["Luong"].Value.ToString();
                rtxtDiaChi.Text = drNhanVien.Cells["DiaChi"].Value.ToString();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            List<NhanVien_DTO> ketQua = NhanVien_BUS.TimNhanVien(txtTimKiem.Text);
            if (ketQua == null)
                return;
            gunaDataGridView1.DataSource = ketQua;
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            txtTimKiem.Text = "Nhập tên nhân viên ...";
            txtTimKiem.ForeColor = Color.Gray;
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            txtTimKiem.ForeColor = Color.Black;
        }
    }
}
