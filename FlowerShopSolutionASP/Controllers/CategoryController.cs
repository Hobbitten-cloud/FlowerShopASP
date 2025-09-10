using FlowerShopSolutionASP.Persistence.Repo;
using Microsoft.AspNetCore.Mvc;

namespace FlowerShopSolutionASP.Controllers
{
    public class CategoryController : Controller
    {
        FlowerRepo flowerRepo = new FlowerRepo();
        public IActionResult Index()
        {
            return View();
        }
    }
}
