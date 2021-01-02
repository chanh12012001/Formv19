using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RestaurantManagerment
{
    public partial class LoginForm : Form
    {
        bool ClickUserText = false;
        bool ClickPassText = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Lấy file path mà chương trình chạy(VD:C:\...\bai1\bin\debug
            var CurrentDirectory = System.Environment.CurrentDirectory;
            //Lấy file path đã bỏ đi bin\debug -> Đây là địa chỉ của toàn bộ project
            string CurrentProjectD = Directory.GetParent(CurrentDirectory).Parent.FullName;
            //Ghép địa chỉ của toàn bộ project với thư mục chứa file database SQLite để kết nối SQLite      
            using (SQLiteConnection con = new SQLiteConnection(@"Data Source=" + CurrentProjectD + @"\Database\NHAHANG.db;"))
            {
                try
                {
                    con.Open();
                    string tk = textBoxUser.Text;
                    string mk = textBoxPassword.Text;
                    string sql = "select *from NGUOIDUNG where TaiKhoan='" + tk + "' and MatKhau='" + mk + "'";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                    {
                        using (SQLiteDataReader dta = cmd.ExecuteReader())
                        {
                            if (dta.Read() == true)
                            {
                                this.Hide();
                                dta.Close();
                                con.Close();
                                FormMain form2 = new FormMain(tk);
                                form2.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Đăng nhập thất bại");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Kết Nối");
                }
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBoxUser_Enter(object sender, EventArgs e)
        {
            if (ClickUserText == false)
            {
                textBoxUser.Text = "";
                ClickUserText = true;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (ClickPassText == false)
            {
                textBoxPassword.Text = "";
                ClickPassText = true;
            }
        }

        private void textBoxUser_Leave(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "")
            {
                textBoxUser.Text = "Tên đăng nhập";
                ClickUserText = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Mật khẩu";
                ClickPassText = false;
            }
        }

        private void button_Click_2(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn Có Muốn Thoát Hay Không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                Application.Exit();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn Có Muốn Thoát Hay Không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                Application.Exit();
        }

    }
}
