using Microsoft.EntityFrameworkCore;
using RESTAPIASP.Models;

namespace RESTAPIASP.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<City> Cities { get; set; }
        public DbSet<AidFund> AidFunds { get; set; }
        public DbSet<Family> Families { get; set; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }*/

    }
}
