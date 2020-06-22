using EstacaoRecargaDDD.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstacaoRecargaDDD.Infra.Dados.Config
{
    public class EstacaoRecargaDbContext : DbContext
    {
        public DbSet<EstacaoRecarga> Estacoes { get; set; }

        public EstacaoRecargaDbContext()
        {

        }

        public EstacaoRecargaDbContext(DbContextOptions<EstacaoRecargaDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(GetConnectionString());

            base.OnConfiguring(optionsBuilder);
        }

        private string GetConnectionString()
        {
            return "Server=(localdb)\\MSSQLLocalDB;" +
                   "Database=EstacaoRecargaDDD;" +
                   "Trusted_Connection=True;" +
                   "MultipleActiveResultSets=True;";
        }
    }
}
