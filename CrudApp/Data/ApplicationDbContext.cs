using CrudApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
