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
    public partial class Tab3 : UserControl
    {
        bool notification=false;
        public Tab3(string TKDN)
        {
            TaiKhoangDN = TKDN;
            InitializeComponent();
        }
        private void Tab3_Load(object sender, EventArgs e)
        {
            this.Controls.Add(this.tab3_2QuanLiTaiKhoan1);
            this.Controls.Add(this.Tab3_1QuanLiNhanSu1);
            tab3_2QuanLiTaiKhoan1.BringToFront();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            if (TaiKhoangDN.Substring(0,2) == "NV")
            {
                notification = true;
                gunaAdvenceButton5.PerformClick();
            }
            else Tab3_1QuanLiNhanSu1.BringToFront();
        }

        private void GunaAdvenceButton3_MouseUp(object sender, MouseEventArgs e)
        {
            if (notification)
                MessageBox.Show("Chỉ có chức vụ quản lý mới được truy cập vào mục này.");
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            tab3_2QuanLiTaiKhoan1.BringToFront();
        }
    }
}
