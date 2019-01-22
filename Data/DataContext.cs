using Microsoft.EntityFrameworkCore;

namespace gust.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
    
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Runway> Runways { get; set; }
    }
}