using Microsoft.AspNetCore.Mvc;

namespace FlowerShopSolutionASP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
