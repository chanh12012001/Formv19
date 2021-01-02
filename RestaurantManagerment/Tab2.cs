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
    public partial class Tab2 : UserControl
    {
        public Tab2()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            tab2_1ThongTinMonAn1.BringToFront();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            tab2_2NhomMonAn1.BringToFront();
        }

        private void Tab2QLThucDon_Load(object sender, EventArgs e)
        {
            this.Controls.Add(tab2_2NhomMonAn1);
            this.Controls.Add(tab2_1ThongTinMonAn1);
            this.Controls.Add(Tab2_3ThongTinNguyenLieu1);
            tab2_1ThongTinMonAn1.BringToFront();
        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            Tab2_3ThongTinNguyenLieu1.BringToFront();
        }
    }
}
