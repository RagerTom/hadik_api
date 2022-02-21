using Microsoft.EntityFrameworkCore;

namespace hadik_api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
  
        public DbSet<Hadik> HadikSavedData { get; set; }

        public DbSet<HadikParts> HadikSavedParts { get; set; }
    }
}
