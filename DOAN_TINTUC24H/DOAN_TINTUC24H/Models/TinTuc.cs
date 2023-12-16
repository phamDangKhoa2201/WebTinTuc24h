using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DOAN_TINTUC24H.Models
{
    public class TinTuc
    {
        [Key]
        public int maTinTuc { get; set; }
        [Required(ErrorMessage = "Hãy nhập tên tiêu đề")]
        public string tieuDe { get; set; }
        [Required(ErrorMessage = "Hãy nhập ngày đăng")]
        public Nullable<DateTime> ngayDang { get; set; }
        
        public string hinh1 { get; set; }
        public string hinh2 { get; set; }
        [Required(ErrorMessage = "Hãy nhập đoạn 1")]
        public string doan1 { get; set; }
        
        public string doan2 { get; set; }
        public string doan3 { get; set; }
        [Required(ErrorMessage = "Hãy chọn thể loại")]
        public Nullable<int> maTL { get; set; }
        [Required(ErrorMessage = "Hãy chọn tác giả")]
        public Nullable<int> maTG { get; set; }
        
        public string cthinh1 { get; set; }
        public string cthinh2 { get; set; }
        public virtual TacGia TacGia { get; set; }
        public virtual TheLoai TheLoai { get; set; }
    }
}