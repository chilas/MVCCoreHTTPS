using Microsoft.AspNetCore.Mvc;

namespace CoreMVC
{
    class HomeController : Controller
    {
        public ActionResult Index(){
            return View();
        }
    }
}