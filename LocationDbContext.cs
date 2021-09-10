using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AspDotNet6
{
  public class LocationDbContext : DbContext
  {
    public LocationDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Location> Locations { get; set; }
  }

  public class Location
  {
    public int Id { get; set; }
    public string Name { get; set; }
  }
}