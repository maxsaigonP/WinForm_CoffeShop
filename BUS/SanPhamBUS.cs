using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BUS
{
    public class SanPhamBUS
    {
        private SanPhamDAO _SanPhamDAO = new SanPhamDAO();
        public List<SanPhamDTO> LayDSSP()
        {
            return _SanPhamDAO.LayDSSP();
        }
        public List<SanPhamDTO> TimSP(string text)
        {
            return _SanPhamDAO.TimSP(text);
        }
        public bool ThemSP(SanPhamDTO sp)
        {
            return _SanPhamDAO.ThemSP(sp);
        }
        public bool SuaSP(SanPhamDTO sp)
        {
            return _SanPhamDAO.SuaSP(sp);
        }
        public bool XoaSP(SanPhamDTO sp)
        {
            return _SanPhamDAO.XoaSP(sp);
        }
        public List<SanPhamDTO> laySP(string ma_sp)
        {
            return _SanPhamDAO.laySP(ma_sp);
        }
    }
}
