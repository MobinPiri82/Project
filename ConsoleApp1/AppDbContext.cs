            

using Microsoft.EntityFrameworkCore;

namespace Repo
{
    class AppDbContext : DbContext
    {
        public DbSet<Book> Books => Set<Book>();
        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<Product> Products => Set<Product>();

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "Data Source=.\\MOBIN;Database=MobinAppDb;Integrated Security=True;TrustServerCertificate=True");
        }
    }





    
}


