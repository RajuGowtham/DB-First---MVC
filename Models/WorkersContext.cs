
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApplication.Models
{
    public class WorkersContext : DbContext
    {
        public DbSet<Workers> Workers { get; set; }

        public WorkersContext(DbContextOptions<WorkersContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=RAJU_GOWTHAM;database=practice;integrated security=true;trustservercertificate=true;");
        }
    }
}
