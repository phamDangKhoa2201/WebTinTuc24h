using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DOAN_TINTUC24H.ViewModel
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Không được để trống tài khoản")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Không được để trống mật khẩu")]
        public string Password { get; set; }
    }
}