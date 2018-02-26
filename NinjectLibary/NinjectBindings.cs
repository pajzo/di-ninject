using ConfigLibary;
using Ninject.Modules;
using TestLibrary1;

namespace NinjectLibary
{
    public class NinjectBindings : NinjectModule
    {
        public override void Load()
        {
            var config = ConfigReader.Read();

            Bind<IMyRestService>().To<MyRestServiceNew>().WithConstructorArgument("host", config.Host);
            Bind<ILogger>().To<DebugLogger>();
        }
    }
}
