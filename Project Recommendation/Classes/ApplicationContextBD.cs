using Microsoft.EntityFrameworkCore;

namespace DB_993.Classes
{
    public class ApplicationContextBD : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Realty> Realtys { get; set; } = null!;
        public DbSet<Recommendations> Recommendations { get; set; } = null!;
        public DbSet<Compilation> Compilations { get; set; } = null!;
        public DbSet<BlackListTable> BlackLists { get; set; } = null!;
        public DbSet<Favourites> Favourites { get; set; } = null!;

        public void ApplicationContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ProectDB2.db");
        }
    }
}
