using Concentrador_Scanntech_Entities.Model.Definicoes;
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

    }
}
