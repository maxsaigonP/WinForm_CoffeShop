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
    public partial class frmTTTaiKhoan : Form
    {
        private TaiKhoanBUS _taiKhoanBUS = new TaiKhoanBUS();
        public frmTTTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTTTaiKhoan_Load(object sender, EventArgs e)
        {
            lblTenTK.Text = Constants.TenTK;
            lblChucVu.Text = Constants.LoaiTK;
            txtMatKhauCu.Text = Constants.MatKhau;
            if (lblChucVu.Text == "Quản Lý")
            {
                string path = string.Format(@"{0}\..\..\images\{1}", Environment.CurrentDirectory,
                     "Admin.png");
                pbChucVu.Image = Image.FromFile(path);

            }
            else
            {
                string path = string.Format(@"{0}\..\..\images\{1}", Environment.CurrentDirectory,
                     "staff.png");
                pbChucVu.Image = Image.FromFile(path);
            }
            txtMatKhauCu.Enabled = false;
            txtMatKhauMoi.Enabled = false;
            txtNhapLai.Enabled = false;
            btnDoiMK.Enabled = false;
            string path2 = string.Format(@"{0}\..\..\images\{1}", Environment.CurrentDirectory,
                         "invisible.png");
            pbEye.Image = Image.FromFile(path2);
            txtNhapLai.UseSystemPasswordChar = true;
            string path3 = string.Format(@"{0}\..\..\images\{1}", Environment.CurrentDirectory,
                     "invisible.png");
            pbNhapLai.Image = Image.FromFile(path3);
            txtMatKhauCu.UseSystemPasswordChar = true;
            string path4 = string.Format(@"{0}\..\..\images\{1}", Environment.CurrentDirectory,
                     "invisible.png");
            pbMkCu.Image = Image.FromFile(path4);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbDoiMK.Checked == false)
            {
                txtMatKhauCu.Enabled = false;
                txtMatKhauMoi.Enabled = false;
                txtNhapLai.Enabled = false;
                btnDoiMK.Enabled = false;
            }
            else
            {
                txtMatKhauCu.Enabled = true;
                txtMatKhauMoi.Enabled = true;
                txtNhapLai.Enabled = true;
                btnDoiMK.Enabled = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if(txtMatKhauCu.Text == String.Empty || txtMatKhauMoi.Text == String.Empty || txtNhapLai.Text == String.Empty)
            {
                MessageBox.Show(Constants.ERR_REQUIRED, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                return;
            }
            if(txtMatKhauMoi.Text != txtNhapLai.Text)
            {
                MessageBox.Show(Constants.ERR_PASS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                return;
            }
            if(_taiKhoanBUS.DoiMK(lblTenTK.Text,txtMatKhauMoi.Text))
            {
                Constants.MatKhau = txtMatKhauMoi.Text;
                txtMatKhauCu.Text = txtMatKhauMoi.Text;
                txtMatKhauMoi.Text = "";
                txtNhapLai.Text = "";
                MessageBox.Show(Constants.CHANGE_PASS_SUCCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                return;
            }
            else
            {
                MessageBox.Show(Constants.CHANGE_PASS_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                return;
            }
        }

        private void pbEye_MouseHover(object sender, EventArgs e)
        {
            txtMatKhauMoi.UseSystemPasswordChar = false;
            string path2 = string.Format(@"{0}\..\..\images\{1}", Environment.CurrentDirectory,
                     "view.png");
            pbEye.Image = Image.FromFile(path2);
        }

        private void pbEye_MouseLeave(object sender, EventArgs e)
        {
            txtMatKhauMoi.UseSystemPasswordChar = true;
            string path2 = string.Format(@"{0}\..\..\images\{1}", Environment.CurrentDirectory,
                     "invisible.png");
            pbEye.Image = Image.FromFile(path2);
        }


        private void pbNhapLai_MouseHover(object sender, EventArgs e)
        {
            txtNhapLai.UseSystemPasswordChar = false;
            string path2 = string.Format(@"{0}\..\..\images\{1}", Environment.CurrentDirectory,
                     "view.png");
            pbNhapLai.Image = Image.FromFile(path2);
        }

        private void pbNhapLai_MouseLeave(object sender, EventArgs e)
        {
            txtNhapLai.UseSystemPasswordChar = true;
            string path2 = string.Format(@"{0}\..\..\images\{1}", Environment.CurrentDirectory,
                     "invisible.png");
            pbNhapLai.Image = Image.FromFile(path2);
        }

        private void pbMkCu_MouseHover(object sender, EventArgs e)
        {
            txtMatKhauCu.UseSystemPasswordChar = false;
            string path2 = string.Format(@"{0}\..\..\images\{1}", Environment.CurrentDirectory,
                     "view.png");
            pbMkCu.Image = Image.FromFile(path2);
        }

        private void pbMkCu_MouseLeave(object sender, EventArgs e)
        {
            txtMatKhauCu.UseSystemPasswordChar = true;
            string path2 = string.Format(@"{0}\..\..\images\{1}", Environment.CurrentDirectory,
                     "invisible.png");
            pbMkCu.Image = Image.FromFile(path2);
        }

    
      
    }
}
