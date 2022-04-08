using Microsoft.EntityFrameworkCore;
using RazorPizzeria.Models;

namespace RazorPizzeria.Data
{
    public class ApplicationDbContext : DbContext
    {
		public DbSet<PizzaOrder> PizzaOrders { get; set; }

		// base() calls the constructor of the class we inherit from, which we very much need to do in this case
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
		{

		}
	}
}
