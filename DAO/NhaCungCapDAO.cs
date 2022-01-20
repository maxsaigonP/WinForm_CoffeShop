using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class NhaCungCapDAO
    {
        qlCoffeeP2TEntities _qlCoffeep2t = new qlCoffeeP2TEntities();
        public List<NhaCungCapDTO> LayDSNCC()
        {
            List<NhaCungCapDTO> lstNCC = new List<NhaCungCapDTO>();
            lstNCC = _qlCoffeep2t.NHACUNGCAPs.Where(v => v.TrangThai == 1).Select(u => new NhaCungCapDTO
            {
            MaNCC = u.MaNCC,
            TenNCC = u.TenNCC,
            DiaChi = u.DiaChi,
            SDT = u.SDT
            }).ToList();
            return lstNCC;
        }
        public List<NhaCungCapDTO> TimNCC(string text)
        {
            List<NhaCungCapDTO> lstNCC = new List<NhaCungCapDTO>();
            lstNCC = _qlCoffeep2t.NHACUNGCAPs.Where(v => v.TrangThai == 1 && (v.MaNCC == text || v.TenNCC.Contains(text) || v.DiaChi.Contains(text))).Select(u => new NhaCungCapDTO
            {
                MaNCC = u.MaNCC,
                TenNCC = u.TenNCC,
                DiaChi = u.DiaChi,
                SDT = u.SDT
            }).ToList();
            return lstNCC;
        }
        public bool ThemNCC(NhaCungCapDTO ncc)
        {
            try
            {
                int temp = _qlCoffeep2t.ThemNCC(ncc.MaNCC, ncc.TenNCC, ncc.DiaChi, ncc.SDT);
                _qlCoffeep2t.SaveChanges();
                    return temp > 0;
            } catch (Exception e)
            {
                e.Message.ToString();
                return false;
            }
        }
        public bool XoaNCC(NhaCungCapDTO ncc)
        {
            try
            {
                int temp = _qlCoffeep2t.XoaNCC(ncc.MaNCC);
                _qlCoffeep2t.SaveChanges();
                return temp > 0;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return false;
            }
        }
        public bool SuaNCC(NhaCungCapDTO ncc)
        {
            try
            {
                int temp = _qlCoffeep2t.SuaNCC(ncc.MaNCC, ncc.TenNCC, ncc.DiaChi, ncc.SDT);
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
