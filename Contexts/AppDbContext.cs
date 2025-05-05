using ClinicApp3.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicApp3.Contexts
{
    public class AppDbContext:DbContext
    {
        public DbSet<HealthCareSolution> HealthCareSolutions { get; set; }
        public AppDbContext(DbContextOptions options):base(options)
        {
            
        }
    }
}
