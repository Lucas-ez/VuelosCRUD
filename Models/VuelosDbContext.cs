using Microsoft.EntityFrameworkCore;

namespace VuelosCRUD.Models
{
  public class VuelosDbContext : DbContext
  {
    public VuelosDbContext(DbContextOptions<VuelosDbContext> options) : base(options) { }

    public DbSet<Vuelo> Vuelos { get; set; }
  }
}
