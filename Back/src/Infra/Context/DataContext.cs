using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infra.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Revenda> Revendas { get; set; }
        public DbSet<Ordem> ordens { get; set; }


    }
}
