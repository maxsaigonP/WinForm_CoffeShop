using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TaiKhoanBUS
    {
        private TaiKhoanDAO _TaiKhoanDAO = new TaiKhoanDAO();
        public List<TaiKhoanDTO> LayDSTK()
        {
            return _TaiKhoanDAO.LayDSTK();
        }
        public List<TaiKhoanDTO> PhanQuyen(string text)
        {
            return _TaiKhoanDAO.PhanQuyen(text);
        }
        public List<TaiKhoanDTO> TimTK(string text)
        {
            return _TaiKhoanDAO.TimTK(text);
        }
        public List<TaiKhoanDTO> LayDSLoaiTK()
        {
            return _TaiKhoanDAO.LayDSLoaiTK();
        }
        public bool KiemTraTK(TaiKhoanDTO tk)
        {
            return _TaiKhoanDAO.KiemTraTK(tk);
        }
        public bool ThemTK(TaiKhoanDTO tk)
        {
            return _TaiKhoanDAO.ThemTK(tk);
        }
        public bool XoaTK(TaiKhoanDTO tk)
        {
            return _TaiKhoanDAO.XoaTK(tk);
        }
        public bool CapNhatTK(TaiKhoanDTO tk)
        {
            return _TaiKhoanDAO.CapNhatTK(tk);
        }
        public bool DoiMK(string tk, string mk)
        {
            return _TaiKhoanDAO.DoiMK(tk,mk);
        }
        
    }
}
