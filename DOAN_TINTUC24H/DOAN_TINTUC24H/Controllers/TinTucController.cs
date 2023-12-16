using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DOAN_TINTUC24H.Models;
using System.Data.Entity;

namespace DOAN_TINTUC24H.Controllers
{
    
    public class TinTucController : Controller
    {
        NewsDBContext db = new NewsDBContext();
        // GET: TinTuc
        public ActionResult Index(string search="", string sort = "", int page = 1)
        {
            NewsDBContext db = new NewsDBContext();
            //List<TinTuc> tintuc = db.tinTucs.ToList();
            //search
            List<TinTuc> tintuc = db.tinTucs.Where(row => row.tieuDe.Contains(search)).ToList();
            tintuc= db.tinTucs.Where(row => row.doan1.Contains(search)).ToList();
            ViewBag.Search = search;
            //sort
            switch (sort)
            {

                case "ngaydang":
                    tintuc = tintuc.OrderByDescending(row => row.ngayDang).ToList();
                    break;
                case "tieude":
                    tintuc = tintuc.OrderBy(row => row.tieuDe).ToList();
                    break;


            }
            //paging
            int NoOfRecordPerPage = 7;
            int NoOfPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(tintuc.Count) / Convert.ToDouble(NoOfRecordPerPage)));
            int toSkip = (page - 1) * NoOfRecordPerPage;
            ViewBag.Page = page;
            ViewBag.Noofpage = NoOfPages;
            tintuc = tintuc.Skip(toSkip).Take(NoOfRecordPerPage).ToList();

            return View(tintuc);
        }
        public ActionResult Detail(int id)
        {
            NewsDBContext db = new NewsDBContext();
            TinTuc news = db.tinTucs.Where(row => row.maTinTuc == id).FirstOrDefault();
            return View(news);
        }
        
    }
}