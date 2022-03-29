using Concentrador_Scanntech_Entities.Model.Definicoes;
using Concentrador_Scanntech_Entities.Model.Promocoes;
using Microsoft.EntityFrameworkCore;

namespace Concentrador_Scanntech_Repository.Context
{
    public class MySqlDbContext : DbContext
    {
        private const string ConnectionStringPath = $"C:\\ConcentradorScanntech\\Conexao\\stringDeConexao.txt";
        private string ConnectionString()
        {
            if (File.Exists(ConnectionStringPath))
            {
                var path = File.ReadAllText(ConnectionStringPath); 

                return path;
            }
            return string.Empty;
        }        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConnectionString(), ServerVersion.AutoDetect(ConnectionString()));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Status>().HasData(new Status
            {
                StatusId = 1,
                StatusDoBanco = true
            });
        }

        public DbSet<DefinicoesScanntech> DefinicoesScanntech { get; set; }
        public DbSet<Status> StatusDoBanco { get; set; }
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
