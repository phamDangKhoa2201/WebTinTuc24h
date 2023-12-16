using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DOAN_TINTUC24H.Models
{
    public class NewsDBContext:DbContext
    {
        public NewsDBContext() : base("MyCS") { }
        public DbSet<TacGia> tacGias { get; set; }
        public DbSet<TheLoai> theLoais { get; set; }
        public DbSet<TinTuc> tinTucs { get; set; } 

    }
}