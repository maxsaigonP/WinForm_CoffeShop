namespace FormDangNhap
{
    partial class frmCTSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCTSP));
            this.cbbMaNL = new System.Windows.Forms.ComboBox();
            this.cbbMaSP = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemCTSP = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvCTSP = new System.Windows.Forms.DataGridView();
            this.colMaSoBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTSP)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbMaNL
            // 
            this.cbbMaNL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaNL.FormattingEnabled = true;
            this.cbbMaNL.Location = new System.Drawing.Point(229, 117);
            this.cbbMaNL.Name = "cbbMaNL";
            this.cbbMaNL.Size = new System.Drawing.Size(170, 31);
            this.cbbMaNL.TabIndex = 108;
            // 
            // cbbMaSP
            // 
            this.cbbMaSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaSP.FormattingEnabled = true;
            this.cbbMaSP.Location = new System.Drawing.Point(13, 117);
            this.cbbMaSP.Name = "cbbMaSP";
            this.cbbMaSP.Size = new System.Drawing.Size(170, 31);
            this.cbbMaSP.TabIndex = 107;
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::FormDangNhap.Properties.Resources._020_note;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(412, 281);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 50);
            this.btnClear.TabIndex = 105;
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
            this.btnThoat.Location = new System.Drawing.Point(418, 422);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(40, 40);
            this.btnThoat.TabIndex = 106;
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
            this.btnXoa.Location = new System.Drawing.Point(417, 211);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(50, 50);
            this.btnXoa.TabIndex = 104;
            this.toolTip1.SetToolTip(this.btnXoa, "Nhấp vào đây để xóa");
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemCTSP
            // 
            this.btnThemCTSP.BackColor = System.Drawing.Color.White;
            this.btnThemCTSP.BackgroundImage = global::FormDangNhap.Properties.Resources._002_note_book;
            this.btnThemCTSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemCTSP.FlatAppearance.BorderSize = 0;
            this.btnThemCTSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemCTSP.Location = new System.Drawing.Point(417, 144);
            this.btnThemCTSP.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemCTSP.Name = "btnThemCTSP";
            this.btnThemCTSP.Size = new System.Drawing.Size(50, 50);
            this.btnThemCTSP.TabIndex = 102;
            this.toolTip1.SetToolTip(this.btnThemCTSP, "Nhấp vào đây để thêm một chi tiết sản phẩm");
            this.btnThemCTSP.UseVisualStyleBackColor = false;
            this.btnThemCTSP.Click += new System.EventHandler(this.btnThemCTSP_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(13, 68);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4);
            this.txtTim.Multiline = true;
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(170, 30);
            this.txtTim.TabIndex = 101;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(37, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(362, 29);
            this.label6.TabIndex = 100;
            this.label6.Text = "QUẢN LÝ CHI TIẾT SẢN PHẨM";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvCTSP
            // 
            this.dgvCTSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSoBan,
            this.colSoGhe});
            this.dgvCTSP.Location = new System.Drawing.Point(13, 158);
            this.dgvCTSP.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCTSP.Name = "dgvCTSP";
            this.dgvCTSP.RowTemplate.Height = 24;
            this.dgvCTSP.Size = new System.Drawing.Size(386, 304);
            this.dgvCTSP.TabIndex = 99;
            this.dgvCTSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTSP_CellClick);
            // 
            // colMaSoBan
            // 
            this.colMaSoBan.DataPropertyName = "MaSP";
            this.colMaSoBan.HeaderText = "Mã sản phẩm";
            this.colMaSoBan.Name = "colMaSoBan";
            // 
            // colSoGhe
            // 
            this.colSoGhe.DataPropertyName = "MaNL";
            this.colSoGhe.HeaderText = "Mã nguyên liệu";
            this.colSoGhe.Name = "colSoGhe";
            // 
            // frmCTSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(484, 484);
            this.Controls.Add(this.cbbMaNL);
            this.Controls.Add(this.cbbMaSP);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemCTSP);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvCTSP);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCTSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Chi Tiết Sản Phẩm";
            this.Load += new System.EventHandler(this.frmCTSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbMaNL;
        private System.Windows.Forms.ComboBox cbbMaSP;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemCTSP;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvCTSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSoBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoGhe;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}