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
    public partial class frmqlHoaDon : Form
    {
        private HoaDonBUS _HoaDonBUS = new HoaDonBUS();
        public frmqlHoaDon()
        {
            InitializeComponent();
        }

        

        private void frmqlHoaDon_Load(object sender, EventArgs e)
        {
            dgvFrm_qlHoaDon.DataSource = _HoaDonBUS.LayDSHD();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == String.Empty)
            {
                MessageBox.Show(Constants.ERR_REQUIRED, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                return;
            }
            HoaDonDTO hd = new HoaDonDTO()
            {
                MaHD = Int32.Parse(txtMaHD.Text)
            };
            if (_HoaDonBUS.XoaHD(hd))
            {
                MessageBox.Show(Constants.DELETE_SUCCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                dgvFrm_qlHoaDon.DataSource = _HoaDonBUS.LayDSHD();
                return;
            }
            else
            {
                MessageBox.Show(Constants.DELETE_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaHD.ReadOnly = false;
            dgvFrm_qlHoaDon.DataSource = _HoaDonBUS.LayDSHD();
            txtMaHD.Text = "";
            txtMaSoBan.Text = "";
            txtMaNV.Text = "";
            dtpNgayLapHD.Value = DateTime.Now;
            txtTim.Text = "";
            dgvFrm_qlHoaDon.DataSource = _HoaDonBUS.LayDSHD();
        }

        private void dgvFrm_qlHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.ReadOnly = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvFrm_qlHoaDon.Rows[e.RowIndex];
                txtMaHD.Text = row.Cells[0].Value.ToString();
                txtMaSoBan.Text = row.Cells[1].Value.ToString();
                txtMaNV.Text = row.Cells[2].Value.ToString();
                dtpNgayLapHD.Value = Convert.ToDateTime(row.Cells[3].Value.ToString());
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

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int mahd = Int32.Parse(txtTim.Text);
                if (mahd != 0)
                {
                    dgvFrm_qlHoaDon.DataSource = _HoaDonBUS.TimHD(mahd);
                }
                else
                {
                    dgvFrm_qlHoaDon.DataSource = _HoaDonBUS.LayDSHD();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                return;
            } 
        }

        private void btnTimTheoNgay_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpNgayA.Checked == true)
                {
                    dgvFrm_qlHoaDon.DataSource = _HoaDonBUS.TimHDTheoNgay(Convert.ToDateTime(dtpNgayA.Value), Convert.ToDateTime(dtpNgayB.Value));
                }
                else
                {
                    dgvFrm_qlHoaDon.DataSource = _HoaDonBUS.LayDSHD();
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
