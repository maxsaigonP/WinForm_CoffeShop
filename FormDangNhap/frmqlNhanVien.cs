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
using DTO;

namespace FormDangNhap
{
    public partial class frmqlNhanVien : Form
    {
    

        private NhanVienBUS _NhanVienBUS = new NhanVienBUS();
        public frmqlNhanVien()
        {
            InitializeComponent();
            
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmqlNhanVien_Load(object sender, EventArgs e)
        {
            if(Constants.LoaiTK == "Quản lý")
            {
                btnThemNV.Enabled = true;
                btnXoa.Enabled = true;
                btnSuaThongTinNV.Enabled = true;
            }
            else if(Constants.LoaiTK == "Nhân viên")
            {
                btnThemNV.Enabled = false;
                btnXoa.Enabled = false;
                btnSuaThongTinNV.Enabled = false;
            }
            cbbTimTheo.DataSource = _NhanVienBUS.LayDSCV();
            cbbTimTheo.DisplayMember = "ChucVu";
            cbbTimTheo.ValueMember = "ChucVu";
            cbbTimTheo.SelectedValue = "";
            cbbChucVu.DataSource = _NhanVienBUS.LayDSCV();
            cbbChucVu.DisplayMember = "ChucVu";
            cbbChucVu.ValueMember = "ChucVu";
            dgvFrm_qlNhanVien.DataSource = _NhanVienBUS.LayDSNV();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == String.Empty && txtHoTen.Text == String.Empty && txtEmail.Text == String.Empty
                && txtSDT.Text == String.Empty || !_NhanVienBUS.KTEmail(txtEmail.Text))
            {
                MessageBox.Show(Constants.ERR_REQUIRED, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                return;
            }
            NhanVienDTO nv = new NhanVienDTO()
            {
                MaNV = txtMaNV.Text,
                TenNV = txtHoTen.Text,
                NgayVaoLam = dtpNgaySinh.Value,
                NgaySinh = dtpNgayVL.Value,
                GioiTinh = rbNam.Checked ? "Nam" : "Nữ",
                ChucVu = cbbChucVu.SelectedValue.ToString(),
                SDT = txtSDT.Text,
                Email = txtEmail.Text
            };
            if (_NhanVienBUS.ThemNV(nv))
            {
                MessageBox.Show(Constants.ADD_SUCCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                dgvFrm_qlNhanVien.DataSource = _NhanVienBUS.LayDSNV();
                return;
            }
            else
            {
                MessageBox.Show(Constants.ADD_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
            }
        }

     

        private void btnSuaThongTinNV_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == String.Empty)
            {
                MessageBox.Show(Constants.ERR_REQUIRED, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                return;
            }
            NhanVienDTO nv = new NhanVienDTO()
            {
                MaNV = txtMaNV.Text,
                TenNV = txtHoTen.Text,
                NgayVaoLam = dtpNgaySinh.Value,
                NgaySinh = dtpNgayVL.Value,
                GioiTinh = rbNam.Checked ? "Nam" : "Nữ",
                ChucVu = cbbChucVu.SelectedValue.ToString(),
                SDT = txtSDT.Text,
                Email = txtEmail.Text
            };
            if (_NhanVienBUS.CapNhatNV(nv) == true)
            {
                MessageBox.Show(Constants.UPDATE_SUCCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                dgvFrm_qlNhanVien.DataSource = _NhanVienBUS.LayDSNV();
                return;
            }
            else
            {
                MessageBox.Show(Constants.UPDATE_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
            }
        }

        private void dgvFrm_qlNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            txtMaNV.ReadOnly = true;
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvFrm_qlNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                dtpNgayVL.Value = Convert.ToDateTime(row.Cells[2].Value.ToString());
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells[3].Value.ToString());
                if (row.Cells[4].Value.ToString() == "Nam") rbNam.Checked = true;
                else rbNu.Checked = true;
                cbbChucVu.SelectedValue = row.Cells[5].Value.ToString();
                txtSDT.Text = row.Cells[6].Value.ToString();
                txtEmail.Text = row.Cells[7].Value.ToString();
            }
            else
            {
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaNV.ReadOnly = false;
            dgvFrm_qlNhanVien.DataSource = _NhanVienBUS.LayDSNV();
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            dtpNgayVL.Value = DateTime.Now;
            dtpNgaySinh.Value = DateTime.Now;
            rbNam.Checked = true;
            cbbChucVu.SelectedIndex = 0;
            txtSDT.Text = "";
            txtEmail.Text = "";
            cbbTimTheo.SelectedValue = "";
            txtTim.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == String.Empty)
            {
                MessageBox.Show(Constants.ERR_REQUIRED, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                return;
            }
            NhanVienDTO nv = new NhanVienDTO()
            {
                MaNV = txtMaNV.Text
            };
            if (_NhanVienBUS.XoaNV(nv))
            {
                MessageBox.Show(Constants.DELETE_SUCCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                dgvFrm_qlNhanVien.DataSource = _NhanVienBUS.LayDSNV();
                return;
            }
            else
            {
                MessageBox.Show(Constants.DELETE_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
            }
        }

     

        private void cbbTimTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbTimTheo.SelectedIndex == 0)
            {
                dgvFrm_qlNhanVien.DataSource = _NhanVienBUS.TimNV("Admin");
            }
            else
            {
                dgvFrm_qlNhanVien.DataSource = _NhanVienBUS.TimNV("Nhân viên");
            }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            string text = txtTim.Text;
            if (text != "")
            {
                dgvFrm_qlNhanVien.DataSource = _NhanVienBUS.TimNV(text);
            }
            else
            {
                dgvFrm_qlNhanVien.DataSource = _NhanVienBUS.LayDSNV();
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
