using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DOAN_TINTUC24H.ViewModel
{
    public class RegisterVM
    {
        [Required(ErrorMessage ="Không được để trống tài khoản")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Không được để trống mật khẩu")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Không được để trống xác nhận mật khẩu")]
        [Compare("Password",ErrorMessage ="Không trùng mật khẩu")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Không được để trống Email")]
        [EmailAddress(ErrorMessage ="Email không hợp lệ")]
        public string Email { get; set; }
        public DateTime? Birthday { get; set; }
        public string Address { get; set; }
        public string Comment { get; set; }
    }
}