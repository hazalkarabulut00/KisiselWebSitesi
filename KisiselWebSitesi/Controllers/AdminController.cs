using Microsoft.AspNetCore.Mvc;

namespace KisiselWebSitesi.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
