using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Text.RegularExpressions;
namespace BUS
{
    public class NhanVienBUS
    {
        private NhanVienDAO _NhanVienDAO = new NhanVienDAO();

        public List<NhanVienDTO> LayDSNV()
        {
            return _NhanVienDAO.LayDSNV();
        }
        public bool KTEmail(string email)
        {
            string strRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

            Regex regex = new Regex(strRegex);
            Match match = regex.Match(email);
            return match.Success;

        }
        public List<NhanVienDTO> TimNVTheoNgay(DateTime text1, DateTime text2)
        {
            return _NhanVienDAO.TimNVTheoNgay(text1, text2);
        }
        public List<NhanVienDTO> ListTenNV()
        {
            return _NhanVienDAO.ListTenNV();
        }
        public List<NhanVienDTO> LayDSCV()
        {
            return _NhanVienDAO.LayDSCV();
        }
        public List<NhanVienDTO> TimNV(string nv)
        {
            return _NhanVienDAO.TimNV(nv);
        }
        public bool ThemNV(NhanVienDTO nv)
        {
            return _NhanVienDAO.ThemNV(nv);
        }
        public bool XoaNV(NhanVienDTO nv)
        {
            return _NhanVienDAO.XoaNV(nv);
        }
        public bool CapNhatNV(NhanVienDTO nv)
        {
            return _NhanVienDAO.CapNhatNV(nv);
        }
    }
}
