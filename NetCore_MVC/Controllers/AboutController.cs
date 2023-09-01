using Microsoft.AspNetCore.Mvc;

namespace NetCore_MVC.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
