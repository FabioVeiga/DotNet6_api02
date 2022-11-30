using api02.Repositories;
using Microsoft.EntityFrameworkCore;

namespace api02.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) 
        => options.UseSqlServer("Server=localhost,1433;Database=Products;User Id=sa;Password=Sql@2022;TrustServerCertificate=true;");
    }
}