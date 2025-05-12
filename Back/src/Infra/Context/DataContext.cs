using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infra.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Revenda> revendas { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //   modelBuilder.Entity<Revenda>().HasKey(key  => key.Id, );
        //}

    }
}
