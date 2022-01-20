namespace FormDangNhap
{
    partial class frmqlTaiKhoan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmqlTaiKhoan));
            this.dgvFrm_qlTaiKhoan = new System.Windows.Forms.DataGridView();
            this.colTenTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTimTheo = new System.Windows.Forms.ComboBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNhapLaiMK = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbbLoaiTK = new System.Windows.Forms.ComboBox();
            this.pbMK = new System.Windows.Forms.PictureBox();
            this.pbNhapLai = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrm_qlTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNhapLai)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFrm_qlTaiKhoan
            // 
            this.dgvFrm_qlTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFrm_qlTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrm_qlTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenTK,
            this.colMK,
            this.colMaNV,
            this.colLoaiTK});
            this.dgvFrm_qlTaiKhoan.Location = new System.Drawing.Point(17, 241);
            this.dgvFrm_qlTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFrm_qlTaiKhoan.Name = "dgvFrm_qlTaiKhoan";
            this.dgvFrm_qlTaiKhoan.RowTemplate.Height = 24;
            this.dgvFrm_qlTaiKhoan.Size = new System.Drawing.Size(734, 293);
            this.dgvFrm_qlTaiKhoan.TabIndex = 23;
            this.dgvFrm_qlTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFrm_qlTaiKhoan_CellClick);
            // 
            // colTenTK
            // 
            this.colTenTK.DataPropertyName = "TenTK";
            this.colTenTK.HeaderText = "Tên tài khoản";
            this.colTenTK.Name = "colTenTK";
            // 
            // colMK
            // 
            this.colMK.DataPropertyName = "MatKhau";
            this.colMK.HeaderText = "Mật khẩu";
            this.colMK.Name = "colMK";
            // 
            // colMaNV
            // 
            this.colMaNV.DataPropertyName = "MaNV";
            this.colMaNV.HeaderText = "Mã nhân viên";
            this.colMaNV.Name = "colMaNV";
            // 
            // colLoaiTK
            // 
            this.colLoaiTK.DataPropertyName = "LoaiTK";
            this.colLoaiTK.HeaderText = "Loại tài khoản";
            this.colLoaiTK.Name = "colLoaiTK";
            this.colLoaiTK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLoaiTK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 23);
            this.label5.TabIndex = 70;
            this.label5.Text = "Loại tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 68;
            this.label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 67;
            this.label2.Text = "Tên tài khoản:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(191, 155);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(226, 30);
            this.txtMatKhau.TabIndex = 3;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(191, 107);
            this.txtTenTaiKhoan.Multiline = true;
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(226, 30);
            this.txtTenTaiKhoan.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(259, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 29);
            this.label6.TabIndex = 75;
            this.label6.Text = "QUẢN LÝ TÀI KHOẢN";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 74;
            this.label1.Text = "Tìm theo:";
            // 
            // cbbTimTheo
            // 
            this.cbbTimTheo.BackColor = System.Drawing.Color.White;
            this.cbbTimTheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimTheo.FormattingEnabled = true;
            this.cbbTimTheo.Location = new System.Drawing.Point(191, 59);
            this.cbbTimTheo.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTimTheo.Name = "cbbTimTheo";
            this.cbbTimTheo.Size = new System.Drawing.Size(139, 31);
            this.cbbTimTheo.TabIndex = 73;
            this.toolTip1.SetToolTip(this.cbbTimTheo, "Bộ lọc tìm kiếm");
            this.cbbTimTheo.SelectedIndexChanged += new System.EventHandler(this.cbbTimTheo_SelectedIndexChanged);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(344, 59);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4);
            this.txtTim.Multiline = true;
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(222, 26);
            this.txtTim.TabIndex = 0;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 23);
            this.label4.TabIndex = 77;
            this.label4.Text = "Nhập lại mật khẩu:";
            // 
            // txtNhapLaiMK
            // 
            this.txtNhapLaiMK.Location = new System.Drawing.Point(191, 203);
            this.txtNhapLaiMK.Name = "txtNhapLaiMK";
            this.txtNhapLaiMK.Size = new System.Drawing.Size(226, 30);
            this.txtNhapLaiMK.TabIndex = 4;
            this.txtNhapLaiMK.UseSystemPasswordChar = true;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(591, 155);
            this.txtMaNV.Multiline = true;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(160, 30);
            this.txtMaNV.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(447, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 23);
            this.label7.TabIndex = 78;
            this.label7.Text = "Mã nhân viên:";
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::FormDangNhap.Properties.Resources._020_note;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(772, 379);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 50);
            this.btnClear.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnClear, "Nhấp vào đây để làm sạch các ô textbox");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = global::FormDangNhap.Properties.Resources.cancel;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(777, 494);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(40, 40);
            this.btnThoat.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnThoat, "Nhấp vào đây để thoát");
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::FormDangNhap.Properties.Resources._012_trash_can;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(777, 280);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(50, 50);
            this.btnXoa.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnXoa, "Nhấp vào đây để xóa");
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.BackgroundImage = global::FormDangNhap.Properties.Resources._006_writing;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSua.Location = new System.Drawing.Point(777, 181);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(50, 50);
            this.btnSua.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnSua, "Nhấp vào đây để cập nhật thông tin");
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.BackgroundImage = global::FormDangNhap.Properties.Resources._002_note_book;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(777, 82);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(50, 50);
            this.btnThem.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnThem, "Nhấp vào đây để thêm một tài khoản");
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbbLoaiTK
            // 
            this.cbbLoaiTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiTK.FormattingEnabled = true;
            this.cbbLoaiTK.Location = new System.Drawing.Point(591, 203);
            this.cbbLoaiTK.Name = "cbbLoaiTK";
            this.cbbLoaiTK.Size = new System.Drawing.Size(160, 31);
            this.cbbLoaiTK.TabIndex = 6;
            // 
            // pbMK
            // 
            this.pbMK.BackColor = System.Drawing.Color.Transparent;
            this.pbMK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbMK.Location = new System.Drawing.Point(390, 159);
            this.pbMK.Name = "pbMK";
            this.pbMK.Size = new System.Drawing.Size(20, 20);
            this.pbMK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMK.TabIndex = 116;
            this.pbMK.TabStop = false;
            this.pbMK.MouseLeave += new System.EventHandler(this.pbMK_MouseLeave);
            this.pbMK.MouseHover += new System.EventHandler(this.pbMK_MouseHover);
            // 
            // pbNhapLai
            // 
            this.pbNhapLai.BackColor = System.Drawing.Color.Transparent;
            this.pbNhapLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbNhapLai.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbNhapLai.Location = new System.Drawing.Point(390, 207);
            this.pbNhapLai.Name = "pbNhapLai";
            this.pbNhapLai.Size = new System.Drawing.Size(20, 20);
            this.pbNhapLai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNhapLai.TabIndex = 117;
            this.pbNhapLai.TabStop = false;
            this.pbNhapLai.MouseLeave += new System.EventHandler(this.pbNhapLai_MouseLeave);
            this.pbNhapLai.MouseHover += new System.EventHandler(this.pbNhapLai_MouseHover);
            // 
            // frmqlTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(840, 547);
            this.Controls.Add(this.pbNhapLai);
            this.Controls.Add(this.pbMK);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNhapLaiMK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbTimTheo);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbLoaiTK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvFrm_qlTaiKhoan);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmqlTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.frmqlTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrm_qlTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNhapLai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFrm_qlTaiKhoan;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTimTheo;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNhapLaiMK;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiTK;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cbbLoaiTK;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox pbMK;
        private System.Windows.Forms.PictureBox pbNhapLai;
    }
}