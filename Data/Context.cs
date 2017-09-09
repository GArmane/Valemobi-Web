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
            var connectionString = "Host=valemobiweb-db.postgres.database.azure.com;Port=5432;Database=valemobiweb-db;Pooling=true;User Id=valemobi@valemobiweb-db;Password=VM2017webapp";
            optionsBuilder
                .UseNpgsql(connectionString);
        }
    }
}