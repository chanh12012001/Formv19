namespace RestaurantManagerment
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.Exit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TK = new Bunifu.Framework.UI.BunifuFlatButton();
            this.QLHD = new Bunifu.Framework.UI.BunifuFlatButton();
            this.QLNV = new Bunifu.Framework.UI.BunifuFlatButton();
            this.QLTD = new Bunifu.Framework.UI.BunifuFlatButton();
            this.QLBAn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gunaGradient2Panel2 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tab1QLBanAn1 = new RestaurantManagerment.Tab1();
            this.tab2QLThucDon1 = new RestaurantManagerment.Tab2();
            this.tab3 = new RestaurantManagerment.Tab3(TaiKhoangDN);
            this.tab4 = new RestaurantManagerment.Tab4();
            this.tab5 = new RestaurantManagerment.Tab5();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Activecolor = System.Drawing.Color.White;
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.White;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit.BorderRadius = 0;
            this.Exit.ButtonText = "Thoát";
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.DisabledColor = System.Drawing.Color.Gray;
            this.Exit.ForeColor = System.Drawing.Color.LightGray;
            this.Exit.Iconcolor = System.Drawing.Color.Transparent;
            this.Exit.Iconimage = ((System.Drawing.Image)(resources.GetObject("Exit.Iconimage")));
            this.Exit.Iconimage_right = null;
            this.Exit.Iconimage_right_Selected = null;
            this.Exit.Iconimage_Selected = null;
            this.Exit.IconMarginLeft = 0;
            this.Exit.IconMarginRight = 0;
            this.Exit.IconRightVisible = true;
            this.Exit.IconRightZoom = 0D;
            this.Exit.IconVisible = true;
            this.Exit.IconZoom = 65D;
            this.Exit.IsTab = true;
            this.Exit.Location = new System.Drawing.Point(29, 560);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Normalcolor = System.Drawing.Color.White;
            this.Exit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(59)))), ((int)(((byte)(176)))));
            this.Exit.OnHoverTextColor = System.Drawing.Color.White;
            this.Exit.selected = true;
            this.Exit.Size = new System.Drawing.Size(196, 59);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Thoát";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit.Textcolor = System.Drawing.Color.Black;
            this.Exit.TextFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Click += new System.EventHandler(this.bunifuFlatButton6_Click);
            // 
            // TK
            // 
            this.TK.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(59)))), ((int)(((byte)(176)))));
            this.TK.AutoSize = true;
            this.TK.BackColor = System.Drawing.Color.White;
            this.TK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TK.BorderRadius = 0;
            this.TK.ButtonText = "Thống Kê";
            this.TK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TK.DisabledColor = System.Drawing.Color.Gray;
            this.TK.ForeColor = System.Drawing.Color.LightGray;
            this.TK.Iconcolor = System.Drawing.Color.Transparent;
            this.TK.Iconimage = ((System.Drawing.Image)(resources.GetObject("TK.Iconimage")));
            this.TK.Iconimage_right = null;
            this.TK.Iconimage_right_Selected = null;
            this.TK.Iconimage_Selected = null;
            this.TK.IconMarginLeft = 0;
            this.TK.IconMarginRight = 0;
            this.TK.IconRightVisible = true;
            this.TK.IconRightZoom = 0D;
            this.TK.IconVisible = true;
            this.TK.IconZoom = 65D;
            this.TK.IsTab = true;
            this.TK.Location = new System.Drawing.Point(29, 492);
            this.TK.Margin = new System.Windows.Forms.Padding(4);
            this.TK.Name = "TK";
            this.TK.Normalcolor = System.Drawing.Color.White;
            this.TK.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(59)))), ((int)(((byte)(176)))));
            this.TK.OnHoverTextColor = System.Drawing.Color.White;
            this.TK.selected = false;
            this.TK.Size = new System.Drawing.Size(196, 59);
            this.TK.TabIndex = 11;
            this.TK.Text = "Thống Kê";
            this.TK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TK.Textcolor = System.Drawing.Color.Black;
            this.TK.TextFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TK.Click += new System.EventHandler(this.TK_Click);
            // 
            // QLHD
            // 
            this.QLHD.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(59)))), ((int)(((byte)(176)))));
            this.QLHD.AutoSize = true;
            this.QLHD.BackColor = System.Drawing.Color.White;
            this.QLHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QLHD.BorderRadius = 0;
            this.QLHD.ButtonText = "Quản Lí Hóa Đơn";
            this.QLHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QLHD.DisabledColor = System.Drawing.Color.Gray;
            this.QLHD.ForeColor = System.Drawing.Color.LightGray;
            this.QLHD.Iconcolor = System.Drawing.Color.Transparent;
            this.QLHD.Iconimage = ((System.Drawing.Image)(resources.GetObject("QLHD.Iconimage")));
            this.QLHD.Iconimage_right = null;
            this.QLHD.Iconimage_right_Selected = null;
            this.QLHD.Iconimage_Selected = null;
            this.QLHD.IconMarginLeft = 0;
            this.QLHD.IconMarginRight = 0;
            this.QLHD.IconRightVisible = true;
            this.QLHD.IconRightZoom = 0D;
            this.QLHD.IconVisible = true;
            this.QLHD.IconZoom = 65D;
            this.QLHD.IsTab = true;
            this.QLHD.Location = new System.Drawing.Point(29, 425);
            this.QLHD.Margin = new System.Windows.Forms.Padding(4);
            this.QLHD.Name = "QLHD";
            this.QLHD.Normalcolor = System.Drawing.Color.White;
            this.QLHD.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(59)))), ((int)(((byte)(176)))));
            this.QLHD.OnHoverTextColor = System.Drawing.Color.White;
            this.QLHD.selected = false;
            this.QLHD.Size = new System.Drawing.Size(196, 59);
            this.QLHD.TabIndex = 10;
            this.QLHD.Text = "Quản Lí Hóa Đơn";
            this.QLHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QLHD.Textcolor = System.Drawing.Color.Black;
            this.QLHD.TextFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLHD.Click += new System.EventHandler(this.QLHD_Click);
            // 
            // QLNV
            // 
            this.QLNV.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(59)))), ((int)(((byte)(176)))));
            this.QLNV.AutoSize = true;
            this.QLNV.BackColor = System.Drawing.Color.White;
            this.QLNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QLNV.BorderRadius = 0;
            this.QLNV.ButtonText = "Quản Lí Nhân Viên";
            this.QLNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QLNV.DisabledColor = System.Drawing.Color.Gray;
            this.QLNV.ForeColor = System.Drawing.Color.LightGray;
            this.QLNV.Iconcolor = System.Drawing.Color.Transparent;
            this.QLNV.Iconimage = ((System.Drawing.Image)(resources.GetObject("QLNV.Iconimage")));
            this.QLNV.Iconimage_right = null;
            this.QLNV.Iconimage_right_Selected = null;
            this.QLNV.Iconimage_Selected = null;
            this.QLNV.IconMarginLeft = 0;
            this.QLNV.IconMarginRight = 0;
            this.QLNV.IconRightVisible = true;
            this.QLNV.IconRightZoom = 0D;
            this.QLNV.IconVisible = true;
            this.QLNV.IconZoom = 65D;
            this.QLNV.IsTab = true;
            this.QLNV.Location = new System.Drawing.Point(29, 358);
            this.QLNV.Margin = new System.Windows.Forms.Padding(4);
            this.QLNV.Name = "QLNV";
            this.QLNV.Normalcolor = System.Drawing.Color.White;
            this.QLNV.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(59)))), ((int)(((byte)(176)))));
            this.QLNV.OnHoverTextColor = System.Drawing.Color.White;
            this.QLNV.selected = false;
            this.QLNV.Size = new System.Drawing.Size(196, 59);
            this.QLNV.TabIndex = 9;
            this.QLNV.Text = "Quản Lí Nhân Viên";
            this.QLNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QLNV.Textcolor = System.Drawing.Color.Black;
            this.QLNV.TextFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLNV.Click += new System.EventHandler(this.QLNV_Click);
            // 
            // QLTD
            // 
            this.QLTD.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(59)))), ((int)(((byte)(176)))));
            this.QLTD.AutoSize = true;
            this.QLTD.BackColor = System.Drawing.Color.White;
            this.QLTD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QLTD.BorderRadius = 0;
            this.QLTD.ButtonText = "Quản Lí Thực Đơn";
            this.QLTD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QLTD.DisabledColor = System.Drawing.Color.Gray;
            this.QLTD.ForeColor = System.Drawing.Color.LightGray;
            this.QLTD.Iconcolor = System.Drawing.Color.Transparent;
            this.QLTD.Iconimage = ((System.Drawing.Image)(resources.GetObject("QLTD.Iconimage")));
            this.QLTD.Iconimage_right = null;
            this.QLTD.Iconimage_right_Selected = null;
            this.QLTD.Iconimage_Selected = null;
            this.QLTD.IconMarginLeft = 0;
            this.QLTD.IconMarginRight = 0;
            this.QLTD.IconRightVisible = true;
            this.QLTD.IconRightZoom = 0D;
            this.QLTD.IconVisible = true;
            this.QLTD.IconZoom = 65D;
            this.QLTD.IsTab = true;
            this.QLTD.Location = new System.Drawing.Point(29, 290);
            this.QLTD.Margin = new System.Windows.Forms.Padding(4);
            this.QLTD.Name = "QLTD";
            this.QLTD.Normalcolor = System.Drawing.Color.White;
            this.QLTD.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(59)))), ((int)(((byte)(176)))));
            this.QLTD.OnHoverTextColor = System.Drawing.Color.White;
            this.QLTD.selected = false;
            this.QLTD.Size = new System.Drawing.Size(196, 59);
            this.QLTD.TabIndex = 8;
            this.QLTD.Text = "Quản Lí Thực Đơn";
            this.QLTD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QLTD.Textcolor = System.Drawing.Color.Black;
            this.QLTD.TextFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLTD.Click += new System.EventHandler(this.QLTD_Click);
            // 
            // QLBAn
            // 
            this.QLBAn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(59)))), ((int)(((byte)(176)))));
            this.QLBAn.AutoSize = true;
            this.QLBAn.BackColor = System.Drawing.Color.White;
            this.QLBAn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QLBAn.BorderRadius = 0;
            this.QLBAn.ButtonText = "Quản Lí Bàn Ăn";
            this.QLBAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QLBAn.DisabledColor = System.Drawing.Color.Gray;
            this.QLBAn.ForeColor = System.Drawing.Color.LightGray;
            this.QLBAn.Iconcolor = System.Drawing.Color.Transparent;
            this.QLBAn.Iconimage = ((System.Drawing.Image)(resources.GetObject("QLBAn.Iconimage")));
            this.QLBAn.Iconimage_right = null;
            this.QLBAn.Iconimage_right_Selected = null;
            this.QLBAn.Iconimage_Selected = null;
            this.QLBAn.IconMarginLeft = 0;
            this.QLBAn.IconMarginRight = 0;
            this.QLBAn.IconRightVisible = true;
            this.QLBAn.IconRightZoom = 0D;
            this.QLBAn.IconVisible = true;
            this.QLBAn.IconZoom = 65D;
            this.QLBAn.IsTab = true;
            this.QLBAn.Location = new System.Drawing.Point(29, 223);
            this.QLBAn.Margin = new System.Windows.Forms.Padding(4);
            this.QLBAn.Name = "QLBAn";
            this.QLBAn.Normalcolor = System.Drawing.Color.White;
            this.QLBAn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(59)))), ((int)(((byte)(176)))));
            this.QLBAn.OnHoverTextColor = System.Drawing.Color.White;
            this.QLBAn.selected = true;
            this.QLBAn.Size = new System.Drawing.Size(196, 59);
            this.QLBAn.TabIndex = 7;
            this.QLBAn.Text = "Quản Lí Bàn Ăn";
            this.QLBAn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QLBAn.Textcolor = System.Drawing.Color.Black;
            this.QLBAn.TextFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLBAn.Click += new System.EventHandler(this.QLBAn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(237, 172);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // gunaGradient2Panel2
            // 
            this.gunaGradient2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGradient2Panel2.GradientColor1 = System.Drawing.Color.White;
            this.gunaGradient2Panel2.GradientColor2 = System.Drawing.Color.White;
            this.gunaGradient2Panel2.Location = new System.Drawing.Point(252, 0);
            this.gunaGradient2Panel2.Name = "gunaGradient2Panel2";
            this.gunaGradient2Panel2.Size = new System.Drawing.Size(788, 24);
            this.gunaGradient2Panel2.TabIndex = 14;
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.Linen;
            this.gunaShadowPanel1.Controls.Add(this.pictureBox2);
            this.gunaShadowPanel1.Controls.Add(this.Exit);
            this.gunaShadowPanel1.Controls.Add(this.QLHD);
            this.gunaShadowPanel1.Controls.Add(this.QLBAn);
            this.gunaShadowPanel1.Controls.Add(this.QLNV);
            this.gunaShadowPanel1.Controls.Add(this.QLTD);
            this.gunaShadowPanel1.Controls.Add(this.TK);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 6;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(252, 640);
            this.gunaShadowPanel1.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 81);
            this.panel1.TabIndex = 46;
            // 
            // tab1QLBanAn1
            // 
            this.tab1QLBanAn1.Location = new System.Drawing.Point(0, 0);
            this.tab1QLBanAn1.Margin = new System.Windows.Forms.Padding(4);
            this.tab1QLBanAn1.Name = "tab1QLBanAn1";
            this.tab1QLBanAn1.Size = new System.Drawing.Size(1091, 804);
            this.tab1QLBanAn1.TabIndex = 38;
            // 
            // tab2QLThucDon1
            // 
            this.tab2QLThucDon1.Location = new System.Drawing.Point(0, 0);
            this.tab2QLThucDon1.Margin = new System.Windows.Forms.Padding(4);
            this.tab2QLThucDon1.Name = "tab2QLThucDon1";
            this.tab2QLThucDon1.Size = new System.Drawing.Size(1091, 804);
            this.tab2QLThucDon1.TabIndex = 38;
            // 
            // tab3
            // 
            this.tab3.BackColor = System.Drawing.Color.Linen;
            this.tab3.Location = new System.Drawing.Point(0, 0);
            this.tab3.Margin = new System.Windows.Forms.Padding(4);
            this.tab3.Name = "tab3";
            this.tab3.Size = new System.Drawing.Size(1091, 804);
            this.tab3.TabIndex = 38;
            // 
            // tab4
            // 
            this.tab4.BackColor = System.Drawing.Color.Linen;
            this.tab4.Location = new System.Drawing.Point(0, 0);
            this.tab4.Margin = new System.Windows.Forms.Padding(4);
            this.tab4.Name = "tab4";
            this.tab4.Size = new System.Drawing.Size(1091, 804);
            this.tab4.TabIndex = 38;
            // 
            // tab5
            // 
            this.tab5.BackColor = System.Drawing.Color.Linen;
            this.tab5.Location = new System.Drawing.Point(0, 0);
            this.tab5.Margin = new System.Windows.Forms.Padding(4);
            this.tab5.Name = "tab5";
            this.tab5.Size = new System.Drawing.Size(1091, 804);
            this.tab5.TabIndex = 38;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.ControlBox = false;
            this.Controls.Add(this.gunaGradient2Panel2);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuFlatButton QLBAn;
        private Bunifu.Framework.UI.BunifuFlatButton QLTD;
        private Bunifu.Framework.UI.BunifuFlatButton QLNV;
        private Bunifu.Framework.UI.BunifuFlatButton QLHD;
        private Bunifu.Framework.UI.BunifuFlatButton TK;
        private Bunifu.Framework.UI.BunifuFlatButton Exit;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel2;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Tab1 tab1QLBanAn1;
        private Tab3 tab3;
        private Tab2 tab2QLThucDon1;
        private Tab4 tab4;
        private Tab5 tab5;
        private System.Windows.Forms.Panel panel1;
    }
}