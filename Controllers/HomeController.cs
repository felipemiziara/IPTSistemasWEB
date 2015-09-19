using System.Linq;
using Microsoft.AspNet.Mvc;
using eCommerce.Models;

namespace eCommerce.Controllers
{
    //[Route("api/[controller]")]
    public class HomeController : Controller
    {
        private readonly CatalogoContext _dbContext;
 
        public HomeController(CatalogoContext dbContext) 
        {
            _dbContext = dbContext;
        }
 
        public IActionResult Index()
        {
            Catalogo c = new Catalogo();
            c.lista = _dbContext.Produtos.ToList();
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
