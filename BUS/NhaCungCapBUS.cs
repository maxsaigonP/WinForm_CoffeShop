using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class NhaCungCapBUS
    {
        private NhaCungCapDAO _NhaCungCapDAO = new NhaCungCapDAO();
        public List<NhaCungCapDTO> LayDSNCC()
        {
            return _NhaCungCapDAO.LayDSNCC();
        }
        public List<NhaCungCapDTO> TimNCC(string text)
        {
            return _NhaCungCapDAO.TimNCC(text);
        }
        public bool ThemNCC(NhaCungCapDTO ncc)
        {
            return _NhaCungCapDAO.ThemNCC(ncc);
        }
        public bool XoaNCC(NhaCungCapDTO ncc)
        {
            return _NhaCungCapDAO.XoaNCC(ncc);
        }
        public bool SuaNCC(NhaCungCapDTO ncc)
        {
            return _NhaCungCapDAO.SuaNCC(ncc);
        }
    }
}
