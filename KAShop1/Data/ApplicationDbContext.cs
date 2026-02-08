using KAShop1.Models;
using Microsoft.EntityFrameworkCore;

namespace KAShop1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);


            //optionsBuilder.UseSqlServer("Server=.;Database=Mvc13;TrustServerCertificate=True;Trusted_Connection=True");
            optionsBuilder.UseSqlServer("Server=db38648.public.databaseasp.net; Database=db38648; User Id=db38648; Password=R-b65jC=Q3%g; Encrypt=True; TrustServerCertificate=True; MultipleActiveResultSets=True;");
        }
    }
}
