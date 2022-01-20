using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class NhanVienDAO
    {
        qlCoffeeP2TEntities _qlCoffeep2t = new qlCoffeeP2TEntities();

        public List<NhanVienDTO> LayDSNV()
        {
            List<NhanVienDTO> lstnhanvien = new List<NhanVienDTO>();
            lstnhanvien = _qlCoffeep2t.NHANVIENs.Distinct().Where(v => v.TrangThai == 1).Select(u => new NhanVienDTO 
            { 
            MaNV = u.MaNV,
            TenNV = u.TenNV,
            NgayVaoLam = u.NgayVaoLam,
            NgaySinh = u.NgaySinh,
            GioiTinh = u.GioiTinh,
            ChucVu = u.ChucVu,
            SDT = u.SDT,
            Email = u.Email
            }).ToList();
            return lstnhanvien;
        }
        public List<NhanVienDTO> TimNV(string text)
        {
            List<NhanVienDTO> lstnhanvien = new List<NhanVienDTO>();
            lstnhanvien = _qlCoffeep2t.NHANVIENs.Distinct().Where(v => v.TrangThai == 1 &&( v.ChucVu == text || v.MaNV == text || v.TenNV.Contains(text))).Select(u => new NhanVienDTO
            {
                MaNV = u.MaNV,
                TenNV = u.TenNV,
                NgayVaoLam = u.NgayVaoLam,
                NgaySinh = u.NgaySinh,
                GioiTinh = u.GioiTinh,
                ChucVu = u.ChucVu,
                SDT = u.SDT,
                Email = u.Email
            }).ToList();
            return lstnhanvien;
        }
        public List<NhanVienDTO> TimNVTheoNgay(DateTime ngayA, DateTime ngayB)
        {

            List<NhanVienDTO> lstnhanvien = new List<NhanVienDTO>();

            lstnhanvien = _qlCoffeep2t.NHANVIENs.Distinct().Where(v => (v.NgayVaoLam >= ngayA) && (v.NgayVaoLam <= ngayB)).Select(u => new NhanVienDTO
            {
                MaNV = u.MaNV,
                TenNV = u.TenNV,
                NgayVaoLam = u.NgayVaoLam,
                NgaySinh = u.NgaySinh,
                GioiTinh = u.GioiTinh,
                ChucVu = u.ChucVu,
                SDT = u.SDT,
                Email = u.Email
            }).ToList();

            return lstnhanvien;
        }
        public List<NhanVienDTO> ListTenNV()
        {
            List<NhanVienDTO> lstnhanvien = new List<NhanVienDTO>();
            lstnhanvien = _qlCoffeep2t.NHANVIENs.Distinct().Where(v => v.TrangThai == 1).Select(u => new NhanVienDTO
            {
                TenNV = u.TenNV
            }).ToList();
            return lstnhanvien;
        }
        public List<NhanVienDTO> LayDSCV()
        {
            List<NhanVienDTO> lstChucVu = new List<NhanVienDTO>();
            lstChucVu = _qlCoffeep2t.NHANVIENs.Select(u => new NhanVienDTO { ChucVu = u.ChucVu }).Distinct().ToList();
            return lstChucVu;
        }
        public bool ThemNV(NhanVienDTO nv)
        {
            try
            {
                int temp = _qlCoffeep2t.ThemNV(nv.MaNV, nv.TenNV, nv.NgaySinh, nv.NgayVaoLam, nv.GioiTinh,
                nv.ChucVu, nv.SDT, nv.Email);
                _qlCoffeep2t.SaveChanges();
                return temp > 0;
            } catch (Exception e)
            {
                e.Message.ToString();
                return false;
            }
        }
        public bool XoaNV(NhanVienDTO nv)
        {
            try
            {
                int temp = _qlCoffeep2t.XoaNV(nv.MaNV);
                _qlCoffeep2t.SaveChanges();
                return temp > 0;
            } catch(Exception e)
            {
                e.Message.ToString();
                return false;
            }
        }
        public bool CapNhatNV(NhanVienDTO nv)
        {
            try
            {
                int temp = _qlCoffeep2t.SuaNV(nv.MaNV, nv.TenNV, nv.NgaySinh, nv.NgayVaoLam, nv.GioiTinh,
                nv.ChucVu, nv.SDT, nv.Email);
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
