using System.Collections.Generic;

namespace eCommerce.Models
{
    public class Carrinho
    {
        public List<ItemCarrinho> lista {get; set; }
        private double _total;
        public double total {
            get{
                _total = 0;
                foreach (ItemCarrinho p in lista){
                    _total += p.preco;
                }
                return _total;
            }
            set{_total = value;}
        }
        
        public Carrinho(){
            lista = new List<ItemCarrinho>();
        }
        
    }
}