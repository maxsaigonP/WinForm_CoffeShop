using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SanPhamDAO
    {
        qlCoffeeP2TEntities _qlCoffeep2t = new qlCoffeeP2TEntities();
        public List<SanPhamDTO> LayDSSP()
        {
            List<SanPhamDTO> lstSP = new List<SanPhamDTO>();
            lstSP = _qlCoffeep2t.SanPhams.Where(v => v.TrangThai == 1).Select(u => new SanPhamDTO
            {
            MaSP = u.MaSP,
            TenSp = u.TenSp,
            DonGia = u.DonGia,
            HinhAnh = u.HinhAnh
            }).ToList();
            return lstSP;
        }
        public List<SanPhamDTO> laySP(string ma_sp)
        {
            List<SanPhamDTO> sp = _qlCoffeep2t.SanPhams.Where(v => v.MaSP == ma_sp).Select(u => new SanPhamDTO { TenSp = u.TenSp }).ToList();
            return sp;
        }
        public List<SanPhamDTO> TimSP(string text)
        {
            List<SanPhamDTO> lstSP = new List<SanPhamDTO>();
            lstSP = _qlCoffeep2t.SanPhams.Where(v => v.TrangThai == 1 && v.MaSP == text || v.TenSp.Contains(text)).Select(u => new SanPhamDTO
            {
                MaSP = u.MaSP,
                TenSp = u.TenSp,
                DonGia = u.DonGia,
                HinhAnh = u.HinhAnh
            }).ToList();
            return lstSP;
        }
   
        public bool ThemSP(SanPhamDTO sp)
        {
            try
            {

                int temp = _qlCoffeep2t.ThemSP(sp.MaSP, sp.TenSp, sp.DonGia, sp.HinhAnh);
                _qlCoffeep2t.SaveChanges();
                return temp > 0;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return false;
            }
        }
        public bool XoaSP(SanPhamDTO sp)
        {
            try
            {
                int temp = _qlCoffeep2t.XoaSP(sp.MaSP);
                _qlCoffeep2t.SaveChanges();
                return temp > 0;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return false;
            }
        }
        public bool SuaSP(SanPhamDTO sp)
        {
            try
            {
                int temp = _qlCoffeep2t.SuaSP(sp.MaSP, sp.TenSp, sp.DonGia, sp.HinhAnh);
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
