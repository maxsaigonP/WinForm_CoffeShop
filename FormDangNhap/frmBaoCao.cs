using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDangNhap
{
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void frmXemBaoCao_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            DateTime ngayHienTai = DateTime.Now;
            DateTime ngayA = dtpNgayA.Value;
            DateTime ngayB = dtpNgayB.Value;

            if (rdXemDSNV.Checked == true)
            {
                frmXemBaoCao frmBC = new frmXemBaoCao();
                frmBC.XemDSNV();
                frmBC.ShowDialog();
            }


            if (rdDSNVTheoNgay.Checked == true)
            {
                frmXemBaoCao frmBC = new frmXemBaoCao();
                frmBC.XemDSNVTheoNgayVaoLam(ngayA.AddDays(-1), ngayB);
                frmBC.ShowDialog();
            }

            if (rdXemDSHD.Checked == true)
            {
                frmXemBaoCao frmBC = new frmXemBaoCao();
                frmBC.XemDSHD();
                frmBC.ShowDialog();
            }


            if (rdXemDSHDTheoNgay.Checked == true)
            {
                frmXemBaoCao frmBC = new frmXemBaoCao();
                frmBC.XemDSHDTheoNgayLapHD(ngayA.AddDays(-1), ngayB);
                frmBC.ShowDialog();
            }
            if (rdXemSLTK.Checked == true)
            {
                frmXemBaoCao frmBC = new frmXemBaoCao();
                frmBC.XemDSNL();
                frmBC.ShowDialog();
            }

            if (rdDoanhThu.Checked == true)
            {
                frmXemBaoCao frmBC = new frmXemBaoCao();
                frmBC.XemDoanhThu(ngayA.AddDays(-1), ngayB);
                frmBC.ShowDialog();
            }
        }

        private void rdXemDSNV_CheckedChanged(object sender, EventArgs e)
        {
            if (rdXemDSNV.Checked == true)
            {
                dtpNgayA.Enabled = false;
                dtpNgayB.Enabled = false;
            }
        }

        private void rdXemDSHDTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDSNVTheoNgay.Checked == true)
            {
                dtpNgayA.Enabled = true;
                dtpNgayB.Enabled = true;
            }
        }

        private void rdDoanhThu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDoanhThu.Checked == true)
            {
                dtpNgayA.Enabled = true;
                dtpNgayB.Enabled = true;
            }
        }

        private void rdXemDSHD_CheckedChanged(object sender, EventArgs e)
        {
            if (rdXemDSHD.Checked == true)
            {
                dtpNgayA.Enabled = false;
                dtpNgayB.Enabled = false;
            }
        }

        private void rdXemSLTK_CheckedChanged(object sender, EventArgs e)
        {
            if (rdXemSLTK.Checked == true)
            {
                dtpNgayA.Enabled = false;
                dtpNgayB.Enabled = false;
            }
        }

        private void rdDSNVTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDSNVTheoNgay.Checked == true)
            {
                dtpNgayA.Enabled = true;
                dtpNgayB.Enabled = true;
            }
        }
    }
}
