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
    public partial class frmqlNCC : Form
    {
        private NhaCungCapBUS _NhaCungCapBUSS = new NhaCungCapBUS();
        public frmqlNCC()
        {
            InitializeComponent();
        }

        private void frmqlNCC_Load(object sender, EventArgs e)
        {
            dgvQlNCC.DataSource = _NhaCungCapBUSS.LayDSNCC();
        }

        

    

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == String.Empty)
            {
                MessageBox.Show(Constants.ERR_REQUIRED, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                return;
            }
            NhaCungCapDTO ncc = new NhaCungCapDTO()
            {
                MaNCC = txtMaNCC.Text
            };
            if (_NhaCungCapBUSS.XoaNCC(ncc))
            {
                MessageBox.Show(Constants.DELETE_SUCCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                dgvQlNCC.DataSource = _NhaCungCapBUSS.LayDSNCC();
                return;
            }
            else
            {
                MessageBox.Show(Constants.DELETE_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaNCC.ReadOnly = false;
            dgvQlNCC.DataSource = _NhaCungCapBUSS.LayDSNCC();
            txtTim.Text = "";
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == String.Empty || txtDiaChi.Text == String.Empty || txtSDT.Text == string.Empty || txtTenNCC.Text == String.Empty)
            {
                MessageBox.Show(Constants.ERR_REQUIRED, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                return;
            }
            NhaCungCapDTO ncc = new NhaCungCapDTO()
            {
                MaNCC = txtMaNCC.Text,
                TenNCC = txtTenNCC.Text,
                DiaChi = txtDiaChi.Text,
                SDT = txtSDT.Text
            };
            if (_NhaCungCapBUSS.SuaNCC(ncc))
            {
                MessageBox.Show(Constants.UPDATE_SUCCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                dgvQlNCC.DataSource = _NhaCungCapBUSS.LayDSNCC();
                return;
            }
            else
            {
                MessageBox.Show(Constants.UPDATE_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == String.Empty || txtDiaChi.Text == String.Empty || txtSDT.Text == string.Empty || txtTenNCC.Text == String.Empty)
            {
                MessageBox.Show(Constants.ERR_REQUIRED, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                return;
            }
            NhaCungCapDTO ncc = new NhaCungCapDTO()
            {
                MaNCC = txtMaNCC.Text,
                TenNCC = txtTenNCC.Text,
                DiaChi = txtDiaChi.Text,
                SDT = txtSDT.Text
            };
            if (_NhaCungCapBUSS.ThemNCC(ncc))
            {
                MessageBox.Show(Constants.ADD_SUCCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                dgvQlNCC.DataSource = _NhaCungCapBUSS.LayDSNCC();
                return;
            }
            else
            {
                MessageBox.Show(Constants.ADD_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvQlNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaNCC.ReadOnly = true;
                DataGridViewRow row = this.dgvQlNCC.Rows[e.RowIndex];
                txtMaNCC.Text = row.Cells[0].Value.ToString();
                txtTenNCC.Text = row.Cells[1].Value.ToString();
                txtDiaChi.Text = row.Cells[2].Value.ToString();
                txtSDT.Text = row.Cells[3].Value.ToString();
            }
            else
            {
                return;
            }
        }


        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            string text = txtTim.Text;
            if (text != "")
            {
                dgvQlNCC.DataSource = _NhaCungCapBUSS.TimNCC(text);
            }
            else
            {
                return;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show(Constants.NOTNUMBER, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
            }
        }

    }
}
