namespace RestaurantManagerment
{
    partial class FormChuyenBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChuyenBan));
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChuyenBan = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChuyenBan = new System.Windows.Forms.ComboBox();
            this.btnClose = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaShadowPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.DarkGray;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaShadowPanel1.Controls.Add(this.panel1);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Crimson;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(337, 190);
            this.gunaShadowPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnChuyenBan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbChuyenBan);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 181);
            this.panel1.TabIndex = 0;
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.AnimationHoverSpeed = 0.07F;
            this.btnChuyenBan.AnimationSpeed = 0.03F;
            this.btnChuyenBan.BackColor = System.Drawing.Color.Transparent;
            this.btnChuyenBan.BaseColor = System.Drawing.Color.RoyalBlue;
            this.btnChuyenBan.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnChuyenBan.BorderSize = 2;
            this.btnChuyenBan.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnChuyenBan.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnChuyenBan.CheckedForeColor = System.Drawing.Color.White;
            this.btnChuyenBan.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnChuyenBan.CheckedImage")));
            this.btnChuyenBan.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnChuyenBan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChuyenBan.FocusedColor = System.Drawing.Color.Empty;
            this.btnChuyenBan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenBan.ForeColor = System.Drawing.Color.White;
            this.btnChuyenBan.Image = null;
            this.btnChuyenBan.ImageSize = new System.Drawing.Size(20, 20);
            this.btnChuyenBan.LineColor = System.Drawing.Color.Red;
            this.btnChuyenBan.Location = new System.Drawing.Point(116, 113);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnChuyenBan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChuyenBan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChuyenBan.OnHoverImage = null;
            this.btnChuyenBan.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnChuyenBan.OnPressedColor = System.Drawing.Color.Black;
            this.btnChuyenBan.Size = new System.Drawing.Size(89, 30);
            this.btnChuyenBan.TabIndex = 5;
            this.btnChuyenBan.Text = "Chuyển";
            this.btnChuyenBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnChuyenBan.Click += new System.EventHandler(this.btnChuyenBan_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn Bàn Muốn Chuyển Đến";
            // 
            // cbChuyenBan
            // 
            this.cbChuyenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChuyenBan.FormattingEnabled = true;
            this.cbChuyenBan.Location = new System.Drawing.Point(105, 72);
            this.cbChuyenBan.Name = "cbChuyenBan";
            this.cbChuyenBan.Size = new System.Drawing.Size(111, 24);
            this.cbChuyenBan.TabIndex = 3;
            this.cbChuyenBan.SelectedIndexChanged += new System.EventHandler(this.cbChuyenBan_SelectedIndexChanged_1);
            // 
            // btnClose
            // 
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnClose.BorderColor = System.Drawing.Color.Black;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.FocusedColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.Location = new System.Drawing.Point(303, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 6;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormChuyenBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(337, 190);
            this.Controls.Add(this.gunaShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(507, 123);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChuyenBan";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChuyenBan";
            this.Load += new System.EventHandler(this.FormChuyenBan_Load);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnChuyenBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbChuyenBan;
        private Guna.UI.WinForms.GunaCircleButton btnClose;
    }
}