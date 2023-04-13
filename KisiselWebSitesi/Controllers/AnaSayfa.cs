using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KisiselWebSitesi.Models;

namespace KisiselWebSitesi.Controllers
{
    public class AnaSayfa : Controller
    {
        KisiselWebSitesiDatabaseContext c = new KisiselWebSitesiDatabaseContext();
        public ActionResult Index()
        {
            var deger = c.AnaSayfas.ToList();
            return View(deger);
        }
        public PartialViewResult ikonlar()
        {
            var deger =c.Ikonlarrs.ToList();
            return PartialView(deger);
        }
    }
}
