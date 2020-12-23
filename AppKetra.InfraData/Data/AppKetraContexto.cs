using AppKetra.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace AppKetraInfraData.Contexto
{
    public class AppKetraContexto : DbContext
    {
        public AppKetraContexto(DbContextOptions<AppKetraContexto> options) 
        : base(options)
        {
        }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Status> statuss { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fornecedor>().ToTable("SA2");
            modelBuilder.Entity<Pedido>().ToTable("SC7");
            modelBuilder.Entity<Produto>().ToTable("SB1");
            modelBuilder.Entity<Status>().ToTable("SCR");

        }

        //{
        //    "Server=(localdb)\MSSQLLocalDB;Database=AppKetra1;Trusted_Connection=True;MultipleActiveResultSets=true;");
        //}
    }
}
