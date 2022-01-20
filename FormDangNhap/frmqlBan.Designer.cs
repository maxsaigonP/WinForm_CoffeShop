namespace FormDangNhap
{
    partial class frmqlBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmqlBan));
            this.label1 = new System.Windows.Forms.Label();
            this.nmSoGhe = new System.Windows.Forms.NumericUpDown();
            this.dgvQLBan = new System.Windows.Forms.DataGridView();
            this.colMaSoBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThemBan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaBan = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmSoGhe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLBan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số ghế:";
            // 
            // nmSoGhe
            // 
            this.nmSoGhe.Location = new System.Drawing.Point(130, 154);
            this.nmSoGhe.Margin = new System.Windows.Forms.Padding(4);
            this.nmSoGhe.Name = "nmSoGhe";
            this.nmSoGhe.Size = new System.Drawing.Size(104, 30);
            this.nmSoGhe.TabIndex = 4;
            // 
            // dgvQLBan
            // 
            this.dgvQLBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSoBan,
            this.colSoGhe,
            this.colTinhTrang});
            this.dgvQLBan.Location = new System.Drawing.Point(13, 207);
            this.dgvQLBan.Margin = new System.Windows.Forms.Padding(4);
            this.dgvQLBan.Name = "dgvQLBan";
            this.dgvQLBan.RowTemplate.Height = 24;
            this.dgvQLBan.Size = new System.Drawing.Size(386, 304);
            this.dgvQLBan.TabIndex = 3;
            this.dgvQLBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLBan_CellClick);
            // 
            // colMaSoBan
            // 
            this.colMaSoBan.DataPropertyName = "MaSoBan";
            this.colMaSoBan.HeaderText = "Mã số bàn";
            this.colMaSoBan.Name = "colMaSoBan";
            // 
            // colSoGhe
            // 
            this.colSoGhe.DataPropertyName = "SoGhe";
            this.colSoGhe.HeaderText = "Số ghế";
            this.colSoGhe.Name = "colSoGhe";
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.DataPropertyName = "TinhTrang";
            this.colTinhTrang.HeaderText = "Tình Trạng";
            this.colTinhTrang.Name = "colTinhTrang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(125, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 29);
            this.label6.TabIndex = 76;
            this.label6.Text = "QUẢN LÝ BÀN";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(130, 56);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4);
            this.txtTim.Multiline = true;
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(222, 30);
            this.txtTim.TabIndex = 77;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            this.txtTim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTim_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 79;
            this.label2.Text = "Tìm kiếm:";
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::FormDangNhap.Properties.Resources._020_note;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(414, 403);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 50);
            this.btnClear.TabIndex = 83;
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
            this.btnThoat.Location = new System.Drawing.Point(419, 471);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(40, 40);
            this.btnThoat.TabIndex = 84;
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
            this.btnXoa.Location = new System.Drawing.Point(420, 333);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(50, 50);
            this.btnXoa.TabIndex = 82;
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
            this.btnSua.Location = new System.Drawing.Point(418, 263);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(50, 50);
            this.btnSua.TabIndex = 81;
            this.toolTip1.SetToolTip(this.btnSua, "Nhấp vào đây để cập nhật thông tin");
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemBan
            // 
            this.btnThemBan.BackColor = System.Drawing.Color.White;
            this.btnThemBan.BackgroundImage = global::FormDangNhap.Properties.Resources._002_note_book;
            this.btnThemBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemBan.FlatAppearance.BorderSize = 0;
            this.btnThemBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemBan.Location = new System.Drawing.Point(419, 193);
            this.btnThemBan.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemBan.Name = "btnThemBan";
            this.btnThemBan.Size = new System.Drawing.Size(50, 50);
            this.btnThemBan.TabIndex = 80;
            this.toolTip1.SetToolTip(this.btnThemBan, "Nhấp vào đây để thêm bàn");
            this.btnThemBan.UseVisualStyleBackColor = false;
            this.btnThemBan.Click += new System.EventHandler(this.btnThemBan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 86;
            this.label3.Text = "Mã bàn:";
            // 
            // txtMaBan
            // 
            this.txtMaBan.Location = new System.Drawing.Point(130, 106);
            this.txtMaBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaBan.Multiline = true;
            this.txtMaBan.Name = "txtMaBan";
            this.txtMaBan.Size = new System.Drawing.Size(222, 30);
            this.txtMaBan.TabIndex = 85;
            // 
            // frmqlBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 523);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaBan);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThemBan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmSoGhe);
            this.Controls.Add(this.dgvQLBan);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmqlBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bàn";
            this.Load += new System.EventHandler(this.frmqlBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmSoGhe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmSoGhe;
        private System.Windows.Forms.DataGridView dgvQLBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThemBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSoBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTinhTrang;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}