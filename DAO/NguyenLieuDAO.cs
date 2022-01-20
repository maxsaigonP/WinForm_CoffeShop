using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class NguyenLieuDAO
    {
        qlCoffeeP2TEntities _qlCoffeep2t = new qlCoffeeP2TEntities();
        public List<NguyenLieuDTO> LayDSNL()
        {
            List<NguyenLieuDTO> lst = new List<NguyenLieuDTO>();
            lst = _qlCoffeep2t.NGUYENLIEUx.Where(v => v.TrangThai == 1).Select(u => new NguyenLieuDTO
            {
                MaNL = u.MaNL,
                TenNL = u.TenNL,
                MaNCC = u.MaNCC,          
                DonViTinh = u.DonViTinh,
                DonGia = u.DonGia.Value,
                SLTonKho = u.SLTonKho.Value
            }).ToList();

            return lst;
        }
        public List<NguyenLieuDTO> TimNL(string manl)
        {
            List<NguyenLieuDTO> lst = new List<NguyenLieuDTO>();
            lst = _qlCoffeep2t.NGUYENLIEUx.Where(v => v.TrangThai == 1 && v.MaNL.Contains(manl) || v.TenNL.Contains(manl)).Select(u => new NguyenLieuDTO
            {
                MaNL = u.MaNL,
                TenNL = u.TenNL,
                MaNCC = u.MaNCC,
                DonViTinh = u.DonViTinh,
                DonGia = u.DonGia.Value,
                SLTonKho = u.SLTonKho.Value
            }).ToList();

            return lst;
        }
        public bool ThemNL(NguyenLieuDTO nl)
        {
            try
            {
                int temp = _qlCoffeep2t.ThemNL(nl.MaNL, nl.TenNL, nl.MaNCC, nl.DonViTinh, nl.DonGia, nl.SLTonKho);
                _qlCoffeep2t.SaveChanges();
                return temp > 0;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return false;
            }
        }
        public bool SuaNL(NguyenLieuDTO nl)
        {
            try
            {
                int temp = _qlCoffeep2t.SuaNL(nl.MaNL, nl.TenNL, nl.MaNCC, nl.DonViTinh, nl.DonGia, nl.SLTonKho);
                _qlCoffeep2t.SaveChanges();
                return temp > 0;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return false;
            }
        }
        public bool XoaNL(NguyenLieuDTO nl)
        {
            try
            {
                int temp = _qlCoffeep2t.XoaNL(nl.MaNL);
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
