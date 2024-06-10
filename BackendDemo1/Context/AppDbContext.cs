using BackendDemo1.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendDemo1.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(
            DbContextOptions<AppDbContext> options) :
            base(options)
        {
            
        }
        DbSet<Person> Persons { get; set; }
    }
}
