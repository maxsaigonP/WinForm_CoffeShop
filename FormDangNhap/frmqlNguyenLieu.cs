using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace FormDangNhap
{
    public partial class frmqlNguyenLieu : Form
    {
        private NguyenLieuBUS _NguyenLieuBUS = new NguyenLieuBUS();
        public frmqlNguyenLieu()
        {
            InitializeComponent();
        }

    

        private void frmqlNguyenLieu_Load(object sender, EventArgs e)
        {
            dgvFrm_qlNguyenLieu.DataSource = _NguyenLieuBUS.LayDSNL();
        }

        private void dgvFrm_qlNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaNL.ReadOnly = true;
                DataGridViewRow rows = this.dgvFrm_qlNguyenLieu.Rows[e.RowIndex];
                txtMaNL.Text = rows.Cells[0].Value.ToString();
                txtTenNL.Text = rows.Cells[1].Value.ToString();
                txtMaNCC.Text = rows.Cells[2].Value.ToString();
                txtDonViTinh.Text = rows.Cells[3].Value.ToString();
                txtDonGia.Text = rows.Cells[4].Value.ToString();
                txtSLTon.Text = rows.Cells[5].Value.ToString();
            } else
            {
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvFrm_qlNguyenLieu.DataSource = _NguyenLieuBUS.LayDSNL();
            txtMaNL.ReadOnly = false;
            txtTenNL.Text = "";
            txtMaNL.Text = "";
            txtMaNCC.Text = "";
            txtTim.Text = "";
            txtDonGia.Text = "";
            txtDonViTinh.Text = "";
            txtSLTon.Text = "";

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtTenNL.Text == String.Empty)
            {
                MessageBox.Show(Constants.ERR_REQUIRED, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                return;
            }
            NguyenLieuDTO nl = new NguyenLieuDTO()
            {
                MaNL = txtMaNL.Text,

            };
            if (_NguyenLieuBUS.XoaNL(nl))
            {
                MessageBox.Show(Constants.DELETE_SUCCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                dgvFrm_qlNguyenLieu.DataSource = _NguyenLieuBUS.LayDSNL();
                return;
            }
            else
            {
                MessageBox.Show(Constants.DELETE_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenNL.Text == String.Empty || txtMaNCC.Text == String.Empty || txtMaNL.Text == String.Empty || txtDonViTinh.Text == String.Empty 
                || txtDonGia.Text == String.Empty || txtSLTon.Text == String.Empty || txtSLTon.Text == "0")
            {
                MessageBox.Show(Constants.ERR_REQUIRED, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                return;
            }
            NguyenLieuDTO nl = new NguyenLieuDTO()
            {

                MaNL = txtMaNL.Text,
                TenNL = txtTenNL.Text,
                MaNCC = txtMaNCC.Text,
                DonViTinh = txtDonViTinh.Text,
                DonGia = Convert.ToDecimal(txtDonGia.Text),
                SLTonKho = int.Parse(txtSLTon.Text)
            };
            if (_NguyenLieuBUS.ThemNL(nl))
            {
                MessageBox.Show(Constants.ADD_SUCCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                dgvFrm_qlNguyenLieu.DataSource = _NguyenLieuBUS.LayDSNL();
                return;
            }
            else
            {
                MessageBox.Show(Constants.ADD_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenNL.Text == String.Empty || txtMaNCC.Text == String.Empty || txtMaNL.Text == String.Empty || txtDonViTinh.Text == String.Empty || txtDonGia.Text == String.Empty || txtDonGia.Text == String.Empty)
            {
                MessageBox.Show(Constants.ERR_REQUIRED, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                return;
            }
            NguyenLieuDTO nl = new NguyenLieuDTO()
            {
                MaNL = txtMaNL.Text,
                TenNL = txtTenNL.Text,
                MaNCC = txtMaNCC.Text,
                DonViTinh = txtDonViTinh.Text,
                DonGia = Convert.ToDecimal(txtDonGia.Text),
                SLTonKho = int.Parse(txtSLTon.Text)
            };
            if (_NguyenLieuBUS.SuaNL(nl))
            {
                MessageBox.Show(Constants.UPDATE_SUCCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                dgvFrm_qlNguyenLieu.DataSource = _NguyenLieuBUS.LayDSNL();
                return;
            }
            else
            {
                MessageBox.Show(Constants.UPDATE_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
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
                string MaNL = txtTim.Text;
                if (MaNL != "")
                {
                    dgvFrm_qlNguyenLieu.DataSource = _NguyenLieuBUS.TimNL(MaNL);
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return;
            }
        }


        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show(Constants.NOTNUMBER, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
            }

        }

        private void txtSLTon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show(Constants.NOTNUMBER, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
            }

        }

    }
}
