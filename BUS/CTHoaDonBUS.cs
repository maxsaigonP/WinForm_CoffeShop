using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CTHoaDonBUS
    {
        private CTHoaDonDAO _CTHoaDonDAO = new CTHoaDonDAO();
        public List<CTHoaDonDTO> LayDSCTHD()
        {
            return _CTHoaDonDAO.LayDSCTHD();
        }
        public List<CTHoaDonDTO> TimCTHD(int mahd)
        {
            return _CTHoaDonDAO.TimCTHD(mahd);
        }
        public bool themCTHD(CTHoaDonDTO cthd)
        {
            return _CTHoaDonDAO.themCTHD(cthd);
        }
        public bool XoaCTHD(CTHoaDonDTO hd)
        {
            return _CTHoaDonDAO.XoaCTHD(hd);
        }
    }
}
