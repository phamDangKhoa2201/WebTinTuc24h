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
    public class TinTucController : Controller
    {
        // GET: Admin/TinTuc
        NewsDBContext db = new NewsDBContext();
        // GET: TinTuc
        public ActionResult Index(string search = "", string sort = "", int page = 1)
        {
            NewsDBContext db = new NewsDBContext();
            //List<TinTuc> tintuc = db.tinTucs.ToList();
            //search
            List<TinTuc> tintuc = db.tinTucs.Where(row => row.tieuDe.Contains(search)).ToList();
            tintuc = db.tinTucs.Where(row => row.doan1.Contains(search)).ToList();
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
        public ActionResult Create()
        {
            ViewBag.TacGia = db.tacGias.ToList();
            ViewBag.TheLoai = db.theLoais.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Create(TinTuc em)
        {
            if (ModelState.IsValid)
            {
                db.tinTucs.Add(em);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Create");
            }
        }
        public ActionResult Edit(int id)
        {
            ViewBag.TacGia = db.tacGias.ToList();
            ViewBag.TheLoai = db.theLoais.ToList();
            TinTuc emps = db.tinTucs.Where(row => row.maTinTuc == id).FirstOrDefault();

            return View(emps);
        }
        [HttpPost]
        public ActionResult Edit(TinTuc em)
        {

            TinTuc emps = db.tinTucs.Where(row => row.maTinTuc == em.maTinTuc).FirstOrDefault();
            emps.tieuDe = em.tieuDe;
            emps.ngayDang = em.ngayDang;
            emps.hinh1 = em.hinh1;
            emps.cthinh1 = em.cthinh1;
            emps.hinh2 = em.hinh2;
            emps.cthinh2 = em.cthinh2;
            emps.doan1 = em.doan1;
            emps.doan2 = em.doan2;
            emps.doan3 = em.doan3;
            emps.maTL = em.maTL;

            emps.maTG = em.maTG;

            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {

            TinTuc emps = db.tinTucs.Where(row => row.maTinTuc == id).FirstOrDefault();

            return View(emps);
        }
        [HttpPost]
        public ActionResult Delete(int id, TinTuc em)
        {

            TinTuc emps = db.tinTucs.Where(row => row.maTinTuc == id).FirstOrDefault();
            db.tinTucs.Remove(emps);
            db.SaveChanges();
            return RedirectToAction("Index", "TinTuc");
        }
    }
}