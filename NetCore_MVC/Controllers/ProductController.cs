using Microsoft.AspNetCore.Mvc;
using NetCore_Model.Models;

namespace NetCore_MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly PimvContext _ctx;
             
        public ProductController(PimvContext ctx)
        {
            _ctx = ctx;
        }

        public IActionResult Index()
        {
			try
			{
                var users = _ctx.Mmcvusers.ToList();
                Console.WriteLine(users.Count);
                return View();
            }
			catch (Exception ex)
			{
				throw ex;
			}

        }
    }
}
