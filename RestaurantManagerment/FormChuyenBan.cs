using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace RestaurantManagerment
{
    public partial class FormChuyenBan : Form
    {
        public FormChuyenBan()
        {
            InitializeComponent();
        }

        private void FormChuyenBan_Load(object sender, EventArgs e)
        {
            LoadBanAn();
        }

        public List<BanAn_DTO> lstBanAn;
        void LoadBanAn()
        {
            lstBanAn = BanAn_BUS.LoadBanAn();
            cbChuyenBan.DataSource = lstBanAn;

            cbChuyenBan.SelectedIndex = 0;
            cbChuyenBan.DisplayMember = "TenBan";
            cbChuyenBan.ValueMember = "ID";
        }

        public int inDexTable;
        private void cbChuyenBan_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            inDexTable = cbChuyenBan.SelectedIndex;
        }

        public int idToTable;
        public bool chuyenBan; // chuyen ban = true thì đc chuyển ko thì ko đc chuyển
        private void btnChuyenBan_Click_1(object sender, EventArgs e)
        {
            if (lstBanAn[inDexTable].TrangThai == "Có Người")
            {
                MessageBox.Show("Bàn này có người rồi");
                chuyenBan = false;
                return;
            }
            chuyenBan = true;
            idToTable = int.Parse(cbChuyenBan.SelectedValue.ToString());
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
