            

using Microsoft.EntityFrameworkCore;

namespace Repo
{
    class AppDbContext : DbContext
    {
        public DbSet<Book> Books => Set<Book>();
        public DbSet<Customer> Customers => Set<Customer>();

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "Data Source=.\\MOBIN;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}

