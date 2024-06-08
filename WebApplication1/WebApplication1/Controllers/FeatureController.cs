using Microsoft.AspNetCore.Mvc;

namespace SuperFolio.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
