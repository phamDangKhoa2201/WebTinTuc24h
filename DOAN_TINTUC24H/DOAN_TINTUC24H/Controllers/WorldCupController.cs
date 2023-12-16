using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DOAN_TINTUC24H.Models;

namespace DOAN_TINTUC24H.Controllers
{
    public class WorldCupController : Controller
    {
        // GET: WorldCup
        public ActionResult Index(string sort = "", int page = 1)
        {
            NewsDBContext db = new NewsDBContext();
            List<TinTuc> wc = db.tinTucs.Where(row=>row.maTL==7).ToList();
            //sort
            switch (sort)
            {

                case "ngaydang":
                    wc = wc.OrderByDescending(row => row.ngayDang).ToList();
                    break;
                case "tieude":
                    wc = wc.OrderBy(row => row.tieuDe).ToList();
                    break;


            }
            //paging
            int NoOfRecordPerPage = 7;
            int NoOfPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(wc.Count) / Convert.ToDouble(NoOfRecordPerPage)));
            int toSkip = (page - 1) * NoOfRecordPerPage;
            ViewBag.Pagewc = page;
            ViewBag.Noofpagewc = NoOfPages;
            wc = wc.Skip(toSkip).Take(NoOfRecordPerPage).ToList();
            return View(wc);
        }
        public ActionResult Detail(int id)
        {
            NewsDBContext db = new NewsDBContext();
            TinTuc news = db.tinTucs.Where(row => row.maTinTuc == id).FirstOrDefault();
            return View(news);
        }
    }
}