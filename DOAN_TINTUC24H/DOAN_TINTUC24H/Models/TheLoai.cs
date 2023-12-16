using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DOAN_TINTUC24H.Models
{
    public class TheLoai
    {
        [Key]
        public int maTL { get; set; }
        [Required(ErrorMessage = "Hãy nhập thể loại")]
        public string tenTL { get; set; }
    }
}