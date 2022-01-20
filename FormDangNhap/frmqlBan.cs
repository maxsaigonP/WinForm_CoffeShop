using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDangNhap
{
    public partial class frmqlBan : Form
    {
      

        private BanBUS _BanBUS = new BanBUS();
        public frmqlBan()
        {
            InitializeComponent();
        }

        private void frmqlBan_Load(object sender, EventArgs e)
        {
            dgvQLBan.DataSource = _BanBUS.LayDSBan();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvQLBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaBan.ReadOnly = true;
                DataGridViewRow row = this.dgvQLBan.Rows[e.RowIndex];
                txtMaBan.Text = row.Cells[0].Value.ToString();
                nmSoGhe.Value = Convert.ToDecimal(row.Cells[1].Value.ToString());
            }
            else
            {
                return;
            }
        }

        private void btnThemBan_Click(object sender, EventArgs e)
        {
            if (nmSoGhe.Text == "0")
            {
                MessageBox.Show(Constants.ERR_REQUIRED, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                return;
            }
            BanDTO tk = new BanDTO()
            {
                SoGhe = Convert.ToInt32(nmSoGhe.Value)
            };
            if (_BanBUS.ThemBan(tk))
            {
                MessageBox.Show(Constants.ADD_SUCCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                dgvQLBan.DataSource = _BanBUS.LayDSBan();
                return;
            }
            else
            {
                MessageBox.Show(Constants.ADD_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaBan.Text == "")
            {
                MessageBox.Show(Constants.ERR_REQUIRED, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                return;
            }
            BanDTO ban = new BanDTO()
            {
                MaSoBan = Convert.ToInt32(txtMaBan.Text),
                SoGhe = Convert.ToInt32(nmSoGhe.Value.ToString())
            };
            if (_BanBUS.CapNhatBan(ban))
            {
                MessageBox.Show(Constants.UPDATE_SUCCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                dgvQLBan.DataSource = _BanBUS.LayDSBan();
                return;
            }
            else
            {
                MessageBox.Show(Constants.UPDATE_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaBan.Text == "")
            {
                MessageBox.Show(Constants.ERR_REQUIRED, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                return;
            }
            BanDTO ban = new BanDTO()
            {
                MaSoBan = Convert.ToInt32(txtMaBan.Text)
            };
            if (_BanBUS.XoaBan(ban))
            {
                MessageBox.Show(Constants.DELETE_SUCCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                dgvQLBan.DataSource = _BanBUS.LayDSBan();
                return;
            }
            else
            {
                MessageBox.Show(Constants.DELETE_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvQLBan.DataSource = _BanBUS.LayDSBan();
            txtMaBan.ReadOnly = false;
            txtTim.Text = "";
            txtMaBan.Text = "";
            nmSoGhe.Value = 0;
        }



        private void txtTim_TextChanged(object sender, EventArgs e)
        {
           
            try
            {
                int maSoBan = Convert.ToInt32(txtTim.Text);
                if (maSoBan > 0)
                {
                    dgvQLBan.DataSource = _BanBUS.TimBan(maSoBan);
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                return;
            }
        }

        private void txtTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show(Constants.NOTNUMBER, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
            }
        }

        
    }
}
