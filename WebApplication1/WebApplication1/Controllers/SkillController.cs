using Microsoft.AspNetCore.Mvc;

namespace SuperFolio.Controllers
{
    public class SkillController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
