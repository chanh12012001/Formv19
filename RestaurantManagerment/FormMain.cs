using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagerment
{
    public partial class FormMain : Form
    {
        Control c;
        Bunifu.Framework.UI.BunifuFlatButton button;
        string TaiKhoangDN;
        public FormMain()
        {
            TaiKhoangDN = "QL002";
            InitializeComponent();
            c = tab1QLBanAn1;
        }
        public FormMain(string TKDN)
        {
            TaiKhoangDN = TKDN;
            InitializeComponent();
            c = tab1QLBanAn1;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }
        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn Có Muốn Thoát Hay Không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                Application.Exit();
        }

        private void QLNV_Click(object sender, EventArgs e)
        {
            if (c != tab3)
            {
                button.colbackground = Color.White;
                tab3.BringToFront();
                c = tab3;
                button = QLNV;
            }
        }

        private void QLBAn_Click(object sender, EventArgs e)
        {
            if (c != tab1QLBanAn1)
            {
                button.colbackground = Color.White;
                tab1QLBanAn1.BringToFront();
                c = tab1QLBanAn1;
                button = QLBAn;
            }
        }

        private void QLTD_Click(object sender, EventArgs e)
        {
            if (TaiKhoangDN.Substring(0,2) == "NV")
            {
                QLTD.colselected = Color.White;
                button.colbackground = Color.FromArgb(136, 59, 176);
                MessageBox.Show("Chỉ có chức vụ quản lý mới được truy cập vào mục này.");
            }
            else
            {
                if (c != tab2QLThucDon1)
                {
                    button.colbackground = Color.White;
                    tab2QLThucDon1.BringToFront();
                    c = tab2QLThucDon1;
                    button = QLTD;
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.Location = new System.Drawing.Point(gunaShadowPanel1.Width, gunaGradient2Panel2.Height);
            panel1.Size = new System.Drawing.Size(this.Width - gunaShadowPanel1.Width, this.Height - gunaGradient2Panel2.Height);
            tab1QLBanAn1.Location = new Point(0, 0);
            tab1QLBanAn1.Size = new System.Drawing.Size(this.Width - gunaShadowPanel1.Width, this.Height - gunaGradient2Panel2.Height);
            tab2QLThucDon1.Location = new Point(0, 0);
            tab2QLThucDon1.Size = panel1.Size;
            tab3.Location = new Point(0, 0);
            tab3.Size = panel1.Size;
            tab4.Location= new Point(0, 0);
            tab4.Size = panel1.Size;
            tab5.Location = new Point(0, 0);
            tab5.Size = panel1.Size;
            LoadInPanel();
            button = QLBAn;
            button.BackColor = Color.FromArgb(136, 59, 176);

        }
        private void LoadInPanel ()
        {
            panel1.Controls.Add(tab1QLBanAn1);
            panel1.Controls.Add(tab2QLThucDon1);
            panel1.Controls.Add(tab3);
            panel1.Controls.Add(tab4);
            panel1.Controls.Add(tab5);
        }

        private void QLHD_Click(object sender, EventArgs e)
        {
            if (c != tab4)
            {
                button.colbackground = Color.White;
                tab4.BringToFront();
                c = tab4;
                button = QLHD;
            }
        }

        private void TK_Click(object sender, EventArgs e)
        {
            if (c != tab5)
            {
                button.colbackground = Color.White;
                tab5.BringToFront();
                c = tab5;
                button = QLHD;
            }
        }
    }
}
