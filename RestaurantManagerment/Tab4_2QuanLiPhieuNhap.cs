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
using System.Data.SQLite;
using DAO;

namespace RestaurantManagerment
{
    public partial class Tab4_2QuanLiPhieuNhap : UserControl
    {
        public Tab4_2QuanLiPhieuNhap()
        {
            InitializeComponent();
            LoadPhieuNhap();
            txtMaPN.ReadOnly = true;
            txtTenNL.ReadOnly = true;
            txtDonVi.ReadOnly = true;
            LoadDateTimePickerBill();
        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpTuNgay.Value = new DateTime(today.Year, today.Month, 1);
            dtpDenNgay.Value = dtpTuNgay.Value.AddMonths(1).AddDays(-1);
        }
        List<PhieuNhap_DTO> dsphieunhap;
        List<int> ID = new List<int>();
        DataGridViewRow dgvPhieuNhap;
        private void LoadPhieuNhap()
        {


            dsphieunhap = PhieuNhap_BUS.LoadPhieuNhap();
            if (dsphieunhap != null)
            {
                foreach (PhieuNhap_DTO pn in dsphieunhap)
                {
                    ID.Add(pn.MaPN);
                }
            }
            gDGVPhieuNhap.DataSource = dsphieunhap;

            if (dsphieunhap == null)
                return;
            gDGVPhieuNhap.Columns["MaPN"].HeaderText = "Mã PN";
            gDGVPhieuNhap.Columns["MaNL"].HeaderText = "Mã NL";
            gDGVPhieuNhap.Columns["TenNL"].HeaderText = "Tên Nguyên Liệu";
            gDGVPhieuNhap.Columns["Donvi"].HeaderText = "Đơn Vị";
            gDGVPhieuNhap.Columns["Soluong"].HeaderText = "Số Lượng";
            gDGVPhieuNhap.Columns["Dongia"].HeaderText = "Đơn giá";
            gDGVPhieuNhap.Columns["NgayNhap"].HeaderText = "Ngày nhập";
            gDGVPhieuNhap.Columns["Donvicungcap"].HeaderText = "Đơn vị cung cấp";
            gDGVPhieuNhap.Columns["Thukho"].HeaderText = "Thủ kho";

            gDGVPhieuNhap.Columns["MaNL"].Visible = false;
            
            for (int i = 0; i < 8; i++) gDGVPhieuNhap.AutoResizeColumn(i);

        }
        public void DSMaNL()
        {

            try
            {
                cBMaNL.Items.Clear();

                string query = "Select MaNL From NguyenLieu";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.CommandText = query;

                SQLiteDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cBMaNL.Items.Add(dr["MaNL"].ToString());
                }

            }
            catch
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu sql !");
            }
        }

        public void LayTTnguyenLieu(int a)
        {

            string query1 = "Select TenNL,DonVi,SoLuong From NguyenLieu Where MaNL= " + a;
            SQLiteCommand cmd1 = new SQLiteCommand(query1, conn);

            cmd1.CommandText = query1;

            SQLiteDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                txtTenNL.Text = dr1["TenNL"].ToString();
                txtDonVi.Text = dr1["DonVi"].ToString();

            }

        }
        private void LocPhieuNhap(DateTime checkin, DateTime checkout)
        {


            dsphieunhap = PhieuNhap_BUS.LocPhieuNhap(checkin,checkout);
            if (dsphieunhap != null)
            {
                foreach (PhieuNhap_DTO pn in dsphieunhap)
                {
                    ID.Add(pn.MaPN);
                }
            }
            gDGVPhieuNhap.DataSource = dsphieunhap;

            if (dsphieunhap == null)
                return;
            gDGVPhieuNhap.Columns["MaPN"].HeaderText = "Mã PN";
            gDGVPhieuNhap.Columns["MaNL"].HeaderText = "Mã NL";
            gDGVPhieuNhap.Columns["TenNL"].HeaderText = "Tên Nguyên Liệu";
            gDGVPhieuNhap.Columns["Donvi"].HeaderText = "Đơn Vị";
            gDGVPhieuNhap.Columns["Soluong"].HeaderText = "Số Lượng";
            gDGVPhieuNhap.Columns["Dongia"].HeaderText = "Đơn giá";
            gDGVPhieuNhap.Columns["NgayNhap"].HeaderText = "Ngày nhập";
            gDGVPhieuNhap.Columns["Donvicungcap"].HeaderText = "Đơn vị cung cấp";
            gDGVPhieuNhap.Columns["Thukho"].HeaderText = "Thủ kho";

            gDGVPhieuNhap.Columns["MaNL"].Visible = false;
            
            for (int i = 0; i < 8; i++) gDGVPhieuNhap.AutoResizeColumn(i);

        }
        SQLiteConnection conn = DataProvider.OpenConnection();
        private void Tab4_2QuanLiPhieuNhap_Load(object sender, EventArgs e)
        {
            DSMaNL();            
        }

        private void cBMaNL_SelectedIndexChanged(object sender, EventArgs e)
        {
            LayTTnguyenLieu(int.Parse(cBMaNL.Text));
        }

        // Button thêm phiếu nhập
        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            if (cBMaNL.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã nguyên liệu !");
                return;
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Số lượng !");
                return;
            }
            if (txtDonGia.Text == "")
            {
                MessageBox.Show("Vui Lòng nhập đơn giá !");
                return;
            }
            if (txtCungCap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Đơn vị cung cấp !");
                return;
            }
            if (txtThuKho.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Thủ kho !");
                return;
            }


            PhieuNhap_DTO phieunhap = new PhieuNhap_DTO();
            phieunhap.MaNL = int.Parse(cBMaNL.Text.ToString());
            phieunhap.TenNL = txtTenNL.Text.ToString();
            phieunhap.DonVi = txtDonVi.Text.ToString();
            try
            {
                phieunhap.Soluong = int.Parse(txtSoLuong.Text.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu nhập có lỗi. Xin kiểm tra lại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            phieunhap.Dongia = int.Parse(txtDonGia.Text.ToString());
            phieunhap.Ngaynhap = DateTime.Parse(dtpNgayNhap.Text.ToString());
            phieunhap.Donvicungcap = txtCungCap.Text.ToString();
            phieunhap.Thukho = txtThuKho.Text.ToString();
            if (PhieuNhap_BUS.ThemPhieuNhap(phieunhap))
            {
                LoadPhieuNhap();
                MessageBox.Show("Đã Thêm");
                return;
            }
            MessageBox.Show("Thêm thất bại !");
        }

        private void gDGVPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvPhieuNhap = gDGVPhieuNhap.SelectedRows[0];
            }
            catch (Exception)
            {
                return;
            }
            if (dgvPhieuNhap.Cells["MaPN"].Value.ToString() != "0")
            {
                txtMaPN.Text = dgvPhieuNhap.Cells["MaPN"].Value.ToString();
                cBMaNL.Text = dgvPhieuNhap.Cells["MaNL"].Value.ToString();
                txtTenNL.Text = dgvPhieuNhap.Cells["TenNL"].Value.ToString();
                txtDonVi.Text = dgvPhieuNhap.Cells["Donvi"].Value.ToString();
                txtSoLuong.Text = dgvPhieuNhap.Cells["Soluong"].Value.ToString();
                txtDonGia.Text = dgvPhieuNhap.Cells["DonGia"].Value.ToString();
                dtpNgayNhap.Text= dgvPhieuNhap.Cells["NgayNhap"].Value.ToString();
                txtCungCap.Text= dgvPhieuNhap.Cells["Donvicungcap"].Value.ToString();
                txtThuKho.Text= dgvPhieuNhap.Cells["ThuKho"].Value.ToString();

            }
        }
        //Button Xóa phiếu nhập
        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap == null)
            {
                MessageBox.Show("Chọn món ăn muốn xóa");
                return;
            }

            PhieuNhap_DTO phieunhap = new PhieuNhap_DTO();
            phieunhap.MaPN = int.Parse(txtMaPN.Text);
            phieunhap.MaNL = int.Parse(cBMaNL.Text);
            phieunhap.TenNL = txtTenNL.Text;
            phieunhap.DonVi = txtDonVi.Text;
            phieunhap.Soluong = int.Parse(txtSoLuong.Text);
            phieunhap.Dongia = int.Parse(txtDonGia.Text);
            phieunhap.Ngaynhap = DateTime.Parse(dtpNgayNhap.Text);
            phieunhap.Donvicungcap = txtCungCap.Text;
            phieunhap.Thukho = txtThuKho.Text;


            if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dsphieunhap == null)
                    gDGVPhieuNhap.DataSource = null;
                if (PhieuNhap_BUS.XoaPhieuNhap(phieunhap))
                {
                    dgvPhieuNhap = null;
                    txtMaPN.Text = "";
                    cBMaNL.Text = "";
                    txtTenNL.Text = "";
                    txtDonVi.Text = "";
                    txtSoLuong.Text = "";
                    txtDonGia.Text = "";
                    
                    txtCungCap.Text = "";
                    txtThuKho.Text = "";
                    LoadPhieuNhap();
                    MessageBox.Show("Xóa thành công");
                    return;
                }
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            LocPhieuNhap(dtpTuNgay.Value,dtpDenNgay.Value);
        }

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value > dtpDenNgay.Value)
            {
                MessageBox.Show("Thời gian không hợp lệ!");
                LoadDateTimePickerBill();
            }
        }

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value > dtpDenNgay.Value)
            {
                MessageBox.Show("Thời gian không hợp lệ!");
                LoadDateTimePickerBill();
            }
        }
    }
}
