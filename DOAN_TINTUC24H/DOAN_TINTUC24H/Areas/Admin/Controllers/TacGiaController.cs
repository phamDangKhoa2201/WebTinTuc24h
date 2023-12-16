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
    public class TacGiaController : Controller
    {
        // GET: Admin/TacGia
        NewsDBContext db = new NewsDBContext();
        public ActionResult Index()
        {
            NewsDBContext db = new NewsDBContext();
            List<TacGia> tacgias = db.tacGias.ToList();

            return View(tacgias);
        }
        public ActionResult Create()
        {
            ViewBag.TacGia = db.tacGias.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Create(TacGia tg)
        {
            if (ModelState.IsValid)
            {
                db.tacGias.Add(tg);
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
            TacGia tgs = db.tacGias.Where(row => row.maTG == id).FirstOrDefault();

            return View(tgs);
        }
        [HttpPost]
        public ActionResult Edit(TacGia tg)
        {

            TacGia tgs = db.tacGias.Where(row => row.maTG == tg.maTG).FirstOrDefault();
            if (ModelState.IsValid)
            {
                tgs.tenTG = tg.tenTG;
                tgs.Email = tg.Email;
                tgs.SDT = tg.SDT;
                tgs.diaChi = tg.diaChi;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Edit");
            }
        }
    }
}