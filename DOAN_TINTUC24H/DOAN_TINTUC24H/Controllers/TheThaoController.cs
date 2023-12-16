using DOAN_TINTUC24H.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOAN_TINTUC24H.Controllers
{
    public class TheThaoController : Controller
    {
        // GET: TheThao
        public ActionResult Index(string sort = "", int page = 1)
        {
            NewsDBContext db = new NewsDBContext();
            List<TinTuc> nganhang = db.tinTucs.Where(row => row.maTL == 6).ToList();
            //sort
            switch (sort)
            {

                case "ngaydang":
                    nganhang = nganhang.OrderByDescending(row => row.ngayDang).ToList();
                    break;
                case "tieude":
                    nganhang = nganhang.OrderBy(row => row.tieuDe).ToList();
                    break;


            }
            //paging
            int NoOfRecordPerPage = 7;
            int NoOfPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(nganhang.Count) / Convert.ToDouble(NoOfRecordPerPage)));
            int toSkip = (page - 1) * NoOfRecordPerPage;
            ViewBag.Page = page;
            ViewBag.Noofpage = NoOfPages;
            nganhang = nganhang.Skip(toSkip).Take(NoOfRecordPerPage).ToList();
            return View(nganhang);
        }
    }
}