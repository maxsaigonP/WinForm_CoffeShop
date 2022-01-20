using BUS;
using DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDangNhap
{
    public partial class frmXemBaoCao : Form
    {
        private NhanVienBUS _nhanvienBUS = new NhanVienBUS();
        private HoaDonBUS _hoadonBUS = new HoaDonBUS();
        private NguyenLieuBUS _nguyenlieuBUS = new NguyenLieuBUS();

        public frmXemBaoCao()
        {
            InitializeComponent();
        }
        private void frmXemBaoCao_Load(object sender, EventArgs e)
        {

            this.rptXemBaoCao.RefreshReport();
        }

        public void XemDSNV()
        {

            List<NhanVienDTO> lstnv = new List<NhanVienDTO>();
            lstnv = _nhanvienBUS.LayDSNV();
            rptXemBaoCao.LocalReport.ReportEmbeddedResource = "FormDangNhap.rptDSNV.rdlc";
            rptXemBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSNV", lstnv));
            rptXemBaoCao.RefreshReport();
        }

        public void XemDSNVTheoNgayVaoLam(DateTime text1, DateTime text2)
        {

            List<NhanVienDTO> lstnv = new List<NhanVienDTO>();
            lstnv = _nhanvienBUS.TimNVTheoNgay(text1, text2);
            rptXemBaoCao.LocalReport.ReportEmbeddedResource = "FormDangNhap.rptDSNV.rdlc";
            rptXemBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSNV", lstnv));
            rptXemBaoCao.RefreshReport();
        }

        public void XemDSHDTheoNgayLapHD(DateTime ngayA, DateTime ngayB)
        {

            List<HoaDonDTO> lsthd = new List<HoaDonDTO>();
            lsthd = _hoadonBUS.TimHDTheoNgay(ngayA, ngayB);
            rptXemBaoCao.LocalReport.ReportEmbeddedResource = "FormDangNhap.rptDSHD.rdlc";
            rptXemBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSHD", lsthd));
            rptXemBaoCao.RefreshReport();
        }

        public void XemDSHD()
        {

            List<HoaDonDTO> lsthd = new List<HoaDonDTO>();
            lsthd = _hoadonBUS.LayDSHD();
            rptXemBaoCao.LocalReport.ReportEmbeddedResource = "FormDangNhap.rptDSHD.rdlc";
            rptXemBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSHD", lsthd));
            rptXemBaoCao.RefreshReport();
        }

        public void XemDSNL()
        {

            List<NguyenLieuDTO> lstnl = new List<NguyenLieuDTO>();
            lstnl = _nguyenlieuBUS.LayDSNL();
            rptXemBaoCao.LocalReport.ReportEmbeddedResource = "FormDangNhap.rptDSNL.rdlc";
            rptXemBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSNL", lstnl));
            rptXemBaoCao.RefreshReport();
        }


        public void XemDoanhThu(DateTime ngayA, DateTime ngayB)
        {

            List<HoaDonDTO> lsthd = new List<HoaDonDTO>();
            lsthd = _hoadonBUS.TimHDTheoNgay(ngayA, ngayB);
            rptXemBaoCao.LocalReport.ReportEmbeddedResource = "FormDangNhap.rptDoanhThu.rdlc";
            rptXemBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DoanhThu", lsthd));
            rptXemBaoCao.RefreshReport();
        }
    
    }
}
