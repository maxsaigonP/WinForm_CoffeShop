using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BanBUS
    {
        private BanDAO _BanDAO = new BanDAO();
        public List<BanDTO> LayDSBan()
        {
            return _BanDAO.LayDSBan();
        }
        public List<BanDTO> TimBan(int maban)
        {
            return _BanDAO.TimBan(maban);
        }
        public bool ThayDoiTTBAN(int maSoBan)
        {
            return _BanDAO.ThayDoiTTBan(maSoBan);
        }
        public bool ThayDoiTTBAN2(int maSoBan)
        {
            return _BanDAO.ThayDoiTTBan2(maSoBan);
        }
        public bool ThemBan(BanDTO ban)
        {
            return _BanDAO.ThemBan(ban);
        }
        public bool XoaBan(BanDTO ban)
        {
            return _BanDAO.XoaBan(ban);
        }
        public bool CapNhatBan(BanDTO ban)
        {
            return _BanDAO.SuaBan(ban);
        }
    }
}
