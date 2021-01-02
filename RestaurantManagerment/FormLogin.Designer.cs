namespace RestaurantManagerment
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.textBoxTemp = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.panelPass = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBoxPassSmall = new System.Windows.Forms.PictureBox();
            this.pictureBoxUserSmall = new System.Windows.Forms.PictureBox();
            this.pictureBoxUserB = new System.Windows.Forms.PictureBox();
            this.pictureBoxViewRestaurant = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViewRestaurant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTemp
            // 
            this.textBoxTemp.Location = new System.Drawing.Point(467, 151);
            this.textBoxTemp.Name = "textBoxTemp";
            this.textBoxTemp.Size = new System.Drawing.Size(0, 20);
            this.textBoxTemp.TabIndex = 5;
            this.textBoxTemp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxUser
            // 
            this.textBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.Location = new System.Drawing.Point(472, 154);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(246, 19);
            this.textBoxUser.TabIndex = 6;
            this.textBoxUser.Text = "Tên đăng nhập";
            this.textBoxUser.Enter += new System.EventHandler(this.textBoxUser_Enter);
            this.textBoxUser.Leave += new System.EventHandler(this.textBoxUser_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(472, 210);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(246, 19);
            this.textBoxPassword.TabIndex = 7;
            this.textBoxPassword.Text = "Mật khẩu";
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBoxPassword.Enter += new System.EventHandler(this.textBox3_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.Black;
            this.panelUser.Location = new System.Drawing.Point(435, 181);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(278, 1);
            this.panelUser.TabIndex = 8;
            this.panelUser.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelPass
            // 
            this.panelPass.BackColor = System.Drawing.Color.Black;
            this.panelPass.Location = new System.Drawing.Point(435, 236);
            this.panelPass.Name = "panelPass";
            this.panelPass.Size = new System.Drawing.Size(278, 1);
            this.panelPass.TabIndex = 10;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonLogin.Location = new System.Drawing.Point(515, 259);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(132, 42);
            this.buttonLogin.TabIndex = 11;
            this.buttonLogin.Text = "ĐĂNG NHẬP";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBoxPassSmall
            // 
            this.pictureBoxPassSmall.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPassSmall.Image")));
            this.pictureBoxPassSmall.Location = new System.Drawing.Point(430, 202);
            this.pictureBoxPassSmall.Name = "pictureBoxPassSmall";
            this.pictureBoxPassSmall.Size = new System.Drawing.Size(35, 30);
            this.pictureBoxPassSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPassSmall.TabIndex = 4;
            this.pictureBoxPassSmall.TabStop = false;
            // 
            // pictureBoxUserSmall
            // 
            this.pictureBoxUserSmall.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUserSmall.Image")));
            this.pictureBoxUserSmall.Location = new System.Drawing.Point(430, 147);
            this.pictureBoxUserSmall.Name = "pictureBoxUserSmall";
            this.pictureBoxUserSmall.Size = new System.Drawing.Size(35, 30);
            this.pictureBoxUserSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUserSmall.TabIndex = 3;
            this.pictureBoxUserSmall.TabStop = false;
            // 
            // pictureBoxUserB
            // 
            this.pictureBoxUserB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxUserB.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUserB.Image")));
            this.pictureBoxUserB.Location = new System.Drawing.Point(527, 12);
            this.pictureBoxUserB.Name = "pictureBoxUserB";
            this.pictureBoxUserB.Size = new System.Drawing.Size(125, 121);
            this.pictureBoxUserB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUserB.TabIndex = 2;
            this.pictureBoxUserB.TabStop = false;
            // 
            // pictureBoxViewRestaurant
            // 
            this.pictureBoxViewRestaurant.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxViewRestaurant.BackgroundImage")));
            this.pictureBoxViewRestaurant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxViewRestaurant.Location = new System.Drawing.Point(-1, 0);
            this.pictureBoxViewRestaurant.Name = "pictureBoxViewRestaurant";
            this.pictureBoxViewRestaurant.Size = new System.Drawing.Size(547, 394);
            this.pictureBoxViewRestaurant.TabIndex = 1;
            this.pictureBoxViewRestaurant.TabStop = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(709, 6);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(15, 15);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 13;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(737, 393);
            this.ControlBox = false;
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.panelPass);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.textBoxTemp);
            this.Controls.Add(this.pictureBoxPassSmall);
            this.Controls.Add(this.pictureBoxUserSmall);
            this.Controls.Add(this.pictureBoxUserB);
            this.Controls.Add(this.pictureBoxViewRestaurant);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViewRestaurant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxViewRestaurant;
        private System.Windows.Forms.PictureBox pictureBoxUserB;
        private System.Windows.Forms.PictureBox pictureBoxUserSmall;
        private System.Windows.Forms.PictureBox pictureBoxPassSmall;
        private System.Windows.Forms.TextBox textBoxTemp;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Panel panelPass;
        private System.Windows.Forms.Button buttonLogin;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}

