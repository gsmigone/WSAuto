using Microsoft.EntityFrameworkCore;
using WSAuto.Models;

namespace WSAuto.Data
{
    public class AutoContext : DbContext
    {
        public AutoContext() { }

        public AutoContext(DbContextOptions<AutoContext> options) : base(options) { }

        public virtual DbSet<Auto> Autos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Auto>().ToTable("Vehiculo");

            modelBuilder.Entity<Auto>().Property(e => e.Marca).IsRequired().HasColumnType("varchar(50)");
            modelBuilder.Entity<Auto>().Property(e => e.Modelo).IsRequired().HasColumnType("varchar(50)");
            modelBuilder.Entity<Auto>().Property(e => e.Color).IsRequired().HasColumnType("varchar(50)");
            modelBuilder.Entity<Auto>().Property(e => e.Precio).IsRequired().HasColumnType("money");

        }
    }
}
