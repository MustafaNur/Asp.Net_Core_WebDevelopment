﻿using Microsoft.AspNetCore.Mvc;

namespace SuperFolio.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }
    }
}
