using Boggie_Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Boggie_Web.Data
{
    public class BoggieDbContext : DbContext
    {
        public BoggieDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<BoggiePost> BoggiePost { get; set; } 
        public DbSet<Tag> Tags { get; set; }
    }
}
