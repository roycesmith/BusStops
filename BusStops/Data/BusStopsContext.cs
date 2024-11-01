
using Microsoft.EntityFrameworkCore;
using BusStops.Models;
namespace BusStops.Data;

public class BusStopsContext : DbContext
{
    public BusStopsContext(DbContextOptions<BusStopsContext> options)
        : base(options)
    {
    }
    public DbSet<Shelter> Shelter => Set<Shelter>();
}
