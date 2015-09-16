using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using eCommerce.Models;

namespace eCommerce.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Banco b = new Banco();
            Catalogo c = b.lista();
            ViewData["Lista"] = c;
            return View(c);
        }
        public IActionResult Teste()
        {
            return View();
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
