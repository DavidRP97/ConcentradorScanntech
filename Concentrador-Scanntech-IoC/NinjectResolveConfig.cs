using Ninject;
using Ninject.Modules;
using Ninject.Parameters;

namespace Concentrador_Scanntech_IoC
{
    public class NinjectResolveConfig
    {
        private static IKernel _ninjectKernel;

        public static void Wire(INinjectModule module)
        {
            _ninjectKernel = new StandardKernel(module);
        }

        public static T Resolve<T>()
        {
            return _ninjectKernel.Get<T>();
        }
        public static T ResolveWithArgument<T>(ConstructorArgument argument)
        {
            return _ninjectKernel.Get<T>(argument);
        }
    }
}
