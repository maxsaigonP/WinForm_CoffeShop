using BUS;
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

namespace FormDangNhap
{
    public partial class frmqlCTHD : Form
    {
        private CTHoaDonBUS _CTHoaDonBUS = new CTHoaDonBUS();
        public frmqlCTHD()
        {
            InitializeComponent();
        }

        private void frm_qlCTHD_Load(object sender, EventArgs e)
        {
            dgvFrm_qlCTHoaDon.DataSource = _CTHoaDonBUS.LayDSCTHD();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaHD.ReadOnly = false;
            dgvFrm_qlCTHoaDon.DataSource = _CTHoaDonBUS.LayDSCTHD();
            txtMaHD.Text = "";
            txtMaSP.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            txtTim.Text = "";
        }

     

        private void dgvFrm_qlCTHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvFrm_qlCTHoaDon.Rows[e.RowIndex];
                txtMaHD.Text = row.Cells[0].Value.ToString();
                txtMaSP.Text = row.Cells[1].Value.ToString();
                txtSoLuong.Text = row.Cells[2].Value.ToString();
                txtDonGia.Text = row.Cells[3].Value.ToString();

            }
            else
            {
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == String.Empty)
            {
                MessageBox.Show(Constants.ERR_REQUIRED, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                return;
            }
            CTHoaDonDTO hd = new CTHoaDonDTO()
            {
                MaHD = Int32.Parse(txtMaHD.Text),
                MaSP = txtMaSP.Text
            };
            if (_CTHoaDonBUS.XoaCTHD(hd))
            {
                MessageBox.Show(Constants.DELETE_SUCCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                dgvFrm_qlCTHoaDon.DataSource = _CTHoaDonBUS.LayDSCTHD();
                return;
            }
            else
            {
                MessageBox.Show(Constants.DELETE_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
            }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int mahd = Int32.Parse(txtTim.Text);
                if (mahd != 0)
                {
                    dgvFrm_qlCTHoaDon.DataSource = _CTHoaDonBUS.TimCTHD(mahd);
                }
                else
                {
                    dgvFrm_qlCTHoaDon.DataSource = _CTHoaDonBUS.TimCTHD(mahd);
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                return;
            }
        }
    }
}
