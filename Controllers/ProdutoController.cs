using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using eCommerce.Models;

namespace eCommerce.Controllers
{
    public class ProdutoController : Controller
    {
     /*   private readonly CatalogoContext _dbContext;
        
        public CatalogoController(CatalogoContext dbContext){
            _dbContext = dbContext;
        }*/
        //
        // GET: /Produto/Detalhes
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Detalhes(int id)
        {
            Console.WriteLine("Teste produto: {0}", id);
            
            Banco b = new Banco();
            Catalogo c = b.lista();
            Produto selecionado = null;
            foreach (Produto p in c.lista)
            {
                if (p.id == id)
                {
                    selecionado = p;
                }
            }
            
            if (selecionado == null){
                selecionado = new Produto(0, "Produto inexistente", "Este produto não existe, por favor volte para a Home", 0);
            }
            
            return View(model: selecionado);
        }
        // GET: /Produto/CrudProduto
        [HttpGet]
        public IActionResult CrudProduto(){
            
            return View();
        }
        [HttpPost]
        public IActionResult NovoProduto(Produto id){
            Console.WriteLine("Novo produto {0}", id.nome);
            //return View("CrudProduto");
            return new ObjectResult(id);
        }
    }
    
}
