using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BanDAO
    {
        qlCoffeeP2TEntities _qlCoffeep2t = new qlCoffeeP2TEntities();
        public static int WidthTable = 80;
        public static int HeightTable = 80;
        public List<BanDTO> LayDSBan()
        {
            List<BanDTO> lstBan = new List<BanDTO>();
            lstBan = _qlCoffeep2t.BANPHUCVUs.Where(v => v.TrangThai == 1).Select(u => new BanDTO {
                MaSoBan = u.MaSoBan,
                SoGhe = u.SoGhe,
                TinhTrang = u.TinhTrang.Value
            }).ToList();
            return lstBan;
        }
        public bool ThayDoiTTBan(int maSoban)
        {
            try
            {
                BANPHUCVU ban = _qlCoffeep2t.BANPHUCVUs.SingleOrDefault(v => v.TrangThai == 1 && v.MaSoBan == maSoban);
                ban.TinhTrang = 1;
                _qlCoffeep2t.SaveChanges();
                return true;
            } catch (Exception ex)
            {
                ex.ToString();
                return false;
            }
        }
        public bool ThayDoiTTBan2(int maSoban)
        {
            try
            {
                BANPHUCVU ban = _qlCoffeep2t.BANPHUCVUs.SingleOrDefault(v => v.TrangThai == 1 && v.MaSoBan == maSoban);
                ban.TinhTrang = 0;
                _qlCoffeep2t.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return false;
            }
        }
        public List<BanDTO> TimBan(int text)
        {
            List<BanDTO> lstBan = new List<BanDTO>();
            lstBan = _qlCoffeep2t.BANPHUCVUs.Where(v => v.TrangThai == 1 && v.MaSoBan == text).Select(u => new BanDTO
            {
                MaSoBan = u.MaSoBan,
                SoGhe = u.SoGhe,
                TinhTrang = u.TinhTrang.Value
            }).ToList();
            return lstBan;
        }
        public bool ThemBan(BanDTO ban)
        {
            try
            {
                int temp = _qlCoffeep2t.ThemBan(ban.SoGhe);
                _qlCoffeep2t.SaveChanges();
                return temp > 0;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return false;
            }
        }
        public bool XoaBan(BanDTO ban)
        {
            try
            {
                int temp = _qlCoffeep2t.XoaBan(ban.MaSoBan);
                _qlCoffeep2t.SaveChanges();
                return temp > 0;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return false;
            }
        }
        public bool SuaBan(BanDTO ban)
        {
            try
            {
                int temp = _qlCoffeep2t.SuaBan(ban.MaSoBan,ban.SoGhe);
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
