using System.Collections.Generic;
using Microsoft.Data.Entity;

namespace eCommerce.Models
{
    public class Catalogo:DbContext
    {
        public List<Produto> lista = new List<Produto> ();
        
    }
}