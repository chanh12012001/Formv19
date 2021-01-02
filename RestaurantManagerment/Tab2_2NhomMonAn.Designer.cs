namespace RestaurantManagerment
{
    partial class Tab2_2NhomMonAn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnXoaNhomMonAn = new System.Windows.Forms.Button();
            this.btnSuaNhomMonAn = new System.Windows.Forms.Button();
            this.btnThemNhomMon = new System.Windows.Forms.Button();
            this.dtgrvDanhSachNhomMon = new Guna.UI.WinForms.GunaDataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.txtMaNhomMon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvDanhSachNhomMon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(308, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 90;
            this.label9.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiem.Location = new System.Drawing.Point(383, 227);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(144, 26);
            this.txtTimKiem.TabIndex = 91;
            this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_Click);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // btnXoaNhomMonAn
            // 
            this.btnXoaNhomMonAn.BackColor = System.Drawing.Color.Tomato;
            this.btnXoaNhomMonAn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNhomMonAn.Location = new System.Drawing.Point(216, 225);
            this.btnXoaNhomMonAn.Name = "btnXoaNhomMonAn";
            this.btnXoaNhomMonAn.Size = new System.Drawing.Size(80, 28);
            this.btnXoaNhomMonAn.TabIndex = 89;
            this.btnXoaNhomMonAn.Text = "Xóa";
            this.btnXoaNhomMonAn.UseVisualStyleBackColor = false;
            this.btnXoaNhomMonAn.Click += new System.EventHandler(this.btnXoaNhomMonAn_Click);
            // 
            // btnSuaNhomMonAn
            // 
            this.btnSuaNhomMonAn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSuaNhomMonAn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNhomMonAn.Location = new System.Drawing.Point(126, 225);
            this.btnSuaNhomMonAn.Name = "btnSuaNhomMonAn";
            this.btnSuaNhomMonAn.Size = new System.Drawing.Size(80, 28);
            this.btnSuaNhomMonAn.TabIndex = 88;
            this.btnSuaNhomMonAn.Text = "Sửa";
            this.btnSuaNhomMonAn.UseVisualStyleBackColor = false;
            this.btnSuaNhomMonAn.Click += new System.EventHandler(this.btnSuaNhomMonAn_Click);
            // 
            // btnThemNhomMon
            // 
            this.btnThemNhomMon.BackColor = System.Drawing.Color.PaleGreen;
            this.btnThemNhomMon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNhomMon.Location = new System.Drawing.Point(34, 225);
            this.btnThemNhomMon.Name = "btnThemNhomMon";
            this.btnThemNhomMon.Size = new System.Drawing.Size(80, 28);
            this.btnThemNhomMon.TabIndex = 87;
            this.btnThemNhomMon.Text = "Thêm";
            this.btnThemNhomMon.UseVisualStyleBackColor = false;
            this.btnThemNhomMon.Click += new System.EventHandler(this.btnThemNhomMon_Click);
            // 
            // dtgrvDanhSachNhomMon
            // 
            this.dtgrvDanhSachNhomMon.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dtgrvDanhSachNhomMon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgrvDanhSachNhomMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrvDanhSachNhomMon.BackgroundColor = System.Drawing.Color.White;
            this.dtgrvDanhSachNhomMon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgrvDanhSachNhomMon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrvDanhSachNhomMon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgrvDanhSachNhomMon.ColumnHeadersHeight = 30;
            this.dtgrvDanhSachNhomMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrvDanhSachNhomMon.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtgrvDanhSachNhomMon.EnableHeadersVisualStyles = false;
            this.dtgrvDanhSachNhomMon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgrvDanhSachNhomMon.Location = new System.Drawing.Point(41, 281);
            this.dtgrvDanhSachNhomMon.Margin = new System.Windows.Forms.Padding(2);
            this.dtgrvDanhSachNhomMon.Name = "dtgrvDanhSachNhomMon";
            this.dtgrvDanhSachNhomMon.ReadOnly = true;
            this.dtgrvDanhSachNhomMon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgrvDanhSachNhomMon.RowHeadersVisible = false;
            this.dtgrvDanhSachNhomMon.RowHeadersWidth = 51;
            this.dtgrvDanhSachNhomMon.RowTemplate.Height = 24;
            this.dtgrvDanhSachNhomMon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrvDanhSachNhomMon.Size = new System.Drawing.Size(486, 309);
            this.dtgrvDanhSachNhomMon.TabIndex = 86;
            this.dtgrvDanhSachNhomMon.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dtgrvDanhSachNhomMon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgrvDanhSachNhomMon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgrvDanhSachNhomMon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgrvDanhSachNhomMon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgrvDanhSachNhomMon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgrvDanhSachNhomMon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgrvDanhSachNhomMon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgrvDanhSachNhomMon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgrvDanhSachNhomMon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgrvDanhSachNhomMon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgrvDanhSachNhomMon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgrvDanhSachNhomMon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgrvDanhSachNhomMon.ThemeStyle.HeaderStyle.Height = 30;
            this.dtgrvDanhSachNhomMon.ThemeStyle.ReadOnly = true;
            this.dtgrvDanhSachNhomMon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgrvDanhSachNhomMon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dtgrvDanhSachNhomMon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgrvDanhSachNhomMon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgrvDanhSachNhomMon.ThemeStyle.RowsStyle.Height = 24;
            this.dtgrvDanhSachNhomMon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgrvDanhSachNhomMon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dtgrvDanhSachNhomMon.Click += new System.EventHandler(this.dtgrvDanhSachNhomMon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenNhom);
            this.groupBox1.Controls.Add(this.txtMaNhomMon);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkViolet;
            this.groupBox1.Location = new System.Drawing.Point(38, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 171);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhóm Món Ăn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(47, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên Nhóm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(50, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã Nhóm";
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenNhom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhom.Location = new System.Drawing.Point(187, 112);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(222, 29);
            this.txtTenNhom.TabIndex = 3;
            // 
            // txtMaNhomMon
            // 
            this.txtMaNhomMon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNhomMon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhomMon.Location = new System.Drawing.Point(187, 56);
            this.txtMaNhomMon.Name = "txtMaNhomMon";
            this.txtMaNhomMon.Size = new System.Drawing.Size(222, 29);
            this.txtMaNhomMon.TabIndex = 2;
            // 
            // Tab2_2NhomMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnXoaNhomMonAn);
            this.Controls.Add(this.btnSuaNhomMonAn);
            this.Controls.Add(this.btnThemNhomMon);
            this.Controls.Add(this.dtgrvDanhSachNhomMon);
            this.Controls.Add(this.groupBox1);
            this.Name = "Tab2_2NhomMonAn";
            this.Size = new System.Drawing.Size(815, 614);
            this.Load += new System.EventHandler(this.Tab2_2NhomMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvDanhSachNhomMon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnXoaNhomMonAn;
        private System.Windows.Forms.Button btnSuaNhomMonAn;
        private System.Windows.Forms.Button btnThemNhomMon;
        private Guna.UI.WinForms.GunaDataGridView dtgrvDanhSachNhomMon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenNhom;
        private System.Windows.Forms.TextBox txtMaNhomMon;
    }
}
