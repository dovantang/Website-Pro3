using Microsoft.AspNetCore.Mvc;

namespace NetCore_MVC.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
