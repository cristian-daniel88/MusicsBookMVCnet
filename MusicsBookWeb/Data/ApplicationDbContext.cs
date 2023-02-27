using Microsoft.EntityFrameworkCore;
using MusicsBookWeb.Models;

namespace MusicsBookWeb.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }

        public DbSet<Category> Categories { get; set; }
       
    }
}
