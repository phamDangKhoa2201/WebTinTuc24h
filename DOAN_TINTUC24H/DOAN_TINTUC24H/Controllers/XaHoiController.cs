using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DOAN_TINTUC24H.Models;

namespace DOAN_TINTUC24H.Controllers
{
    public class XaHoiController : Controller
    {
        // GET: XaHoi
        public ActionResult Index(string sort = "", int page = 1)
        {

            NewsDBContext db = new NewsDBContext();
            List<TinTuc> xahoi = db.tinTucs.Where(row => row.maTL == 1).ToList();
            //sort
            switch (sort)
            {

                case "ngaydang":
                    xahoi = xahoi.OrderByDescending(row => row.ngayDang).ToList();
                    break;
                case "tieude":
                    xahoi = xahoi.OrderBy(row => row.tieuDe).ToList();
                    break;
               

            }
            //paging
            int NoOfRecordPerPage = 7;
            int NoOfPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(xahoi.Count) / Convert.ToDouble(NoOfRecordPerPage)));
            int toSkip = (page - 1) * NoOfRecordPerPage;
            ViewBag.Page = page;
            ViewBag.Noofpage = NoOfPages;
            xahoi = xahoi.Skip(toSkip).Take(NoOfRecordPerPage).ToList();
            return View(xahoi);
        }
        
    }
}