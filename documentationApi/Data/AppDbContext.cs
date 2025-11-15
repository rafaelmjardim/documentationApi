using documentationApi.Models;
using Microsoft.EntityFrameworkCore;

namespace documentationApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Documentation> Documentations => Set<Documentation>();

    }
}
