using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class NguyenLieuBUS
    {
        private NguyenLieuDAO _NguyenLieuDAO = new NguyenLieuDAO();
        public List<NguyenLieuDTO> LayDSNL()
        {
            return _NguyenLieuDAO.LayDSNL();
        }
        public List<NguyenLieuDTO> TimNL(string manl)
        {
            return _NguyenLieuDAO.TimNL(manl);
        }
        public bool ThemNL(NguyenLieuDTO nl)
        {
            return _NguyenLieuDAO.ThemNL(nl);
        }
        public bool SuaNL(NguyenLieuDTO nl)
        {
            return _NguyenLieuDAO.SuaNL(nl);
        }
        public bool XoaNL(NguyenLieuDTO nl)
        {
            return _NguyenLieuDAO.XoaNL(nl);
        }
    }
}
