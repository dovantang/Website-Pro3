using Microsoft.AspNetCore.Mvc;
using NetCore_MVC.Models;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Drawing;
using QRCoder;

namespace NetCore_MVC.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {      
           	ViewBag.QrCodeUri = CreateQRCode("https://localhost:44341/");
			return View();
        } 

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}