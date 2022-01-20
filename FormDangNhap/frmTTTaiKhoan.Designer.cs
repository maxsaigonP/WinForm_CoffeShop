namespace FormDangNhap
{
    partial class frmTTTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTTTaiKhoan));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNhapLai = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbNhapLai = new System.Windows.Forms.PictureBox();
            this.pbEye = new System.Windows.Forms.PictureBox();
            this.txtNhapLai = new System.Windows.Forms.TextBox();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.lblTenTK = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pbChucVu = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ckbDoiMK = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbMkCu = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNhapLai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChucVu)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMkCu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin chào:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chức vụ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu cũ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu mới:";
            // 
            // lblNhapLai
            // 
            this.lblNhapLai.AutoSize = true;
            this.lblNhapLai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapLai.Location = new System.Drawing.Point(25, 144);
            this.lblNhapLai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhapLai.Name = "lblNhapLai";
            this.lblNhapLai.Size = new System.Drawing.Size(211, 23);
            this.lblNhapLai.TabIndex = 4;
            this.lblNhapLai.Text = "Nhập lại mật khẩu mới:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbMkCu);
            this.groupBox1.Controls.Add(this.pbNhapLai);
            this.groupBox1.Controls.Add(this.pbEye);
            this.groupBox1.Controls.Add(this.txtNhapLai);
            this.groupBox1.Controls.Add(this.txtMatKhauMoi);
            this.groupBox1.Controls.Add(this.txtMatKhauCu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblNhapLai);
            this.groupBox1.Location = new System.Drawing.Point(12, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 182);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đổi mật khẩu:";
            // 
            // pbNhapLai
            // 
            this.pbNhapLai.BackColor = System.Drawing.Color.White;
            this.pbNhapLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbNhapLai.Location = new System.Drawing.Point(462, 149);
            this.pbNhapLai.Name = "pbNhapLai";
            this.pbNhapLai.Size = new System.Drawing.Size(15, 15);
            this.pbNhapLai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNhapLai.TabIndex = 114;
            this.pbNhapLai.TabStop = false;
            this.pbNhapLai.MouseLeave += new System.EventHandler(this.pbNhapLai_MouseLeave);
            this.pbNhapLai.MouseHover += new System.EventHandler(this.pbNhapLai_MouseHover);
            // 
            // pbEye
            // 
            this.pbEye.BackColor = System.Drawing.Color.White;
            this.pbEye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEye.Location = new System.Drawing.Point(462, 100);
            this.pbEye.Name = "pbEye";
            this.pbEye.Size = new System.Drawing.Size(15, 15);
            this.pbEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEye.TabIndex = 113;
            this.pbEye.TabStop = false;
            this.pbEye.MouseLeave += new System.EventHandler(this.pbEye_MouseLeave);
            this.pbEye.MouseHover += new System.EventHandler(this.pbEye_MouseHover);
            // 
            // txtNhapLai
            // 
            this.txtNhapLai.Location = new System.Drawing.Point(243, 141);
            this.txtNhapLai.Name = "txtNhapLai";
            this.txtNhapLai.Size = new System.Drawing.Size(245, 30);
            this.txtNhapLai.TabIndex = 3;
            this.txtNhapLai.UseSystemPasswordChar = true;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(243, 93);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(245, 30);
            this.txtMatKhauMoi.TabIndex = 2;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Location = new System.Drawing.Point(243, 45);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.ReadOnly = true;
            this.txtMatKhauCu.Size = new System.Drawing.Size(245, 30);
            this.txtMatKhauCu.TabIndex = 1;
            // 
            // lblTenTK
            // 
            this.lblTenTK.AutoSize = true;
            this.lblTenTK.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTK.ForeColor = System.Drawing.Color.Black;
            this.lblTenTK.Location = new System.Drawing.Point(205, 33);
            this.lblTenTK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenTK.Name = "lblTenTK";
            this.lblTenTK.Size = new System.Drawing.Size(94, 24);
            this.lblTenTK.TabIndex = 7;
            this.lblTenTK.Text = "lblTenTK";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.ForeColor = System.Drawing.Color.Red;
            this.lblChucVu.Location = new System.Drawing.Point(205, 71);
            this.lblChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(105, 24);
            this.lblChucVu.TabIndex = 8;
            this.lblChucVu.Text = "lblChucVu";
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.BackgroundImage = global::FormDangNhap.Properties.Resources.refresh;
            this.btnDoiMK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoiMK.FlatAppearance.BorderSize = 0;
            this.btnDoiMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDoiMK.Location = new System.Drawing.Point(160, 467);
            this.btnDoiMK.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(40, 40);
            this.btnDoiMK.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnDoiMK, "Nhấp vào đây để đổi mật khẩu");
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = global::FormDangNhap.Properties.Resources.cancel;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThoat.Location = new System.Drawing.Point(323, 467);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(40, 40);
            this.btnThoat.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnThoat, "Nhấp vào đây để thoát");
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pbChucVu
            // 
            this.pbChucVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbChucVu.Location = new System.Drawing.Point(202, 12);
            this.pbChucVu.Name = "pbChucVu";
            this.pbChucVu.Size = new System.Drawing.Size(120, 120);
            this.pbChucVu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChucVu.TabIndex = 5;
            this.pbChucVu.TabStop = false;
            // 
            // ckbDoiMK
            // 
            this.ckbDoiMK.AutoSize = true;
            this.ckbDoiMK.Location = new System.Drawing.Point(195, 257);
            this.ckbDoiMK.Name = "ckbDoiMK";
            this.ckbDoiMK.Size = new System.Drawing.Size(147, 27);
            this.ckbDoiMK.TabIndex = 0;
            this.ckbDoiMK.Text = "Đổi mật khẩu";
            this.ckbDoiMK.UseVisualStyleBackColor = true;
            this.ckbDoiMK.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblChucVu);
            this.groupBox2.Controls.Add(this.lblTenTK);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 107);
            this.groupBox2.TabIndex = 112;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tài khoản:";
            // 
            // pbMkCu
            // 
            this.pbMkCu.BackColor = System.Drawing.Color.Transparent;
            this.pbMkCu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMkCu.Location = new System.Drawing.Point(462, 53);
            this.pbMkCu.Name = "pbMkCu";
            this.pbMkCu.Size = new System.Drawing.Size(15, 15);
            this.pbMkCu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMkCu.TabIndex = 115;
            this.pbMkCu.TabStop = false;
            this.pbMkCu.MouseLeave += new System.EventHandler(this.pbMkCu_MouseLeave);
            this.pbMkCu.MouseHover += new System.EventHandler(this.pbMkCu_MouseHover);
            // 
            // frmTTTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 518);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ckbDoiMK);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbChucVu);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTTTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin tài khoản";
            this.Load += new System.EventHandler(this.frmTTTaiKhoan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNhapLai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChucVu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMkCu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNhapLai;
        private System.Windows.Forms.PictureBox pbChucVu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNhapLai;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.Label lblTenTK;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox ckbDoiMK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbEye;
        private System.Windows.Forms.PictureBox pbNhapLai;
        private System.Windows.Forms.PictureBox pbMkCu;
    }
}