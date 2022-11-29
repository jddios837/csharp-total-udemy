using Day19_LINQ_SQL.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Day19_LINQ_SQL.Data;

public class UniversityDbContext : DbContext
{
    public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<University> University { get; set; }
    
}