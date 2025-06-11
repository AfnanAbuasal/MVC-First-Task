using Microsoft.EntityFrameworkCore;
using MVC_Task1.Models;

namespace MVC_Task1.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=IMPLUTOGAL;Database=MVC_Task1;Trusted_Connection=True;TrustServerCertificate = True");
        }
    }
}
