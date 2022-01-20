using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class TaiKhoanDAO
    {
        qlCoffeeP2TEntities _qlCoffeep2t = new qlCoffeeP2TEntities();
        public List<TaiKhoanDTO> LayDSTK()
        {
            List<TaiKhoanDTO> lstTaiKhoan = new List<TaiKhoanDTO>();
            lstTaiKhoan = _qlCoffeep2t.TAIKHOANs.Where(v => v.TrangThai == 1).Select(u => new TaiKhoanDTO 
            {
            TenTK = u.TenTK,
            MatKhau = u.MatKhau,
            MaNV = u.MaNV,
            LoaiTK = u.LoaiTK
            }).ToList();
           
            return lstTaiKhoan;
        }
        public List<TaiKhoanDTO> TimTK(string text)
        {
            List<TaiKhoanDTO> lstTaiKhoan = new List<TaiKhoanDTO>();
            lstTaiKhoan = _qlCoffeep2t.TAIKHOANs.Where(v => v.TrangThai == 1 && (v.TenTK.Contains(text) || v.LoaiTK == text)).Select(u => new TaiKhoanDTO
            {
                TenTK = u.TenTK,
                MatKhau = u.MatKhau,
                MaNV = u.MaNV,
                LoaiTK = u.LoaiTK
            }).ToList();

            return lstTaiKhoan;
        }
        public List<TaiKhoanDTO> PhanQuyen(string tk)
        {
            List<TaiKhoanDTO> lstTaiKhoan = new List<TaiKhoanDTO>();
             lstTaiKhoan = _qlCoffeep2t.TAIKHOANs.Where(v => v.TenTK == tk && v.TrangThai == 1).Select(u => new TaiKhoanDTO {
                 LoaiTK = u.LoaiTK
             }).ToList();
            return lstTaiKhoan;
        }
        public List<TaiKhoanDTO> LayDSLoaiTK()
        {
            List<TaiKhoanDTO> lstLoai = new List<TaiKhoanDTO>();
            lstLoai = _qlCoffeep2t.TAIKHOANs.Select(u => new TaiKhoanDTO
            {LoaiTK = u.LoaiTK}).Distinct().ToList();

            return lstLoai;
        }
        
        public bool KiemTraTK(TaiKhoanDTO tk)
        {
            try
            {
                TAIKHOAN taikhoan = _qlCoffeep2t.TAIKHOANs.SingleOrDefault(v => v.TenTK == tk.TenTK && v.MatKhau == tk.MatKhau);
                return taikhoan.TenTK != "";
            } catch (Exception e)
            {
                e.Message.ToString();
                return false;
            }
        }
        public bool ThemTK(TaiKhoanDTO tk)
        {
       
            try
            {
                int temp = _qlCoffeep2t.ThemTK(tk.TenTK, tk.MatKhau, tk.MaNV, tk.LoaiTK);
                _qlCoffeep2t.SaveChanges();
                return temp > 0;
            } catch (Exception e)
            {
                e.Message.ToString();
                return false;
            }
        }
        public bool XoaTK(TaiKhoanDTO tk)
        {
            try
            {
                int temp = _qlCoffeep2t.XoaTK(tk.TenTK);
                _qlCoffeep2t.SaveChanges();
                return temp > 0;
            } catch (Exception e)
            {
                e.Message.ToString();
                return false;
            }
        }
        public bool CapNhatTK(TaiKhoanDTO tk)
        {
            try
            {
                int temp = _qlCoffeep2t.CapNhatTK(tk.TenTK, tk.MatKhau, tk.MaNV, tk.LoaiTK);
                _qlCoffeep2t.SaveChanges();
                return temp > 0;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return false;
            }
        }
        public bool DoiMK(string tk, string mk)
        {
            string mahoa = mk.MaHoaMD5();
            try
            {
                int temp = _qlCoffeep2t.DoiMK(tk,mahoa);
                _qlCoffeep2t.SaveChanges();
                return temp > 0;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return false;
            }
        }
        
    }
}
