using Microsoft.EntityFrameworkCore;
using ValemobiWeb.Models;

namespace ValemobiWeb.Data
{
    public class Context : DbContext
    {
        public Context() { }
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Mercadoria> Mercadorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mercadoria>().ToTable("Mercadoria");
        }

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