using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using eCommerce.Models;

namespace eCommerce.Controllers
{
    public class CatalogoController : Controller
    {
        private readonly CatalogoContext _dbContext;
        
        public CatalogoController(CatalogoContext dbContext){
            _dbContext = dbContext;
        }

        // Get: /Catalogo/Adicionar
        [HttpGet]
        public IActionResult Adicionar(int id)
        {
            Console.WriteLine("Teste id produto: {0}", id);
            
           /* id.id = _dbContext.Produtos.Count() + 1;
            _dbContext.Produtos.Add(id);
            _dbContext.SaveChanges();*/
            return new ObjectResult(id);
            
           // return View(model: selecionado);
        }
    }
}
