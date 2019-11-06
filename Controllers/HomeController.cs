// using System;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IronNinja.Models;

namespace IronNinja.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Home() {
            return View();
        }

        [Route("create")]
        [HttpPost]
        public IActionResult Create(Hero hero) {
            if (ModelState.IsValid) {
                return RedirectToAction("Fight");
            }
            else {
                return View("Home");
            }
        }

    }
}
