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
    public partial class Tab1 : UserControl
    {
        public Tab1()
        {
            InitializeComponent();
        }

        private void btnSoDoBan_Click(object sender, EventArgs e)
        {
            tab1_1_1BanAn1.BringToFront();
        }

        private void btnThongTinBan_Click(object sender, EventArgs e)
        {
            tab1_1_2ThongTinBan1.BringToFront();
        }

        private void Tab1_1_Load(object sender, EventArgs e)
        {
            panel2.Controls.Add(tab1_1_1BanAn1);
            panel2.Controls.Add(tab1_1_2ThongTinBan1);
        }
    }
}
