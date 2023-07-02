using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Controllers
{
    public class ContactController : Controller
    {
        Context c = new Context();
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public PartialViewResult MailAl()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult MailAl(iletisim i)
        { 
            if (i.AdSoyad != null || i.Mail != null || i.Konu != null || i.Mesaj != null)
            {
                TempData["Success"] = "Mailiniz başarılı bir şekilde gönderildi.";
                c.iletisims.Add(i);
                c.SaveChanges();
            }
            else
            {
                ViewData["Error"] = "Mailiniz gönderilemedi. Lütfen alanları doldurunuz."; 
            }
            return PartialView();
        }
    }
}