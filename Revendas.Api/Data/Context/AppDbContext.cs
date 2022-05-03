using Microsoft.EntityFrameworkCore;
using Revendas.Api.Models;

namespace Revendas.Api.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }
        public DbSet<Revenda> Revenda { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Revenda>().HasKey(p => p.Id);
            builder.Entity<Revenda>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Revenda>().Property(p => p.Nome).IsRequired().HasMaxLength(200);
            builder.Entity<Revenda>().Property(p => p.CNPJ).IsRequired().HasMaxLength(14);
            builder.Entity<Revenda>().Property(p => p.Saldo).IsRequired();
        }
    }
}
