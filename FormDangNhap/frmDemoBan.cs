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
    public partial class frmDemoBan : Form
    {
        private BanBUS _BanBUS = new BanBUS();
        public frmDemoBan()
        {
            InitializeComponent();
        }

        private void frmDemoBan_Load(object sender, EventArgs e)
        {
            foreach(BanDTO item in _BanBUS.LayDSBan())
            {
                Button btn = new Button() {
                    Width = BanDAO.WidthTable,
                    Height = BanDAO.HeightTable,
                    BackgroundImage = Image.FromFile("D:\\P2T_Coffee_Shop\\FormDangNhap\\images\\coffee.png"),
                    BackgroundImageLayout = ImageLayout.Stretch
                };
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.TinhTrang)
                {
                    case 1: btn.BackColor = Color.Maroon; break;
                    default: btn.BackColor = Color.LemonChiffon; break;
                };
                btn.Text = item.MaSoBan.ToString();
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.ForeColor = Color.White;
                flpBan.Controls.Add(btn);
            }
        }
        void btn_Click(object sender, EventArgs e)
        {
            int MaSoBan = ((sender as Button).Tag as BanDTO).MaSoBan;
            txtMa.Text = MaSoBan.ToString();
        }

        

      
    }
}
