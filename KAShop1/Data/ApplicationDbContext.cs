using Microsoft.EntityFrameworkCore;

namespace KAShop1.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=Mvc13;TrustServerCertificate=True;Trusted_Connection=True");
        }
    }
}
