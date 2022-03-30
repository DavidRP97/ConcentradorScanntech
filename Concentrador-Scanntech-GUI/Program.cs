using AutoMapper;
using Concentrador_Scanntech_Entities.Dtos.Promocoes;
using Concentrador_Scanntech_Entities.Model.Promocoes;
using Concentrador_Scanntech_GUI.Configuracoes;
using Concentrador_Scanntech_GUI.Main;
using Concentrador_Scanntech_GUI.Promocoes;
using Concentrador_Scanntech_GUI.Sincronizador;
using Concentrador_Scanntech_Repository.Context;
using Concentrador_Scanntech_Repository.Interfaces;
using Concentrador_Scanntech_Repository.Repository;
using Concentrador_Scanntech_Repository.UoW;
using Concentrador_Scanntech_Services.Interfaces;
using Concentrador_Scanntech_Services.Services;
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
                DbContextMigration.EfMigration(new AppDbContext());
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
            service.AddScoped<IUnitOfWork, UnitOfWork>().AddDbContext<AppDbContext>(); 
            service.AddSingleton(mapper);
            service.AddSingleton<HttpClient>();
            service.AddScoped<FrmMain>();
            service.AddScoped<IObterPromocoesService, ObterPromocoesService>();
            service.AddTransient<FrmConfigurarBancoDeDados>();
            service.AddTransient<FrmDefinicoesScanntech>();
            service.AddTransient<FrmSincronizador>();
            service.AddTransient<FrmPromocoesAtivasPdv>();
        }
        private static MapperConfiguration ResolverMapeamento()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<BeneficioArticuloDto, BeneficioArtigoScanntech>();
                config.CreateMap<BeneficioArtigoScanntech, BeneficioArticuloDto>();

                config.CreateMap<CondicaoArticuloDto, CondicaoArtigoScanntech>();
                config.CreateMap<CondicaoArtigoScanntech, CondicaoArticuloDto>();

                config.CreateMap<ResultDto, PromocaoScanntech>();
                config.CreateMap<PromocaoScanntech, ResultDto>();

                config.CreateMap<DetallesDto, DetalhesPromocaoScanntech>();
                config.CreateMap<DetalhesPromocaoScanntech, DetallesDto>();

                config.CreateMap<CondicionesDto, CondicaoScanntech>();
                config.CreateMap<CondicaoScanntech, CondicionesDto>();

                config.CreateMap<BeneficiosDto, BeneficioScanntech>();
                config.CreateMap<BeneficioScanntech, BeneficiosDto>();

                config.CreateMap<BeneficioItemDto, BeneficioItemScanntech>();
                config.CreateMap<BeneficioItemScanntech, BeneficioItemDto>();

                config.CreateMap<CondicaoItemDto, CondicaoItemScanntech>();
                config.CreateMap<CondicaoItemScanntech, CondicaoItemDto>();
            });

            return mappingConfig;
        }
    }
}