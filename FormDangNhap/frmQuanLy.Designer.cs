namespace FormDangNhap
{
    partial class frmQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLy));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nguyênLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTTTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsQuanLy,
            this.tsBanHang,
            this.tsBaoCao,
            this.tsTTTaiKhoan,
            this.tsDangXuat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1237, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsQuanLy
            // 
            this.tsQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem,
            this.bànToolStripMenuItem,
            this.nguyênLiệuToolStripMenuItem,
            this.sảnPhẩmToolStripMenuItem,
            this.nhàCungCấpToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem,
            this.chiTiếtHóaĐơnToolStripMenuItem,
            this.chiTiếtSảnPhẩmToolStripMenuItem});
            this.tsQuanLy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsQuanLy.Image = global::FormDangNhap.Properties.Resources.settings;
            this.tsQuanLy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsQuanLy.Name = "tsQuanLy";
            this.tsQuanLy.Size = new System.Drawing.Size(130, 28);
            this.tsQuanLy.Text = "QUẢN LÝ";
            this.tsQuanLy.ToolTipText = "Danh mục quản lý";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(281, 28);
            this.nhânViênToolStripMenuItem.Text = "Nhân Viên";
            this.nhânViênToolStripMenuItem.ToolTipText = "Quản lý nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(281, 28);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            this.tàiKhoảnToolStripMenuItem.ToolTipText = "Quản lý tài khoản";
            this.tàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem_Click);
            // 
            // bànToolStripMenuItem
            // 
            this.bànToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bànToolStripMenuItem.Name = "bànToolStripMenuItem";
            this.bànToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.bànToolStripMenuItem.Size = new System.Drawing.Size(281, 28);
            this.bànToolStripMenuItem.Text = "Bàn";
            this.bànToolStripMenuItem.ToolTipText = "Quản lý bàn";
            this.bànToolStripMenuItem.Click += new System.EventHandler(this.bànToolStripMenuItem_Click);
            // 
            // nguyênLiệuToolStripMenuItem
            // 
            this.nguyênLiệuToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nguyênLiệuToolStripMenuItem.Name = "nguyênLiệuToolStripMenuItem";
            this.nguyênLiệuToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.nguyênLiệuToolStripMenuItem.Size = new System.Drawing.Size(281, 28);
            this.nguyênLiệuToolStripMenuItem.Text = "Nguyên Liệu";
            this.nguyênLiệuToolStripMenuItem.ToolTipText = "Quản lý nguyên liệu";
            this.nguyênLiệuToolStripMenuItem.Click += new System.EventHandler(this.nguyênLiệuToolStripMenuItem_Click);
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(281, 28);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản Phẩm";
            this.sảnPhẩmToolStripMenuItem.ToolTipText = "Quản lý sản phẩm";
            this.sảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.sảnPhẩmToolStripMenuItem_Click);
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            this.nhàCungCấpToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            this.nhàCungCấpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.nhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(281, 28);
            this.nhàCungCấpToolStripMenuItem.Text = "Nhà Cung Cấp";
            this.nhàCungCấpToolStripMenuItem.ToolTipText = "Quản lý nhà cung cấp";
            this.nhàCungCấpToolStripMenuItem.Click += new System.EventHandler(this.nhàCungCấpToolStripMenuItem_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(281, 28);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            this.hóaĐơnToolStripMenuItem.ToolTipText = "Quản lý hóa đơn";
            this.hóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click);
            // 
            // chiTiếtHóaĐơnToolStripMenuItem
            // 
            this.chiTiếtHóaĐơnToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiTiếtHóaĐơnToolStripMenuItem.Name = "chiTiếtHóaĐơnToolStripMenuItem";
            this.chiTiếtHóaĐơnToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.chiTiếtHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(281, 28);
            this.chiTiếtHóaĐơnToolStripMenuItem.Text = "Chi Tiết Hóa Đơn";
            this.chiTiếtHóaĐơnToolStripMenuItem.ToolTipText = "Quản lý chi tiết hóa đơn";
            this.chiTiếtHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtHóaĐơnToolStripMenuItem_Click);
            // 
            // chiTiếtSảnPhẩmToolStripMenuItem
            // 
            this.chiTiếtSảnPhẩmToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiTiếtSảnPhẩmToolStripMenuItem.Name = "chiTiếtSảnPhẩmToolStripMenuItem";
            this.chiTiếtSảnPhẩmToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.chiTiếtSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(281, 28);
            this.chiTiếtSảnPhẩmToolStripMenuItem.Text = "Chi Tiết Sản Phẩm";
            this.chiTiếtSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtSảnPhẩmToolStripMenuItem_Click);
            // 
            // tsBanHang
            // 
            this.tsBanHang.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBanHang.Image = global::FormDangNhap.Properties.Resources.coffee;
            this.tsBanHang.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tsBanHang.Name = "tsBanHang";
            this.tsBanHang.Size = new System.Drawing.Size(148, 28);
            this.tsBanHang.Text = "BÁN HÀNG";
            this.tsBanHang.Click += new System.EventHandler(this.bánHàngToolStripMenuItem_Click);
            // 
            // tsBaoCao
            // 
            this.tsBaoCao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBaoCao.Image = global::FormDangNhap.Properties.Resources.business_report;
            this.tsBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsBaoCao.Name = "tsBaoCao";
            this.tsBaoCao.Size = new System.Drawing.Size(136, 28);
            this.tsBaoCao.Text = "BÁO CÁO";
            this.tsBaoCao.Click += new System.EventHandler(this.tsBaoCao_Click);
            // 
            // tsTTTaiKhoan
            // 
            this.tsTTTaiKhoan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsTTTaiKhoan.Image = global::FormDangNhap.Properties.Resources.background;
            this.tsTTTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsTTTaiKhoan.Name = "tsTTTaiKhoan";
            this.tsTTTaiKhoan.Size = new System.Drawing.Size(268, 28);
            this.tsTTTaiKhoan.Text = "THÔNG TIN TÀI KHOẢN";
            this.tsTTTaiKhoan.ToolTipText = "Xem thông tin tài khoản";
            this.tsTTTaiKhoan.Click += new System.EventHandler(this.tsTTTaiKhoan_Click);
            // 
            // tsDangXuat
            // 
            this.tsDangXuat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsDangXuat.Image = global::FormDangNhap.Properties.Resources.log_out;
            this.tsDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsDangXuat.Name = "tsDangXuat";
            this.tsDangXuat.Size = new System.Drawing.Size(158, 28);
            this.tsDangXuat.Text = "ĐĂNG XUẤT";
            this.tsDangXuat.Click += new System.EventHandler(this.tsDangXuat_Click);
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1237, 653);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý P2T Coffee Shop";
            this.Load += new System.EventHandler(this.frmQuanLy_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsQuanLy;
        private System.Windows.Forms.ToolStripMenuItem tsBanHang;
        private System.Windows.Forms.ToolStripMenuItem tsBaoCao;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nguyênLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsTTTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem tsDangXuat;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtSảnPhẩmToolStripMenuItem;
    }
}