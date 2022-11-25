using Day16_Blazor.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Day16_Blazor.Data;

public class ZooDbContext : DbContext
{
    public DbSet<Zoo> Zoos { get; set; }
    public DbSet<Animal> Animals { get; set; }
    
    public ZooDbContext(DbContextOptions<ZooDbContext> options) : base(options) 
    {
        
    }
}