using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagerment
{
    public partial class Tab4 : UserControl
    {
        public Tab4()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            tab4_1QuanLiHoaDon1.BringToFront();
        }

        private void Tab4_Load(object sender, EventArgs e)
        {
            this.Controls.Add(this.tab4_1QuanLiHoaDon1);
            this.Controls.Add(this.Tab4_2QuanLiPhieuNhap1);
            tab4_1QuanLiHoaDon1.BringToFront();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            Tab4_2QuanLiPhieuNhap1.BringToFront();
        }
    }
}
