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
using DAO;
using DTO;

namespace FormDangNhap
{
    public partial class frmCTSP : Form
    {
        private CT_SanPhamBUS ctspBUS = new CT_SanPhamBUS();
        private SanPhamBUS spBUS = new SanPhamBUS();
        private NguyenLieuBUS nlBUS = new NguyenLieuBUS();
        public frmCTSP()
        {
            InitializeComponent();
        }

        private void frmCTSP_Load(object sender, EventArgs e)
        {
            dgvCTSP.DataSource = ctspBUS.layDsCtSP();
            cbbMaSP.DataSource = spBUS.LayDSSP();
            cbbMaSP.DisplayMember = "TenSP";
            cbbMaSP.ValueMember = "MaSp";
            cbbMaNL.DataSource = nlBUS.LayDSNL();
            cbbMaNL.DisplayMember = "TenNL";
            cbbMaNL.ValueMember = "MaNL";
        }

        private void btnThemCTSP_Click(object sender, EventArgs e)
        {

            CT_SanPhamDTO ctsp = new CT_SanPhamDTO()
            {
                MaSP = cbbMaSP.SelectedValue.ToString(),
                MaNL = cbbMaNL.SelectedValue.ToString()
            };
            if (ctspBUS.ThemCTSP(ctsp))
            {
                MessageBox.Show(Constants.ADD_SUCCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                dgvCTSP.DataSource = ctspBUS.layDsCtSP();
                return;
            }
            else
            {
                MessageBox.Show(Constants.ADD_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvCTSP.DataSource = ctspBUS.layDsCtSP();
            txtTim.Text = "";
            cbbMaSP.SelectedIndex = 0;
            cbbMaNL.SelectedIndex = 0;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            CT_SanPhamDTO ctsp = new CT_SanPhamDTO()
            {
                MaSP = cbbMaSP.SelectedValue.ToString()

            };
            if (ctspBUS.XoaCTSP(ctsp))
            {
                MessageBox.Show(Constants.DELETE_SUCCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                dgvCTSP.DataSource = ctspBUS.layDsCtSP();
                return;
            }
            else
            {
                MessageBox.Show(Constants.DELETE_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
            }
        }

        private void dgvCTSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rows = this.dgvCTSP.Rows[e.RowIndex];

                cbbMaSP.SelectedValue = rows.Cells[0].Value.ToString();
                cbbMaNL.SelectedValue = rows.Cells[1].Value.ToString();
            }
            else
            {
                return;
            }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            if(txtTim.Text != "0")
            {
                dgvCTSP.DataSource = ctspBUS.TimCTSP(txtTim.Text);
            }
            else
            {
                return;
            }
        }
    }
}
