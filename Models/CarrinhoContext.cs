using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;

namespace eCommerce.Models
{
	//public class ApplicationUser : IdentityUser {}
    public class CarrinhoContext : IdentityDbContext<ApplicationUser>
    {
		public DbSet<Produto> Carrinho { get; set; }
	}
}