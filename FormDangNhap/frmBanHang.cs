using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using BUS;
using DTO;

namespace FormDangNhap
{
    public partial class frmBanHang : Form
    {
        public static int soLuong = 0;
        public static double donGia = 0;
        public static double thanhTien = 0;
        public static string ten = "";
        public frmBanHang()
        {
            InitializeComponent();
        }
        private HoaDonBUS hdBUS = new HoaDonBUS();
        private CTHoaDonBUS cthdBUS = new CTHoaDonBUS();
        private SanPhamBUS sp_BUS = new SanPhamBUS();
        private List<SanPhamDTO> lst = new List<SanPhamDTO>();
        private BanBUS banBUS = new BanBUS();
        private List<BanDTO> lstBan = new List<BanDTO>();

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            lst = sp_BUS.LayDSSP();
            lstBan = banBUS.LayDSBan();

            int a = lstBan.Count;

            for (int i = 1; i <= a; i++)
            {
                ListViewItem lstB = new ListViewItem(i.ToString());
                lstB.ImageIndex = 0;
                lstB.SubItems.Add("MaHD");
                lstB.SubItems.Add("TTien");

                lvBan.Items.Add(lstB);
            }


            int b = lst.Count;


            for (int i = 0; i <= b - 1; i++)
            {

                ListViewItem lstMon = new ListViewItem(lst[i].TenSp);
                lstMon.ImageIndex = i;
                lstMon.SubItems.Add(lst[i].TenSp);
                lstMon.SubItems.Add(lst[i].DonGia.ToString());//data
                lstMon.SubItems.Add(lst[i].MaSP);
                lv_Mon.Items.Add(lstMon);
                string path = string.Format(@"{0}\..\..\images\{1}", Environment.CurrentDirectory, lst[i].HinhAnh);
                imgMon.Images.Add(Image.FromFile(path));

            }
        }

        private void lvBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<HoaDonDTO> lsthd = hdBUS.LayDSHD();
            List<CTHoaDonDTO> lstcthd = cthdBUS.LayDSCTHD();
            List<SanPhamDTO> lstsp = sp_BUS.LayDSSP();
            //---
            ListView.SelectedListViewItemCollection item;
            item = lvBan.SelectedItems;
            if (item.Count > 0)
            {
                txtBan.Text = lvBan.SelectedItems[0].SubItems[0].Text;
                lv_Mon.Enabled = true;
                txtGia.Enabled = true;
                txtBan.Enabled = true;
                txtTenMon.Enabled = true;
                btnBanMoi.Enabled = true;
                btnThem.Enabled = true;
                btnDatBan.Enabled = true;
                txtTongTien.Text = "";
                for (int i = 0; i < listView2.Items.Count; i++)
                {
                    listView2.Items[i].Remove();
                }
                if (listView2.Items.Count > 0)
                {
                    listView2.Items.Clear();
                }

                //--
                if (lvBan.SelectedItems[0].SubItems[1].Text != "MaHD")
                {
                    lv_Mon.Enabled = false;
                    txtGia.Enabled = false;
                    txtBan.Enabled = false;
                    txtTenMon.Enabled = false;
                    btnBanMoi.Enabled = false;
                    btnThem.Enabled = false;
                    btnDatBan.Enabled = false;
                    numericUpDown1.Enabled = false;


                    if (listView2.Items.Count > 0)
                    {
                        for (int i = 0; i < listView2.Items.Count; i++)
                        {
                            listView2.Items[i].Remove();
                        }

                    }
                    //Load dl len lview
                    int a = int.Parse(lvBan.SelectedItems[0].SubItems[1].Text);
                    for (int i = 1; i <= hdBUS.LayDSTT(a).Count; i++)
                    {
                        ListViewItem lst = new ListViewItem(lvBan.SelectedItems[0].SubItems[0].Text);
                        lst.SubItems.Add(sp_BUS.laySP(hdBUS.LayDSTT(a)[i - 1].MaSP)[0].TenSp);
                        lst.SubItems.Add(hdBUS.LayDSTT(a)[i - 1].MaSP);
                        lst.SubItems.Add((hdBUS.LayDSTT(a)[i - 1].DonGia / hdBUS.LayDSTT(a)[i - 1].SoLuong).ToString());
                        lst.SubItems.Add(hdBUS.LayDSTT(a)[i - 1].SoLuong.ToString());
                        lst.SubItems.Add(hdBUS.LayDSTT(a)[i - 1].DonGia.ToString());


                        listView2.Items.Add(lst);
                    }
                    txtTongTien.Text = lvBan.SelectedItems[0].SubItems[2].Text;

                }
                else
                {
                    return;
                }


            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
         
            string sl = numericUpDown1.Value.ToString();
            soLuong = Int32.Parse(sl);
            try
            {
                donGia = double.Parse(txtGia.Text);
                thanhTien = soLuong * donGia;
                ListViewItem lst = new ListViewItem(txtBan.Text);
                lst.SubItems.Add(txtTenMon.Text);
                lst.SubItems.Add(lv_Mon.SelectedItems[0].SubItems[3]);
                lst.SubItems.Add(donGia.ToString());
                lst.SubItems.Add(soLuong.ToString());
                lst.SubItems.Add(thanhTien.ToString());
                listView2.Items.Add(lst);
                lvBan.Enabled = false;


                txtGia.Text = null;
                txtTenMon.Text = null;
                double tongTien = 0;


                for (int i = 1; i <= listView2.Items.Count; i++)
                {
                    double tien = double.Parse(listView2.Items[i - 1].SubItems[5].Text);
                    tongTien = tongTien + tien;
                }


                txtTongTien.Text = tongTien.ToString();
                numericUpDown1.Value = 1;
            } catch (Exception ex)
            {
                ex.Message.ToString();
                return;
            }
        }

        private void lv_Mon_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection item;
            item = lv_Mon.SelectedItems;
            if (item.Count > 0)
            {
                txtTenMon.Text = lv_Mon.SelectedItems[0].SubItems[1].Text;
                txtGia.Text = lv_Mon.SelectedItems[0].SubItems[2].Text;
            }
            numericUpDown1.Enabled = true;
        }

        private void btnBanMoi_Click(object sender, EventArgs e)
        {
            try
            {
                lvBan.Enabled = true;
                txtBan.Text = null;
                numericUpDown1.Enabled = true;
                if (listView2.Items.Count > 0)
                {
                    listView2.Items.Clear();
                }
                txtTongTien.Text = "";
                numericUpDown1.Value = 1;
            } catch (Exception ex)
            {
                ex.Message.ToString();
                return;
            }
        }

        private void btnDatBan_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 1; i <= listView2.Items.Count; i++)
                {


                    HoaDonDTO hd = new HoaDonDTO()
                    {

                        MaSoBan = int.Parse(txtBan.Text),
                        MaNV = "N01",
                        TongTien = decimal.Parse(txtTongTien.Text)

                    };
                    banBUS.ThayDoiTTBAN(int.Parse(txtBan.Text));
                    hdBUS.themHD(hd);
                    for (int j = 1; j <= listView2.Items.Count; j++)
                    {
                        CTHoaDonDTO cthd = new CTHoaDonDTO()
                        {
                            MaHD = hdBUS.MaxHd(),
                            MaSP = listView2.Items[j - 1].SubItems[2].Text,
                            SoLuong = int.Parse(listView2.Items[j - 1].SubItems[4].Text),
                            DonGia = decimal.Parse(listView2.Items[j - 1].SubItems[5].Text)

                        };
                        cthdBUS.themCTHD(cthd);


                        lvBan.Items[int.Parse(txtBan.Text) - 1].SubItems[1].Text = hdBUS.MaxHd().ToString();
                        lvBan.Items[int.Parse(txtBan.Text) - 1].SubItems[2].Text = txtTongTien.Text;
                    }


                }
                for (int i = 1; i < lvBan.Items.Count; i++)
                {
                    if (lvBan.Items[i - 1].SubItems[0].Text == txtBan.Text)
                    {
                        lvBan.Items[i - 1].ImageIndex = 1;
                    }
                }
            } catch (Exception ex)
            {
                ex.Message.ToString();
                return;
            }
        }


        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                lvBan.SelectedItems[0].ImageIndex = 0;
                lvBan.SelectedItems[0].SubItems[1].Text = "MaHD";
                txtTongTien.Text = "";
                if (listView2.Items.Count > 0)
                {
                    listView2.Items.Clear();
                }
                banBUS.ThayDoiTTBAN2(int.Parse(txtBan.Text));
                lv_Mon.Enabled = true;
                btnBanMoi.Enabled = true;
                btnThem.Enabled = true;
                btnDatBan.Enabled = true;
                numericUpDown1.Enabled = true;
                txtBan.Text = "";
            } catch (Exception ex)
            {
                ex.Message.ToString();
                return;
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radChuyen_CheckedChanged(object sender, EventArgs e)
        {
            cbbFrom.Enabled = true;
            cbbTo.Enabled = true;
            for (int i = 0; i < lvBan.Items.Count; i++)
            {
                if (lvBan.Items[i].SubItems[1].Text != "MaHD")
                {
                    cbbFrom.Items.Add(lvBan.Items[i].SubItems[0].Text);
                }
                else
                {
                    cbbTo.Items.Add(lvBan.Items[i].SubItems[0].Text);
                }

            }
        }

        private void radGop_CheckedChanged(object sender, EventArgs e)
        {
            cbbFrom.Enabled = true;
            cbbTo.Enabled = true;
            cbbFrom.Items.Clear();
            cbbTo.Items.Clear();
            for (int i = 0; i < lvBan.Items.Count; i++)
            {
                if (lvBan.Items[i].SubItems[1].Text != "MaHD")
                {
                    cbbFrom.Items.Add(lvBan.Items[i].SubItems[0].Text);

                }
                if (lvBan.Items[i].SubItems[1].Text != "MaHD")
                {
                    cbbTo.Items.Add(lvBan.Items[i].SubItems[0].Text);
                }

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (radChuyen.Checked == true)
            {
                for (int i = 0; i < lvBan.Items.Count; i++)
                {
                    if (lvBan.Items[i].SubItems[0].Text == cbbTo.SelectedItem.ToString())
                    {
                        lvBan.Items[i].SubItems[1].Text = lvBan.Items[int.Parse(cbbFrom.SelectedItem.ToString()) - 1].SubItems[1].Text;
                        lvBan.Items[i].ImageIndex = 1;
                        lvBan.Items[int.Parse(cbbFrom.SelectedItem.ToString()) - 1].ImageIndex = 0;
                        HoaDonDTO hd = new HoaDonDTO()
                        {
                            MaHD = int.Parse(lvBan.Items[int.Parse(cbbFrom.SelectedItem.ToString()) - 1].SubItems[1].Text),
                            MaSoBan = int.Parse(cbbTo.SelectedItem.ToString()),
                            TongTien = hdBUS.layHD(int.Parse(lvBan.Items[i].SubItems[1].Text))[0].TongTien
                        };
                        hdBUS.CapNhatHD(hd);
                        lvBan.Items[int.Parse(cbbFrom.SelectedItem.ToString()) - 1].SubItems[1].Text = "MaHD";
                    }
                }
            }
            if (radGop.Checked == true)
            {
                decimal tongtien = 0;
                for (int i = 0; i < lvBan.Items.Count; i++)
                {
                    if (lvBan.Items[i].SubItems[0].Text == cbbTo.SelectedItem.ToString())
                    {
                        for (int j = 0; j < hdBUS.LayDSTT(int.Parse(lvBan.Items[int.Parse(cbbFrom.SelectedItem.ToString()) - 1].SubItems[1].Text)).Count; j++)
                        {
                            CTHoaDonDTO cthd = new CTHoaDonDTO()
                            {
                                MaHD = int.Parse(lvBan.Items[int.Parse(cbbTo.SelectedItem.ToString()) - 1].SubItems[1].Text),
                                MaSP = hdBUS.LayDSTT(int.Parse(lvBan.Items[int.Parse(cbbFrom.SelectedItem.ToString()) - 1].SubItems[1].Text))[j].MaSP,
                                SoLuong = hdBUS.LayDSTT(int.Parse(lvBan.Items[int.Parse(cbbFrom.SelectedItem.ToString()) - 1].SubItems[1].Text))[j].SoLuong,
                                DonGia = hdBUS.LayDSTT(int.Parse(lvBan.Items[int.Parse(cbbFrom.SelectedItem.ToString()) - 1].SubItems[1].Text))[j].DonGia
                            };
                            cthdBUS.themCTHD(cthd);
                        }
                        HoaDonDTO hd = new HoaDonDTO()
                        {
                            MaHD = int.Parse(lvBan.Items[int.Parse(cbbFrom.SelectedItem.ToString()) - 1].SubItems[1].Text)
                        };
                        hdBUS.XoaHD(hd);
                        for (int k = 0; k < hdBUS.LayDSTT(int.Parse(lvBan.Items[int.Parse(cbbFrom.SelectedItem.ToString()) - 1].SubItems[1].Text)).Count; k++)
                        {
                            tongtien = tongtien + hdBUS.LayDSTT(int.Parse(lvBan.Items[int.Parse(cbbFrom.SelectedItem.ToString()) - 1].SubItems[1].Text))[k].DonGia;
                        }
                        HoaDonDTO upHD = new HoaDonDTO()
                        {
                            MaHD = int.Parse(lvBan.Items[int.Parse(cbbTo.SelectedItem.ToString()) - 1].SubItems[1].Text),
                            MaSoBan = int.Parse(cbbTo.SelectedItem.ToString()),
                            TongTien = tongtien

                        };
                        hdBUS.CapNhatHD(upHD);
                        lvBan.Items[int.Parse(cbbFrom.SelectedItem.ToString()) - 1].ImageIndex = 0;
                        lvBan.Items[int.Parse(cbbFrom.SelectedItem.ToString()) - 1].SubItems[1].Text = "MaHD";
                    }
                }
            }
            radChuyen.Checked = false;
            radGop.Checked = false;
            cbbFrom.Items.Clear();
            cbbTo.Items.Clear();
            cbbFrom.Text = "";
            cbbTo.Text = "";
            cbbFrom.Enabled = false;
            cbbTo.Enabled = false;
        }
    }
}
