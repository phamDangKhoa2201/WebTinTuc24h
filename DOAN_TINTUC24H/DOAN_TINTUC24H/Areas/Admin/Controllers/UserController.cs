using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DOAN_TINTUC24H.Identity;
using DOAN_TINTUC24H.Filters;


namespace DOAN_TINTUC24H.Areas.Admin.Controllers
{
    [AdminAuthorization]
    public class UserController : Controller
    {
        AppDbContext db = new AppDbContext();
        // GET: Admin/User
        public ActionResult Index()
        {
            AppDbContext db = new AppDbContext();
            List<AppUser> users= db.Users.ToList();
            return View(users);
        }
        public ActionResult Edit(string id)
        {
            ViewBag.User = db.Users.ToList();
            AppUser tgs = db.Users.Where(row => row.Id == id).FirstOrDefault();

            return View(tgs);
        }
        [HttpPost]
        public ActionResult Edit(AppUser tg)
        {

            AppUser tgs = db.Users.Where(row => row.Id == tg.Id).FirstOrDefault();
            if (ModelState.IsValid)
            {
                tgs.UserName = tg.UserName;
                tgs.Email = tg.Email;
                tgs.Birthday = tg.Birthday;
                tgs.Address = tg.Address;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Edit");
            }
        }
        public ActionResult Delete(string id)
        {

            AppUser emps = db.Users.Where(row => row.Id == id).FirstOrDefault();

            return View(emps);
        }
        [HttpPost]
        public ActionResult Delete(string id, AppUser em)
        {

            AppUser emps = db.Users.Where(row => row.Id == id).FirstOrDefault();
            db.Users.Remove(emps);
            db.SaveChanges();
            return RedirectToAction("Index", "User");
        }
    }
}