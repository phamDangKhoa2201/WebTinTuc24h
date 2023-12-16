using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DOAN_TINTUC24H.Models
{
    public class TacGia
    {
        [Key]
        public int maTG { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên tác giả")]
        public string tenTG { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập số ĐT")]
        public string SDT { get; set; }
        public string diaChi { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập Email")]
        public string Email { get; set; }
    }
}