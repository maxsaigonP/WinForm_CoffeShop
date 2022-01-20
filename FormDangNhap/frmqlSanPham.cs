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
using DAO;
using System.Drawing.Imaging;

namespace FormDangNhap
{
    public partial class frmqlSanPham : Form
    {
        private SanPhamBUS _SanPhamBUS = new SanPhamBUS();
        public frmqlSanPham()
        {
            InitializeComponent();
        }

        private void frmqlSanPham_Load(object sender, EventArgs e)
        {
            dgv_frmQLSP.DataSource = _SanPhamBUS.LayDSSP();
        }

        private void dgv_frmQLSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSP.ReadOnly = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_frmQLSP.Rows[e.RowIndex];
                txtMaSP.Text = row.Cells[0].Value.ToString();
                txtTenSP.Text = row.Cells[1].Value.ToString();
                txtDG.Text = row.Cells[2].Value.ToString();
                string path = string.Format(@"{0}\..\..\images\{1}", Environment.CurrentDirectory,
                    row.Cells[3].Value.ToString());
                pbSP.Image = Image.FromFile(path);
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


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == String.Empty || txtTenSP.Text == String.Empty || txtDG.Text == String.Empty)
            {
                MessageBox.Show(Constants.ERR_REQUIRED, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                return;
            }         
            SanPhamDTO sp = new SanPhamDTO();
            sp.MaSP = txtMaSP.Text;
            sp.TenSp = txtTenSP.Text;
            sp.DonGia = Convert.ToDecimal(txtDG.Text);
            sp.HinhAnh = string.Format("{0}.jpg",txtMaSP.Text);
             SaveImage(pbSP.Image);
            if (_SanPhamBUS.ThemSP(sp))
            {
                MessageBox.Show(Constants.ADD_SUCCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                dgv_frmQLSP.DataSource = _SanPhamBUS.LayDSSP();
                return;
            }
            else
            {
                MessageBox.Show(Constants.ADD_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
            }
        }
        private void SaveImage(Image img)
        {
            Bitmap bmp = new Bitmap(img);
            string path = string.Format(@"{0}\..\..\images\{1}.jpg", Environment.CurrentDirectory,
                txtMaSP.Text);
            bmp.Save(path, ImageFormat.Jpeg);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == String.Empty || txtTenSP.Text == String.Empty || txtDG.Text == String.Empty)
            {
                MessageBox.Show(Constants.ERR_REQUIRED, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                return;
            }
            SanPhamDTO sp = new SanPhamDTO();
                sp.MaSP = txtMaSP.Text;
                sp.TenSp = txtTenSP.Text;
                sp.DonGia = Convert.ToDecimal(txtDG.Text);
                sp.HinhAnh = string.Format("{0}.jpg",txtMaSP.Text);
             SaveImage(pbSP.Image);
            
            if (_SanPhamBUS.SuaSP(sp))
            {
                MessageBox.Show(Constants.UPDATE_SUCCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                dgv_frmQLSP.DataSource = _SanPhamBUS.LayDSSP();
                return;
            }
            else
            {
                MessageBox.Show(Constants.UPDATE_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtMaSP.Text == String.Empty)
            {
                MessageBox.Show(Constants.ERR_REQUIRED, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                return;
            }
            SanPhamDTO sp = new SanPhamDTO
            {
                MaSP = txtMaSP.Text
            };
            if (_SanPhamBUS.XoaSP(sp))
            {
                MessageBox.Show(Constants.DELETE_SUCCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                dgv_frmQLSP.DataSource = _SanPhamBUS.LayDSSP();
                return;
            }
            else
            {
                MessageBox.Show(Constants.DELETE_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            string path = string.Format(@"{0}\..\..\images\{1}", Environment.CurrentDirectory,
                 "add.png");
            pbSP.Image = Image.FromFile(path);

            dgv_frmQLSP.DataSource = _SanPhamBUS.LayDSSP();
            txtMaSP.ReadOnly = false;
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtDG.Text = "";
            txtTim.Text = "";
        }

        private void pbSP_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog browse = new OpenFileDialog();
            if (browse.ShowDialog() == DialogResult.OK)
            {
                pbSP.Image = Image.FromFile(browse.FileName);
            }
        }



        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            try
            {
                    string text = txtTim.Text;
                    if (text != "")
                    {
                        dgv_frmQLSP.DataSource = _SanPhamBUS.TimSP(text);
                    }
                    else
                    {
                        return;
                    }
                
            } catch (Exception ex)
            {
                ex.Message.ToString();
                MessageBox.Show("Lỗi","Thông Báo",MessageBoxButtons.OK);
            }
        }
        private void txtDG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show(Constants.NOTNUMBER, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
            }
        }

    
    }
}
