using AutoMapper;
using Concentrador_Scanntech_Repository.Interfaces;
using Concentrador_Scanntech_Repository.Repository;
using Ninject.Modules;

namespace Concentrador_Scanntech_IoC
{
    public class NinjectModuleConfig : NinjectModule
    {
        public override void Load()
        {
            Bind<IStatusBancoRepository>().To<StatusBancoRepository>();
            Bind<IDefinicoesRepository>().To<DefinicoesRepository>();
            Bind<IMapper>().To<Mapper>();   
        }
        public static NinjectModuleConfig Create()
        {
            return new NinjectModuleConfig();
        }
    }
}
