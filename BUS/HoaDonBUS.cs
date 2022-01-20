using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDonBUS
    {
        private HoaDonDAO _HoaDonDAO = new HoaDonDAO();
        public List<HoaDonDTO> LayDSHD()
        {
            return _HoaDonDAO.LayDSHD();
        }
        public List<CTHoaDonDTO> LayDSTT(int mahd)
        {
            return _HoaDonDAO.LayDSTT(mahd);
        }
        public List<HoaDonDTO> TimHD(int mahd)
        {
            return _HoaDonDAO.TimHD(mahd);
        }
        public List<HoaDonDTO> TimHDTheoNgay(DateTime ngayA, DateTime ngayB)
        {
            return _HoaDonDAO.TimHDTheoNgay(ngayA, ngayB);
        }
        public bool themHD(HoaDonDTO hd)
        {
            return _HoaDonDAO.ThemHD(hd);
        }
        public int MaxHd()
        {
            return _HoaDonDAO.MaxHD();
        }

        public bool XoaHD(HoaDonDTO hd)
        {
            return _HoaDonDAO.XoaHD(hd);
        }
        public bool CapNhatHD(HoaDonDTO hd)
        {
            return _HoaDonDAO.CapNhatHD(hd);
        }
        public List<HoaDonDTO> layHD(int mahd)
        {
            return _HoaDonDAO.layHD(mahd);
        }
    }
}
