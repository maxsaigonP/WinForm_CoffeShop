namespace FormDangNhap
{
    partial class frmBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCao));
            this.rdXemDSHDTheoNgay = new System.Windows.Forms.RadioButton();
            this.rdDoanhThu = new System.Windows.Forms.RadioButton();
            this.rdDSNVTheoNgay = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayB = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayA = new System.Windows.Forms.DateTimePicker();
            this.rdXemDSHD = new System.Windows.Forms.RadioButton();
            this.rdXemDSNV = new System.Windows.Forms.RadioButton();
            this.rdXemSLTK = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdXemDSHDTheoNgay
            // 
            this.rdXemDSHDTheoNgay.AutoSize = true;
            this.rdXemDSHDTheoNgay.Location = new System.Drawing.Point(413, 86);
            this.rdXemDSHDTheoNgay.Margin = new System.Windows.Forms.Padding(4);
            this.rdXemDSHDTheoNgay.Name = "rdXemDSHDTheoNgay";
            this.rdXemDSHDTheoNgay.Size = new System.Drawing.Size(223, 27);
            this.rdXemDSHDTheoNgay.TabIndex = 128;
            this.rdXemDSHDTheoNgay.TabStop = true;
            this.rdXemDSHDTheoNgay.Text = "Xem DSHD theo ngày";
            this.rdXemDSHDTheoNgay.UseVisualStyleBackColor = true;
            this.rdXemDSHDTheoNgay.CheckedChanged += new System.EventHandler(this.rdXemDSHDTheoNgay_CheckedChanged);
            // 
            // rdDoanhThu
            // 
            this.rdDoanhThu.AutoSize = true;
            this.rdDoanhThu.Location = new System.Drawing.Point(413, 138);
            this.rdDoanhThu.Margin = new System.Windows.Forms.Padding(4);
            this.rdDoanhThu.Name = "rdDoanhThu";
            this.rdDoanhThu.Size = new System.Drawing.Size(162, 27);
            this.rdDoanhThu.TabIndex = 127;
            this.rdDoanhThu.TabStop = true;
            this.rdDoanhThu.Text = "Xem doanh thu";
            this.rdDoanhThu.UseVisualStyleBackColor = true;
            this.rdDoanhThu.CheckedChanged += new System.EventHandler(this.rdDoanhThu_CheckedChanged);
            // 
            // rdDSNVTheoNgay
            // 
            this.rdDSNVTheoNgay.AutoSize = true;
            this.rdDSNVTheoNgay.Location = new System.Drawing.Point(413, 34);
            this.rdDSNVTheoNgay.Margin = new System.Windows.Forms.Padding(4);
            this.rdDSNVTheoNgay.Name = "rdDSNVTheoNgay";
            this.rdDSNVTheoNgay.Size = new System.Drawing.Size(296, 27);
            this.rdDSNVTheoNgay.TabIndex = 126;
            this.rdDSNVTheoNgay.TabStop = true;
            this.rdDSNVTheoNgay.Text = "Xem DSNV theo ngày vào làm";
            this.rdDSNVTheoNgay.UseVisualStyleBackColor = true;
            this.rdDSNVTheoNgay.CheckedChanged += new System.EventHandler(this.rdDSNVTheoNgay_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 125;
            this.label2.Text = "Đến ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 124;
            this.label1.Text = "Từ ngày:";
            // 
            // dtpNgayB
            // 
            this.dtpNgayB.Enabled = false;
            this.dtpNgayB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayB.Location = new System.Drawing.Point(418, 186);
            this.dtpNgayB.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayB.Name = "dtpNgayB";
            this.dtpNgayB.Size = new System.Drawing.Size(137, 30);
            this.dtpNgayB.TabIndex = 123;
            // 
            // dtpNgayA
            // 
            this.dtpNgayA.Enabled = false;
            this.dtpNgayA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayA.Location = new System.Drawing.Point(156, 186);
            this.dtpNgayA.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayA.Name = "dtpNgayA";
            this.dtpNgayA.Size = new System.Drawing.Size(137, 30);
            this.dtpNgayA.TabIndex = 122;
            // 
            // rdXemDSHD
            // 
            this.rdXemDSHD.AutoSize = true;
            this.rdXemDSHD.Location = new System.Drawing.Point(29, 86);
            this.rdXemDSHD.Margin = new System.Windows.Forms.Padding(4);
            this.rdXemDSHD.Name = "rdXemDSHD";
            this.rdXemDSHD.Size = new System.Drawing.Size(244, 27);
            this.rdXemDSHD.TabIndex = 121;
            this.rdXemDSHD.TabStop = true;
            this.rdXemDSHD.Text = "Xem danh sách hóa đơn";
            this.rdXemDSHD.UseVisualStyleBackColor = true;
            this.rdXemDSHD.CheckedChanged += new System.EventHandler(this.rdXemDSHD_CheckedChanged);
            // 
            // rdXemDSNV
            // 
            this.rdXemDSNV.AutoSize = true;
            this.rdXemDSNV.Location = new System.Drawing.Point(29, 34);
            this.rdXemDSNV.Margin = new System.Windows.Forms.Padding(4);
            this.rdXemDSNV.Name = "rdXemDSNV";
            this.rdXemDSNV.Size = new System.Drawing.Size(253, 27);
            this.rdXemDSNV.TabIndex = 120;
            this.rdXemDSNV.TabStop = true;
            this.rdXemDSNV.Text = "Xem danh sách nhân viên";
            this.rdXemDSNV.UseVisualStyleBackColor = true;
            this.rdXemDSNV.CheckedChanged += new System.EventHandler(this.rdXemDSNV_CheckedChanged);
            // 
            // rdXemSLTK
            // 
            this.rdXemSLTK.AutoSize = true;
            this.rdXemSLTK.Location = new System.Drawing.Point(29, 138);
            this.rdXemSLTK.Margin = new System.Windows.Forms.Padding(4);
            this.rdXemSLTK.Name = "rdXemSLTK";
            this.rdXemSLTK.Size = new System.Drawing.Size(141, 27);
            this.rdXemSLTK.TabIndex = 119;
            this.rdXemSLTK.TabStop = true;
            this.rdXemSLTK.Text = "Xem tồn kho";
            this.rdXemSLTK.UseVisualStyleBackColor = true;
            this.rdXemSLTK.CheckedChanged += new System.EventHandler(this.rdXemSLTK_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = global::FormDangNhap.Properties.Resources.cancel;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThoat.Location = new System.Drawing.Point(452, 258);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(50, 50);
            this.btnThoat.TabIndex = 129;
            this.toolTip1.SetToolTip(this.btnThoat, "Nhấp vào đây để thoát");
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXemBaoCao.BackgroundImage = global::FormDangNhap.Properties.Resources.business_report;
            this.btnXemBaoCao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXemBaoCao.FlatAppearance.BorderSize = 0;
            this.btnXemBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemBaoCao.Location = new System.Drawing.Point(190, 255);
            this.btnXemBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(50, 50);
            this.btnXemBaoCao.TabIndex = 117;
            this.toolTip1.SetToolTip(this.btnXemBaoCao, "Nhấp vào đây để xem báo cáo");
            this.btnXemBaoCao.UseVisualStyleBackColor = false;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(735, 326);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.rdXemDSHDTheoNgay);
            this.Controls.Add(this.rdDoanhThu);
            this.Controls.Add(this.rdDSNVTheoNgay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgayB);
            this.Controls.Add(this.dtpNgayA);
            this.Controls.Add(this.rdXemDSHD);
            this.Controls.Add(this.rdXemDSNV);
            this.Controls.Add(this.rdXemSLTK);
            this.Controls.Add(this.btnXemBaoCao);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo";
            this.Load += new System.EventHandler(this.frmXemBaoCao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdXemDSHDTheoNgay;
        private System.Windows.Forms.RadioButton rdDoanhThu;
        private System.Windows.Forms.RadioButton rdDSNVTheoNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayB;
        private System.Windows.Forms.DateTimePicker dtpNgayA;
        private System.Windows.Forms.RadioButton rdXemDSHD;
        private System.Windows.Forms.RadioButton rdXemDSNV;
        private System.Windows.Forms.RadioButton rdXemSLTK;
        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}