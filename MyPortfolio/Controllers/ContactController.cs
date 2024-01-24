using MyPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolio.Controllers
{
    public class ContactController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.description = db.Address.Select(x => x.Description).FirstOrDefault();
            ViewBag.phone = db.Address.Select(x => x.Phone).FirstOrDefault();
            ViewBag.mail = db.Address.Select(x => x.Mail).FirstOrDefault();
            ViewBag.addressDetail = db.Address.Select(x => x.AddressDetail).FirstOrDefault();
            return View();
        }

        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            db.Contact.Add(contact);
            db.SaveChanges();
            return RedirectToAction("Index","Default"); // child olduğu için ana sayfayı açamıyor çözmeye çalış!!!!!!
        }

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}