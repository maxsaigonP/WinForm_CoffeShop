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
using BUS;
using DAO;
using DTO;

namespace FormDangNhap
{
    public partial class frmqlTaiKhoan : Form
    {
    

        private TaiKhoanBUS _TaiKhoanBUS = new TaiKhoanBUS();
        public frmqlTaiKhoan()
        {
            InitializeComponent();
     
        }

        private void frmqlTaiKhoan_Load(object sender, EventArgs e)
        {
            cbbTimTheo.DataSource = _TaiKhoanBUS.LayDSLoaiTK();
            cbbTimTheo.DisplayMember = "LoaiTK";
            cbbTimTheo.ValueMember = "LoaiTK";
            cbbTimTheo.SelectedValue = "";
            cbbLoaiTK.DataSource = _TaiKhoanBUS.LayDSLoaiTK();
            cbbLoaiTK.DisplayMember = "LoaiTK";
            cbbLoaiTK.ValueMember = "LoaiTK";
            cbbLoaiTK.SelectedValue = "Quản Lý";         
            dgvFrm_qlTaiKhoan.DataSource = _TaiKhoanBUS.LayDSTK();
            txtMatKhau.UseSystemPasswordChar = true;
            string path1 = string.Format(@"{0}\..\..\images\{1}", Environment.CurrentDirectory,
                     "invisible.png");
            pbNhapLai.Image = Image.FromFile(path1);
            txtMatKhau.UseSystemPasswordChar = true;
            string path2 = string.Format(@"{0}\..\..\images\{1}", Environment.CurrentDirectory,
                     "invisible.png");
            pbMK.Image = Image.FromFile(path2);
        }


        private void dgvFrm_qlTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtTenTaiKhoan.ReadOnly = true;
                DataGridViewRow row = this.dgvFrm_qlTaiKhoan.Rows[e.RowIndex];
                txtTenTaiKhoan.Text = row.Cells[0].Value.ToString();
                txtMatKhau.Text = row.Cells[1].Value.ToString();
                txtNhapLaiMK.Text = row.Cells[1].Value.ToString();
                txtMaNV.Text = row.Cells[2].Value.ToString();
                cbbLoaiTK.SelectedValue = row.Cells[3].Value.ToString();
            }
            else
            {
                return;
            }
        }

     

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTenTaiKhoan.ReadOnly = false;
            dgvFrm_qlTaiKhoan.DataSource = _TaiKhoanBUS.LayDSTK();
            txtTenTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtNhapLaiMK.Text = "";
            txtMaNV.Text = "";
            cbbLoaiTK.SelectedIndex = 2;
        }
       

     

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }   

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text != txtNhapLaiMK.Text)
            {
                MessageBox.Show(Constants.ERR_PASS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                return;
            }
            if (txtTenTaiKhoan.Text == String.Empty || txtMaNV.Text == String.Empty ||
                txtMatKhau.Text == String.Empty || txtNhapLaiMK.Text == String.Empty)
            {
                MessageBox.Show(Constants.ERR_REQUIRED, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                return;
            }
            TaiKhoanDTO tk = new TaiKhoanDTO()
            {
                TenTK = txtTenTaiKhoan.Text,
                MatKhau = Helper.MaHoaMD5(txtMatKhau.Text),
                MaNV = txtMaNV.Text,
                LoaiTK = cbbLoaiTK.SelectedValue.ToString()
            };
            if (_TaiKhoanBUS.CapNhatTK(tk))
            {
                MessageBox.Show(Constants.UPDATE_SUCCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                dgvFrm_qlTaiKhoan.DataSource = _TaiKhoanBUS.LayDSTK();
                return;
            }
            else
            {
                MessageBox.Show(Constants.UPDATE_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMatKhau.Text != txtNhapLaiMK.Text)
            {
                MessageBox.Show(Constants.ERR_PASS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                return;
            }
            if (txtTenTaiKhoan.Text == String.Empty || txtMaNV.Text == String.Empty || 
                txtMatKhau.Text == String.Empty || txtNhapLaiMK.Text == String.Empty
               )
            {
                MessageBox.Show(Constants.ERR_REQUIRED, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                return;
            }
            TaiKhoanDTO tk = new TaiKhoanDTO()
            {
                TenTK = txtTenTaiKhoan.Text,
                MatKhau = Helper.MaHoaMD5(txtMatKhau.Text),
                MaNV = txtMaNV.Text,
                LoaiTK = cbbLoaiTK.SelectedValue.ToString()

            };
            if (_TaiKhoanBUS.ThemTK(tk))
            {
                MessageBox.Show(Constants.ADD_SUCCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                dgvFrm_qlTaiKhoan.DataSource = _TaiKhoanBUS.LayDSTK();
                return;
            }
            else
            {
                MessageBox.Show(Constants.ADD_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTenTaiKhoan.Text == String.Empty)
            {
                MessageBox.Show(Constants.ERR_REQUIRED, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                return;
            }
            TaiKhoanDTO tk = new TaiKhoanDTO()
            {
                TenTK = txtTenTaiKhoan.Text
            };
            if (_TaiKhoanBUS.XoaTK(tk))
            {
                MessageBox.Show(Constants.DELETE_SUCCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                dgvFrm_qlTaiKhoan.DataSource = _TaiKhoanBUS.LayDSTK();
                return;
            }
            else
            {
                MessageBox.Show(Constants.DELETE_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
            }
        }


        private void cbbTimTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTimTheo.SelectedIndex == 0)
            {
                dgvFrm_qlTaiKhoan.DataSource = _TaiKhoanBUS.TimTK("Kế toán");
            }
            else if (cbbTimTheo.SelectedIndex == 1)
            {
                dgvFrm_qlTaiKhoan.DataSource = _TaiKhoanBUS.TimTK("Nhân viên");
            }
            else
            {
                dgvFrm_qlTaiKhoan.DataSource = _TaiKhoanBUS.TimTK("Quản lý");
            }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string text = txtTim.Text;
                if (text != "")
                {
                    dgvFrm_qlTaiKhoan.DataSource = _TaiKhoanBUS.TimTK(text);
                }
                else
                {
                    dgvFrm_qlTaiKhoan.DataSource = _TaiKhoanBUS.LayDSTK();
                }
            } catch (Exception ex)
            {
                ex.Message.ToString();
                return;
            }
        }

        private void pbMK_MouseHover(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = false;
            string path2 = string.Format(@"{0}\..\..\images\{1}", Environment.CurrentDirectory,
                     "view.png");
            pbMK.Image = Image.FromFile(path2);
        }

        private void pbMK_MouseLeave(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
            string path2 = string.Format(@"{0}\..\..\images\{1}", Environment.CurrentDirectory,
                     "invisible.png");
            pbMK.Image = Image.FromFile(path2);
        }

        private void pbNhapLai_MouseHover(object sender, EventArgs e)
        {
            txtNhapLaiMK.UseSystemPasswordChar = false;
            string path2 = string.Format(@"{0}\..\..\images\{1}", Environment.CurrentDirectory,
                     "view.png");
            pbNhapLai.Image = Image.FromFile(path2);
        }

        private void pbNhapLai_MouseLeave(object sender, EventArgs e)
        {
            txtNhapLaiMK.UseSystemPasswordChar = true;
            string path2 = string.Format(@"{0}\..\..\images\{1}", Environment.CurrentDirectory,
                     "invisible.png");
            pbNhapLai.Image = Image.FromFile(path2);
        }





    }
}
