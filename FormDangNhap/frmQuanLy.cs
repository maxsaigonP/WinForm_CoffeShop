using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace FormDangNhap
{
    public partial class frmQuanLy : Form
    {
        private TaiKhoanBUS _TaiKhoanBUS = new TaiKhoanBUS();
        public frmQuanLy()
        {
            InitializeComponent();
     
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmqlNhanVien frmNhanVien = new frmqlNhanVien();
            frmNhanVien.MdiParent = this;
            frmNhanVien.Show();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmqlTaiKhoan frmTaiKhoan = new frmqlTaiKhoan();
            frmTaiKhoan.MdiParent = this;
            frmTaiKhoan.Show();
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            if(Constants.LoaiTK != "Quản Lý")
            {
                tsQuanLy.Enabled = false;
            }
            else
            {
                tsQuanLy.Enabled = true;
            }
            frmBanHang frmBH = new frmBanHang();
            frmBH.MdiParent = this;
            frmBH.Show();
        }

        private void bànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmqlBan frmBan = new frmqlBan();
            frmBan.MdiParent = this;
            frmBan.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmqlSanPham frmSP = new frmqlSanPham();
            frmSP.MdiParent = this;
            frmSP.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmqlNCC frmNCC = new frmqlNCC();
            frmNCC.MdiParent = this;
            frmNCC.Show();
        }

        private void nguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmqlNguyenLieu frmNL = new frmqlNguyenLieu();
            frmNL.MdiParent = this;
            frmNL.Show();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBanHang frmBH = new frmBanHang();
            frmBH.MdiParent = this;
            frmBH.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmqlHoaDon frmHD = new frmqlHoaDon();
            frmHD.MdiParent = this;
            frmHD.Show();
        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmqlCTHD frmCTHD = new frmqlCTHD();
            frmCTHD.MdiParent = this;
            frmCTHD.Show();
        }

        private void tsTTTaiKhoan_Click(object sender, EventArgs e)
        {
            frmTTTaiKhoan frmInFor = new frmTTTaiKhoan();
            frmInFor.MdiParent = this;
            frmInFor.Show();
        }

        private void tsDangXuat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chiTiếtSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCTSP frmCTSP = new frmCTSP();
            frmCTSP.MdiParent = this;
            frmCTSP.Show();
        }

        private void tsBaoCao_Click(object sender, EventArgs e)
        {
            frmBaoCao frmRP = new frmBaoCao();
            frmRP.MdiParent = this;
            frmRP.Show();
        }



      

    


       



        
     

    

      

      

       



        

      

      

      
    }
}
