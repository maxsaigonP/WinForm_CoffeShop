using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class CT_SanPhamDAO
    {
        qlCoffeeP2TEntities _qlCoffeep2t = new qlCoffeeP2TEntities();
        public List<CT_SanPhamDTO> layDsCtSP()
        {
            List<CT_SanPhamDTO> lst = _qlCoffeep2t.CT_SanPham.Where(v => v.TrangThai == 1).Select(u => new CT_SanPhamDTO { MaSP = u.MaSP, MaNL = u.MaNL }).ToList();
            return lst;
        }
        public List<CT_SanPhamDTO> TimCTSP(string text)
        {
            List<CT_SanPhamDTO> lst = _qlCoffeep2t.CT_SanPham.Where(v => v.TrangThai == 1 && v.MaNL == text || v.MaSP == text).Select(u => new CT_SanPhamDTO { MaSP = u.MaSP, MaNL = u.MaNL }).ToList();
            return lst;
        }

        public bool themCTSP(CT_SanPhamDTO ctsp)
        {
            try
            {
                int temp = _qlCoffeep2t.ThemCTSP(ctsp.MaSP, ctsp.MaNL);
                _qlCoffeep2t.SaveChanges();
                return temp > 0;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return false;
            }

        }
        public bool xoaCTSP(CT_SanPhamDTO ctsp)
        {
            try
            {
                int temp = _qlCoffeep2t.XoaCTSP(ctsp.MaSP);
                _qlCoffeep2t.SaveChanges();
                return temp > 0;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return false;
            }

        }
        public bool suaCTSP(CT_SanPhamDTO ctsp)
        {
            try
            {
                int temp = _qlCoffeep2t.SuaCTSP(ctsp.MaSP,ctsp.MaNL);
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
