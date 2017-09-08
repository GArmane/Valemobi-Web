using Microsoft.EntityFrameworkCore;

namespace ValemobiWeb.Data
{
    public class Context : DbContext
    {
        public Context() { }
        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Host=localhost;Port=5432;" + 
                "Database=ValemobiWebDB;Pooling=true;User Id=postgres;" + 
                "Password=s123";
            optionsBuilder
                .UseNpgsql(connectionString);
        }
    }
}