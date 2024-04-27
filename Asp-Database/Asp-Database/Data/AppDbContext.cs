using Asp_Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Asp_Database.Data
{
    public class AppDbContext : DbContext
    {
       public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
       { 

       }

        public DbSet<Slider> Sliders { get; set; }

    }
}
