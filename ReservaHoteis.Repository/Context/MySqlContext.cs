using ReservaHoteis.Domain.Entities;
using ReservaHoteis.Repository.Mapping;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;


namespace ReservaHoteis.Repository.Context
{
    public sealed class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            Database.EnsureCreated();
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Hotel>? Hotel { get; set; }
        public DbSet<Cidade>? Cidade { get; set; }
        public DbSet<Cliente>? Cliente { get; set; }
        public DbSet<Contrato>? Contrato { get; set; }
        public DbSet<Avaliacao>? Avaliacao { get; set; }
        public DbSet<Usuario>? Usuario { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Hotel>(new HotelMap().Configure);
            modelBuilder.Entity<Cidade>(new CidadeMap().Configure);
            modelBuilder.Entity<Cliente>(new ClienteMap().Configure);
            modelBuilder.Entity<Contrato>(new ContratoMap().Configure);
            modelBuilder.Entity<Avaliacao>(new AvaliacaoMap().Configure);
            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);

        }
    }
}