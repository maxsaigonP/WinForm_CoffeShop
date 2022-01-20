namespace FormDangNhap
{
    partial class frmBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanHang));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBan = new System.Windows.Forms.TextBox();
            this.imgMon = new System.Windows.Forms.ImageList(this.components);
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.lv_Mon = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgIcon = new System.Windows.Forms.ImageList(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvBan = new System.Windows.Forms.ListView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDatBan = new System.Windows.Forms.Button();
            this.btnBanMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbbFrom = new System.Windows.Forms.ComboBox();
            this.cbbTo = new System.Windows.Forms.ComboBox();
            this.radChuyen = new System.Windows.Forms.RadioButton();
            this.radGop = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(902, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(903, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 34;
            this.label3.Text = "Đơn giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(903, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Món:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(903, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "Bàn:";
            // 
            // txtBan
            // 
            this.txtBan.Location = new System.Drawing.Point(1005, 10);
            this.txtBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtBan.Multiline = true;
            this.txtBan.Name = "txtBan";
            this.txtBan.ReadOnly = true;
            this.txtBan.Size = new System.Drawing.Size(214, 30);
            this.txtBan.TabIndex = 30;
            // 
            // imgMon
            // 
            this.imgMon.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgMon.ImageSize = new System.Drawing.Size(64, 64);
            this.imgMon.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(954, 566);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(188, 30);
            this.txtTongTien.TabIndex = 23;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số lượng";
            this.columnHeader6.Width = 133;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1007, 221);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(212, 30);
            this.numericUpDown1.TabIndex = 28;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(1005, 150);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGia.Multiline = true;
            this.txtGia.Name = "txtGia";
            this.txtGia.ReadOnly = true;
            this.txtGia.Size = new System.Drawing.Size(214, 30);
            this.txtGia.TabIndex = 27;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(1005, 80);
            this.txtTenMon.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenMon.Multiline = true;
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.ReadOnly = true;
            this.txtTenMon.Size = new System.Drawing.Size(214, 30);
            this.txtTenMon.TabIndex = 26;
            // 
            // lv_Mon
            // 
            this.lv_Mon.LargeImageList = this.imgMon;
            this.lv_Mon.Location = new System.Drawing.Point(489, 13);
            this.lv_Mon.Margin = new System.Windows.Forms.Padding(4);
            this.lv_Mon.Name = "lv_Mon";
            this.lv_Mon.Size = new System.Drawing.Size(397, 351);
            this.lv_Mon.TabIndex = 25;
            this.lv_Mon.UseCompatibleStateImageBehavior = false;
            this.lv_Mon.SelectedIndexChanged += new System.EventHandler(this.lv_Mon_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Đơn giá";
            this.columnHeader5.Width = 158;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã SP";
            this.columnHeader4.Width = 129;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên SP";
            this.columnHeader3.Width = 121;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã số bàn";
            this.columnHeader2.Width = 125;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView2.Location = new System.Drawing.Point(13, 372);
            this.listView2.Margin = new System.Windows.Forms.Padding(4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(873, 234);
            this.listView2.TabIndex = 22;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Thành tiền";
            this.columnHeader7.Width = 196;
            // 
            // imgIcon
            // 
            this.imgIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcon.ImageStream")));
            this.imgIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIcon.Images.SetKeyName(0, "ban.png");
            this.imgIcon.Images.SetKeyName(1, "coffee2.png");
            // 
            // lvBan
            // 
            this.lvBan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvBan.LargeImageList = this.imgIcon;
            this.lvBan.Location = new System.Drawing.Point(13, 13);
            this.lvBan.Margin = new System.Windows.Forms.Padding(4);
            this.lvBan.Name = "lvBan";
            this.lvBan.Size = new System.Drawing.Size(468, 351);
            this.lvBan.TabIndex = 21;
            this.lvBan.UseCompatibleStateImageBehavior = false;
            this.lvBan.SelectedIndexChanged += new System.EventHandler(this.lvBan_SelectedIndexChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = global::FormDangNhap.Properties.Resources.cancel;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(1171, 561);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(40, 40);
            this.btnThoat.TabIndex = 38;
            this.toolTip1.SetToolTip(this.btnThoat, "Nhấp vào đây để thoát");
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDatBan
            // 
            this.btnDatBan.BackgroundImage = global::FormDangNhap.Properties.Resources.booking;
            this.btnDatBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDatBan.FlatAppearance.BorderSize = 0;
            this.btnDatBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatBan.Location = new System.Drawing.Point(1150, 289);
            this.btnDatBan.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatBan.Name = "btnDatBan";
            this.btnDatBan.Size = new System.Drawing.Size(60, 60);
            this.btnDatBan.TabIndex = 37;
            this.toolTip1.SetToolTip(this.btnDatBan, "           ĐẶT BÀN\r\nNhấp vào đây để đặt bàn");
            this.btnDatBan.UseVisualStyleBackColor = true;
            this.btnDatBan.Click += new System.EventHandler(this.btnDatBan_Click);
            // 
            // btnBanMoi
            // 
            this.btnBanMoi.BackgroundImage = global::FormDangNhap.Properties.Resources.coffee;
            this.btnBanMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBanMoi.FlatAppearance.BorderSize = 0;
            this.btnBanMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanMoi.Location = new System.Drawing.Point(928, 285);
            this.btnBanMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnBanMoi.Name = "btnBanMoi";
            this.btnBanMoi.Size = new System.Drawing.Size(60, 60);
            this.btnBanMoi.TabIndex = 36;
            this.toolTip1.SetToolTip(this.btnBanMoi, "                     BÀN MỚI\r\nNhấp vào đây để chọn một bàn mới");
            this.btnBanMoi.UseVisualStyleBackColor = true;
            this.btnBanMoi.Click += new System.EventHandler(this.btnBanMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = global::FormDangNhap.Properties.Resources.NutThemMon;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(1044, 294);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(50, 50);
            this.btnThem.TabIndex = 29;
            this.toolTip1.SetToolTip(this.btnThem, "           THÊM MÓN\r\nNhấp vào đây để thêm món");
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackgroundImage = global::FormDangNhap.Properties.Resources._023_payment;
            this.btnThanhToan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Location = new System.Drawing.Point(894, 561);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(40, 40);
            this.btnThanhToan.TabIndex = 24;
            this.toolTip1.SetToolTip(this.btnThanhToan, "         THANH TOÁN\r\nNhấp vào đây để thanh toán");
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // cbbFrom
            // 
            this.cbbFrom.FormattingEnabled = true;
            this.cbbFrom.Location = new System.Drawing.Point(928, 419);
            this.cbbFrom.Name = "cbbFrom";
            this.cbbFrom.Size = new System.Drawing.Size(121, 31);
            this.cbbFrom.TabIndex = 39;
            // 
            // cbbTo
            // 
            this.cbbTo.FormattingEnabled = true;
            this.cbbTo.Location = new System.Drawing.Point(1098, 419);
            this.cbbTo.Name = "cbbTo";
            this.cbbTo.Size = new System.Drawing.Size(121, 31);
            this.cbbTo.TabIndex = 40;
            // 
            // radChuyen
            // 
            this.radChuyen.AutoSize = true;
            this.radChuyen.Location = new System.Drawing.Point(907, 386);
            this.radChuyen.Name = "radChuyen";
            this.radChuyen.Size = new System.Drawing.Size(134, 27);
            this.radChuyen.TabIndex = 41;
            this.radChuyen.TabStop = true;
            this.radChuyen.Text = "Chuyển bàn";
            this.radChuyen.UseVisualStyleBackColor = true;
            this.radChuyen.CheckedChanged += new System.EventHandler(this.radChuyen_CheckedChanged);
            // 
            // radGop
            // 
            this.radGop.AutoSize = true;
            this.radGop.Location = new System.Drawing.Point(1078, 386);
            this.radGop.Name = "radGop";
            this.radGop.Size = new System.Drawing.Size(107, 27);
            this.radGop.TabIndex = 42;
            this.radGop.TabStop = true;
            this.radGop.Text = "Gộp bàn";
            this.radGop.UseVisualStyleBackColor = true;
            this.radGop.CheckedChanged += new System.EventHandler(this.radGop_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(1007, 489);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(123, 45);
            this.btnOK.TabIndex = 43;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1232, 619);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.radGop);
            this.Controls.Add(this.radChuyen);
            this.Controls.Add(this.cbbTo);
            this.Controls.Add(this.cbbFrom);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDatBan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBan);
            this.Controls.Add(this.btnBanMoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.lv_Mon);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.lvBan);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBanHang";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDatBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBan;
        private System.Windows.Forms.ImageList imgMon;
        private System.Windows.Forms.Button btnBanMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.ListView lv_Mon;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ImageList imgIcon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lvBan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cbbFrom;
        private System.Windows.Forms.ComboBox cbbTo;
        private System.Windows.Forms.RadioButton radChuyen;
        private System.Windows.Forms.RadioButton radGop;
        private System.Windows.Forms.Button btnOK;
    }
}