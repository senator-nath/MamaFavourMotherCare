using MamaFavourMotherCare.Model;
using Microsoft.EntityFrameworkCore;

namespace MamaFavourMotherCare.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}

