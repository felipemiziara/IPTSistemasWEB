using eCommerce.Models;
using Microsoft.AspNet.Mvc;

namespace eCommerce.Controllers
{
    public class CarrinhoController : Controller
    {
        private readonly CarrinhoContext _dbContext;
        private static Carrinho carrinho = new Carrinho();
        public CarrinhoController(CarrinhoContext dbContext){
            _dbContext = dbContext;
        }

        // Get: /Carrinho/Adicionar
        [HttpGet]
        public IActionResult Adicionar(string nome, string preco){
            double _preco = double.Parse(preco);
            ItemCarrinho i = new ItemCarrinho();
            i.nomeProduto = nome;
            i.preco = _preco;
            carrinho.lista.Add(i);
            return new ObjectResult(carrinho);
		}
	}
}