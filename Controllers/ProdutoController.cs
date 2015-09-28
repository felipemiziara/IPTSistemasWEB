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
        private readonly CatalogoContext _dbContext;
        
        public ProdutoController(CatalogoContext dbContext){
         _dbContext = dbContext;
        }
        // GET: /Produto/Detalhes
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Detalhes(int id)
        {
            Console.WriteLine("Teste produto: {0}", id);
            
            Catalogo c = new Catalogo();
            c.lista = _dbContext.Produtos.ToList();
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
            Console.WriteLine("Produto editando {0}", id.id);
            if(id != null && id.id == 0){
                id.id=_dbContext.Produtos.Count()+1;            
                _dbContext.Add(id);        
            }else if (id != null){
                _dbContext.Update(id);
            }
            if(id != null){
                _dbContext.SaveChanges();    
            }            
            Catalogo c = new Catalogo();
            c.lista = _dbContext.Produtos.ToList();
            return View(c);
        }
        [HttpGet]
        public IActionResult EditProduto(int id){
            Produto editar = null;
           foreach (Produto p in _dbContext.Produtos.ToList()){
               if(p.id == id){
                   editar = p;
               }
           }
            return View("CrudProduto", editar);
        }
        public IActionResult ListaProduto(){
            Catalogo c = new Catalogo();
            c.lista = _dbContext.Produtos.ToList();
            return View("NovoProduto", c);
        }
        
        public IActionResult DeletaProduto(Produto id){
            _dbContext.Remove(id);         
            _dbContext.SaveChanges();   
            Catalogo c = new Catalogo();
            c.lista = _dbContext.Produtos.ToList();            
            return View("NovoProduto", c);
        }
    }
    
}
