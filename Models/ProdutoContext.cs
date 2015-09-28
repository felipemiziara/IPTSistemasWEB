using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;

namespace eCommerce.Models
{
	//public class ApplicationUser : IdentityUser {}
    public class ProdutoContext : IdentityDbContext<ApplicationUser>
    {
		public DbSet<Produto> Produtos { get; set; }
	}
}