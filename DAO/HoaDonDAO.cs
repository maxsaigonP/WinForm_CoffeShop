using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoaDonDAO
    {
        qlCoffeeP2TEntities _qlCoffeep2t = new qlCoffeeP2TEntities();
        public List<HoaDonDTO> LayDSHD()
        {
            List<HoaDonDTO> lstHD = new List<HoaDonDTO>();
            lstHD = _qlCoffeep2t.HOADONs.Distinct().Where(v => v.TrangThai == 1).Select(u => new HoaDonDTO
            {
                MaHD = u.MaHD,
                MaSoBan = u.MaSoBan,
                MaNV = u.MaNV,
                NgayLapHD = u.NgayLapHD.Value,
                TongTien = u.TongTien.Value
            }).ToList();
            return lstHD;
        }
        public List<CTHoaDonDTO> LayDSTT(int mahd)
        {
            List<CTHoaDonDTO> lst = new List<CTHoaDonDTO>();
            lst = _qlCoffeep2t.CT_HOADON.Where(v => v.MaHD == mahd).Select(u => new CTHoaDonDTO { MaHD = u.MaHD, MaSP = u.MaSP, SoLuong = u.SoLuong, DonGia = u.DonGia }).ToList();
            return lst;
        }
        public List<HoaDonDTO> layHD(int mahd)
        {
            List<HoaDonDTO> hd = new List<HoaDonDTO>();
            hd = _qlCoffeep2t.HOADONs.Where(v => v.MaHD == mahd && v.TrangThai == 1).Select(u => new HoaDonDTO 
            { MaSoBan = u.MaSoBan, TongTien = u.TongTien.Value }).ToList();
            return hd;
        }
        public List<HoaDonDTO> TimHD(int mahd)
        {
            List<HoaDonDTO> lsthd = new List<HoaDonDTO>();

            lsthd = _qlCoffeep2t.HOADONs.Distinct().Where(v => v.TrangThai == 1 &&
                (v.MaHD == mahd))
                .Select(u => new HoaDonDTO
                {
                    MaHD = u.MaHD,
                    MaSoBan = u.MaSoBan,
                    MaNV = u.MaNV,
                    NgayLapHD = u.NgayLapHD.Value,
                    TongTien = u.TongTien.Value
                }).ToList();
            return lsthd;
        }
        public List<HoaDonDTO> TimHDTheoNgay(DateTime ngayA, DateTime ngayB)
        {
            List<HoaDonDTO> lsthd = new List<HoaDonDTO>();

            lsthd = _qlCoffeep2t.HOADONs.Distinct().Where(v => (v.NgayLapHD >= ngayA) && (v.NgayLapHD <= ngayB)).Select(u => new HoaDonDTO
            {
                MaHD = u.MaHD,
                MaSoBan = u.MaSoBan,
                MaNV = u.MaNV,
                NgayLapHD = u.NgayLapHD.Value,
                TongTien = u.TongTien.Value
            }).ToList();

            return lsthd;
        }
        public bool ThemHD(HoaDonDTO hd)
        {
            try
            {

                int temp = _qlCoffeep2t.ThemHD(hd.MaSoBan, hd.MaNV, hd.TongTien);
                _qlCoffeep2t.SaveChanges();
                return temp > 0;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return false;
            }
        }
        public int MaxHD()
        {
            return _qlCoffeep2t.HOADONs.Max(u => u.MaHD);
        }
        public bool XoaHD(HoaDonDTO hd)
        {
            try
            {
                int temp = _qlCoffeep2t.XoaHD(hd.MaHD);
                _qlCoffeep2t.SaveChanges();
                return temp > 0;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return false;
            }
        }

        public bool CapNhatHD(HoaDonDTO hd)
        {

            try
            {
                int temp = _qlCoffeep2t.SuaHD(hd.MaHD, hd.MaSoBan,hd.TongTien);
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
