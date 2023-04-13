using KisiselWebSitesi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace KisiselWebSitesi.Controllers
{
    public class Login : Controller
    {
        public object FormsAuthentication { get; private set; }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Index(Admin p)
        {
            KisiselWebSitesiDatabaseContext c= new KisiselWebSitesiDatabaseContext();
            var adminuserinfo = c.Admins.FirstOrDefault(x => x.KullaniciAdi == p.KullaniciAdi && x.Sifre == p.Sifre);
            if (adminuserinfo!=null)
            {
                HttpContext.Session.SetString("KullaniciAdi", p.KullaniciAdi);
            return RedirectToAction("Index","AdminController");
            }
            else {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
