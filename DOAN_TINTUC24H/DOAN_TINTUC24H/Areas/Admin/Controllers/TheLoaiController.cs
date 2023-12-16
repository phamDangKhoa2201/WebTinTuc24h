using DOAN_TINTUC24H.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DOAN_TINTUC24H.Filters;

namespace DOAN_TINTUC24H.Areas.Admin.Controllers
{
    [AdminAuthorization]
    public class TheLoaiController : Controller
    {
        NewsDBContext db = new NewsDBContext();
        // GET: Admin/TheLoai
        public ActionResult Index()
        {

            NewsDBContext db = new NewsDBContext();
            List<TheLoai> theloais = db.theLoais.ToList();

            return View(theloais);
        }
       
    }
}