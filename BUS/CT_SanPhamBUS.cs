using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class CT_SanPhamBUS
    {
        CT_SanPhamDAO ctspDAO = new CT_SanPhamDAO();
        public List<CT_SanPhamDTO> layDsCtSP()
        {
            return ctspDAO.layDsCtSP();
        }
        public List<CT_SanPhamDTO> TimCTSP(string text)
        {
            return ctspDAO.TimCTSP(text);
        }
        public bool ThemCTSP(CT_SanPhamDTO ctsp)
        {
            return ctspDAO.themCTSP(ctsp);
        }
        public bool XoaCTSP(CT_SanPhamDTO ctsp)
        {
            return ctspDAO.xoaCTSP(ctsp);
        }
        public bool SuaCTSP(CT_SanPhamDTO ctsp)
        {
            return ctspDAO.suaCTSP(ctsp);
        }
    }
}
