using AutoMapper;
using Concentrador_Scanntech_GUI.Configuracoes;
using Concentrador_Scanntech_GUI.Main;
using Concentrador_Scanntech_GUI.Sincronizador;
using Concentrador_Scanntech_Repository.Context;
using Concentrador_Scanntech_Repository.Interfaces;
using Concentrador_Scanntech_Repository.Repository;
using Concentrador_Scanntech_Repository.UoW;
using Microsoft.Extensions.DependencyInjection;

namespace Concentrador_Scanntech_GUI
{
    internal static class Program
    {
        public static IServiceProvider serviceProvider { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            Resolver(services);

            serviceProvider = services.BuildServiceProvider();

            try
            {
                DbContextMigration.EfMigration(new MySqlDbContext());
                var frm = serviceProvider.GetRequiredService<FrmMain>();
                Application.Run(frm);
            }
            catch
            {
                var frm = serviceProvider.GetRequiredService<FrmConfigurarBancoDeDados>();
                Application.Run(frm);
            }
        }
        private static void Resolver(ServiceCollection service)
        {
            IMapper mapper = ResolverMapeamento().CreateMapper();

            service.AddScoped<IUnitOfWork, UnitOfWork>().AddDbContext<MySqlDbContext>().AddSingleton(mapper);
            service.AddScoped<FrmMain>();
            service.AddTransient<FrmConfigurarBancoDeDados>();
            service.AddTransient<FrmDefinicoesScanntech>();
            service.AddTransient<FrmSincronizador>();
        }
        private static MapperConfiguration ResolverMapeamento()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {

            });

            return mappingConfig;
        }
    }
}