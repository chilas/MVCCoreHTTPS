using Microsoft.AspNetCore.Mvc;

namespace MVCCoreHTTPS
{
    class HomeController : Controller
    {
        public ActionResult Index(){
            return View();
        }
    }
}