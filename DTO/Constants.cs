using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public static class Constants
    {
        #region PHÂN QUYỀN
        public static string LoaiTK;
        public static string TenTK;
        public static string MatKhau;
        #endregion
        #region THÔNG BÁO
        public static string MESSAGE_TITLE = "Thông Báo";
        public static string ERR_REQUIRED = "Vui lòng điền đầy đủ thông tin !";
        public static string ERR_EMAIL_FORMAT = "Email chưa đúng định dạng !";
        public static string LOGIN_SUCCESS = "Đăng nhập thành công";
        public static string LOGIN_FAIL = "Đăng nhập thất bại";
        public static string EXIT = "Bạn có chắc chắn muốn thoát hay không";

        public static string ADD_SUCCESS = "Thêm thành công";
        public static string ADD_FAIL = "Thêm thất bại !";

        public static string DELETE_SUCCESS = "Xóa thành công";
        public static string DELETE_FAIL = "Xóa thất bại !";

        public static string UPDATE_SUCCESS = "Cập nhật thành công";
        public static string UPDATE_FAIL = "Cập nhật thất bại !";

        public static string NOTNUMBER = "Vui lòng nhập số !";
        public static string ERR_PASS = "Mật khẩu nhập lại chưa trùng khớp";
        public static string CHANGE_PASS_SUCCESS = "Đổi mật khẩu thành công";
        public static string CHANGE_PASS_FAIL = "Đổi mật khẩu thất bại";
        #endregion
    }
}
