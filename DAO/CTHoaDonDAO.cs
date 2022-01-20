using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CTHoaDonDAO
    {
        qlCoffeeP2TEntities _qlCoffeep2t = new qlCoffeeP2TEntities();
        public List<CTHoaDonDTO> LayDSCTHD()
        {
            List<CTHoaDonDTO> lstCTHD = new List<CTHoaDonDTO>();
            lstCTHD = _qlCoffeep2t.CT_HOADON.Distinct().Where(v => v.TrangThai == 1).Select(u => new CTHoaDonDTO
            {
                MaHD = u.MaHD,
                MaSP = u.MaSP,
                SoLuong = u.SoLuong,
                DonGia = u.DonGia
            }).ToList();
            return lstCTHD;
        }
        public bool themCTHD(CTHoaDonDTO cthd)
        {
            try
            {

                int temp = _qlCoffeep2t.ThemCTHD(cthd.MaHD, cthd.MaSP, cthd.SoLuong, cthd.DonGia);
                _qlCoffeep2t.SaveChanges();
                return temp > 0;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return false;
            }
        }
        public List<CTHoaDonDTO> TimCTHD(int mahd)
        {
            List<CTHoaDonDTO> lstcthd = new List<CTHoaDonDTO>();

            lstcthd = _qlCoffeep2t.CT_HOADON.Distinct().Where(v => v.TrangThai == 1 &&
                (v.MaHD == mahd))
                .Select(u => new CTHoaDonDTO
                {
                    MaHD = u.MaHD,
                    MaSP = u.MaSP,
                    SoLuong = u.SoLuong,
                    DonGia = u.DonGia
                }).ToList();
            return lstcthd;
        }

        public bool XoaCTHD(CTHoaDonDTO hd)
        {
            try
            {
                int temp = _qlCoffeep2t.XoaCTHD(hd.MaHD, hd.MaSP);
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
