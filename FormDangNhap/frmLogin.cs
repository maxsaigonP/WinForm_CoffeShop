using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;
using System.Threading;

namespace FormDangNhap
{
    public partial class frmLogin : Form
    {

        private TaiKhoanBUS _TaiKhoanBUS = new TaiKhoanBUS();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(Constants.EXIT, Constants.MESSAGE_TITLE, MessageBoxButtons.OKCancel, MessageBoxIcon.Error) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmQuanLy f = new frmQuanLy();
            //Kiểm tra nhập hay chưa
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show(Constants.ERR_REQUIRED, Constants.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            TaiKhoanDTO tk = new TaiKhoanDTO()
            {
                TenTK = txtTaiKhoan.Text,
                MatKhau = Helper.MaHoaMD5(txtMatKhau.Text)
            };
            if (_TaiKhoanBUS.KiemTraTK(tk))
            {
                Constants.TenTK = txtTaiKhoan.Text;
                Constants.MatKhau = txtMatKhau.Text;
                Constants.LoaiTK = _TaiKhoanBUS.PhanQuyen(tk.TenTK)[0].LoaiTK;
                MessageBox.Show(Constants.LOGIN_SUCCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                f.ShowDialog();
                this.Hide();
                this.Show();
            }
            else
            {
                MessageBox.Show(Constants.LOGIN_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
            string path2 = string.Format(@"{0}\..\..\images\{1}", Environment.CurrentDirectory,
                     "invisible.png");
            pbMK.Image = Image.FromFile(path2);
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





       

      

     


     


      

      

    

       
    }
}
