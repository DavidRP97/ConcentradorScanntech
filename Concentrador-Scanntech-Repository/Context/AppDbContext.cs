using Concentrador_Scanntech_Entities.Model.Definicoes;
using Concentrador_Scanntech_Entities.Model.Promocoes;
using Concentrador_Scanntech_Entities.Utils;
using Microsoft.EntityFrameworkCore;

namespace Concentrador_Scanntech_Repository.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            switch (StringDeConexao.Banco())
            {
                case BancoDeDados.MySQL:
                    optionsBuilder.UseMySql(StringDeConexao.Gerar(), ServerVersion.AutoDetect(StringDeConexao.Gerar()));
                    break;
                case BancoDeDados.PostgreSQL:
                    optionsBuilder.UseNpgsql(StringDeConexao.Gerar());
                    break;
                case BancoDeDados.SQLServer: 
                    optionsBuilder.UseSqlServer(StringDeConexao.Gerar());
                    break;
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<DefinicoesScanntech> DefinicoesScanntech { get; set; }
        public DbSet<URL> URLs { get; set; }

        public DbSet<BeneficioArtigoScanntech> BeneficioArtigoScanntech { get; set; }
        public DbSet<BeneficioItemScanntech> BeneficioItemScanntech { get; set; }
        public DbSet<BeneficioScanntech> BeneficioScanntech { get; set; }
        public DbSet<CondicaoArtigoScanntech> CondicaoArtigoScanntech { get; set; }
        public DbSet<CondicaoItemScanntech> CondicaoItemScanntech { get; set; }
        public DbSet<CondicaoScanntech> CondicaoScanntech { get; set; }
        public DbSet<DetalhesPromocaoScanntech> DetalhesPromocaoScanntech { get; set; }
        public DbSet<PromocaoScanntech> PromocoesScanntech { get; set; }

    }
}
