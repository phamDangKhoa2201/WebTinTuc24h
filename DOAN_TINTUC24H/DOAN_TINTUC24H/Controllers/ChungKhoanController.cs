using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DOAN_TINTUC24H.Models;

namespace DOAN_TINTUC24H.Controllers
{
    public class ChungKhoanController : Controller
    {
        // GET: ChungKhoan
        public ActionResult Index(string sort = "", int page = 1)
        {
            NewsDBContext db = new NewsDBContext();
            //List<TinTuc> chungkhoan = db.tinTucs.ToList();
            List<TinTuc> chungkhoan = db.tinTucs.Where(row => row.maTL == 2).ToList();
            //sort
            switch (sort)
            {

                case "ngaydang":
                    chungkhoan = chungkhoan.OrderByDescending(row => row.ngayDang).ToList();
                    break;
                case "tieude":
                    chungkhoan = chungkhoan.OrderBy(row => row.tieuDe).ToList();
                    break;


            }
            //pagingt

            int NoOfRecordPerPage = 7;
            int NoOfPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(chungkhoan.Count) / Convert.ToDouble(NoOfRecordPerPage)));
            int toSkip = (page - 1) * NoOfRecordPerPage;
            ViewBag.Page = page;
            ViewBag.Noofpage = NoOfPages;
            chungkhoan = chungkhoan.Skip(toSkip).Take(NoOfRecordPerPage).ToList();

            return View(chungkhoan);
        }
    }
}