namespace FormDangNhap
{
    partial class frmqlNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmqlNhanVien));
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTimTheo = new System.Windows.Forms.ComboBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.dgvFrm_qlNhanVien = new System.Windows.Forms.DataGridView();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayVaoLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayVL = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSuaThongTinNV = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrm_qlNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cbbTimTheo
            // 
            this.cbbTimTheo.BackColor = System.Drawing.Color.White;
            this.cbbTimTheo.DropDownHeight = 120;
            this.cbbTimTheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimTheo.FormattingEnabled = true;
            resources.ApplyResources(this.cbbTimTheo, "cbbTimTheo");
            this.cbbTimTheo.Name = "cbbTimTheo";
            this.toolTip1.SetToolTip(this.cbbTimTheo, resources.GetString("cbbTimTheo.ToolTip"));
            this.cbbTimTheo.SelectedIndexChanged += new System.EventHandler(this.cbbTimTheo_SelectedIndexChanged);
            // 
            // txtTim
            // 
            resources.ApplyResources(this.txtTim, "txtTim");
            this.txtTim.Name = "txtTim";
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // dgvFrm_qlNhanVien
            // 
            this.dgvFrm_qlNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFrm_qlNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrm_qlNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNV,
            this.colTenNV,
            this.colNgaySinh,
            this.colNgayVaoLam,
            this.colGioiTinh,
            this.colChucVu,
            this.colSDT,
            this.colEmail});
            resources.ApplyResources(this.dgvFrm_qlNhanVien, "dgvFrm_qlNhanVien");
            this.dgvFrm_qlNhanVien.Name = "dgvFrm_qlNhanVien";
            this.dgvFrm_qlNhanVien.RowTemplate.Height = 24;
            this.dgvFrm_qlNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFrm_qlNhanVien_CellClick);
            // 
            // colMaNV
            // 
            this.colMaNV.DataPropertyName = "MaNV";
            resources.ApplyResources(this.colMaNV, "colMaNV");
            this.colMaNV.Name = "colMaNV";
            // 
            // colTenNV
            // 
            this.colTenNV.DataPropertyName = "TenNV";
            resources.ApplyResources(this.colTenNV, "colTenNV");
            this.colTenNV.Name = "colTenNV";
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DataPropertyName = "NgaySinh";
            resources.ApplyResources(this.colNgaySinh, "colNgaySinh");
            this.colNgaySinh.Name = "colNgaySinh";
            // 
            // colNgayVaoLam
            // 
            this.colNgayVaoLam.DataPropertyName = "NgayVaoLam";
            resources.ApplyResources(this.colNgayVaoLam, "colNgayVaoLam");
            this.colNgayVaoLam.Name = "colNgayVaoLam";
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.DataPropertyName = "GioiTinh";
            resources.ApplyResources(this.colGioiTinh, "colGioiTinh");
            this.colGioiTinh.Name = "colGioiTinh";
            // 
            // colChucVu
            // 
            this.colChucVu.DataPropertyName = "ChucVu";
            resources.ApplyResources(this.colChucVu, "colChucVu");
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colChucVu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSDT
            // 
            this.colSDT.DataPropertyName = "SDT";
            resources.ApplyResources(this.colSDT, "colSDT");
            this.colSDT.Name = "colSDT";
            this.colSDT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSDT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            resources.ApplyResources(this.colEmail, "colEmail");
            this.colEmail.Name = "colEmail";
            this.colEmail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtHoTen
            // 
            resources.ApplyResources(this.txtHoTen, "txtHoTen");
            this.txtHoTen.Name = "txtHoTen";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // dtpNgayVL
            // 
            resources.ApplyResources(this.dtpNgayVL, "dtpNgayVL");
            this.dtpNgayVL.Name = "dtpNgayVL";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // dtpNgaySinh
            // 
            resources.ApplyResources(this.dtpNgaySinh, "dtpNgaySinh");
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtMaNV
            // 
            resources.ApplyResources(this.txtMaNV, "txtMaNV");
            this.txtMaNV.Name = "txtMaNV";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // txtSDT
            // 
            resources.ApplyResources(this.txtSDT, "txtSDT");
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChucVu.FormattingEnabled = true;
            resources.ApplyResources(this.cbbChucVu, "cbbChucVu");
            this.cbbChucVu.Name = "cbbChucVu";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // rbNu
            // 
            resources.ApplyResources(this.rbNu, "rbNu");
            this.rbNu.Name = "rbNu";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            // 
            // rbNam
            // 
            resources.ApplyResources(this.rbNam, "rbNam");
            this.rbNam.Checked = true;
            this.rbNam.Name = "rbNam";
            this.rbNam.TabStop = true;
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::FormDangNhap.Properties.Resources._020_note;
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Name = "btnClear";
            this.toolTip1.SetToolTip(this.btnClear, resources.GetString("btnClear.ToolTip"));
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = global::FormDangNhap.Properties.Resources.cancel;
            resources.ApplyResources(this.btnThoat, "btnThoat");
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.Name = "btnThoat";
            this.toolTip1.SetToolTip(this.btnThoat, resources.GetString("btnThoat.ToolTip"));
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::FormDangNhap.Properties.Resources._012_trash_can;
            resources.ApplyResources(this.btnXoa, "btnXoa");
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Name = "btnXoa";
            this.toolTip1.SetToolTip(this.btnXoa, resources.GetString("btnXoa.ToolTip"));
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSuaThongTinNV
            // 
            this.btnSuaThongTinNV.BackColor = System.Drawing.Color.White;
            this.btnSuaThongTinNV.BackgroundImage = global::FormDangNhap.Properties.Resources._006_writing;
            resources.ApplyResources(this.btnSuaThongTinNV, "btnSuaThongTinNV");
            this.btnSuaThongTinNV.FlatAppearance.BorderSize = 0;
            this.btnSuaThongTinNV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSuaThongTinNV.Name = "btnSuaThongTinNV";
            this.toolTip1.SetToolTip(this.btnSuaThongTinNV, resources.GetString("btnSuaThongTinNV.ToolTip"));
            this.btnSuaThongTinNV.UseVisualStyleBackColor = false;
            this.btnSuaThongTinNV.Click += new System.EventHandler(this.btnSuaThongTinNV_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.Color.White;
            this.btnThemNV.BackgroundImage = global::FormDangNhap.Properties.Resources._002_note_book;
            resources.ApplyResources(this.btnThemNV, "btnThemNV");
            this.btnThemNV.FlatAppearance.BorderSize = 0;
            this.btnThemNV.Name = "btnThemNV";
            this.toolTip1.SetToolTip(this.btnThemNV, resources.GetString("btnThemNV.ToolTip"));
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // frmqlNhanVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rbNu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.rbNam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbbChucVu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpNgayVL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSuaThongTinNV);
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbTimTheo);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.dgvFrm_qlNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmqlNhanVien";
            this.Load += new System.EventHandler(this.frmqlNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrm_qlNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSuaThongTinNV;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTimTheo;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.DataGridView dgvFrm_qlNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayVL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbChucVu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayVaoLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}