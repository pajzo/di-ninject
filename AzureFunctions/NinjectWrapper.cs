using Ninject;
using NinjectLibary;
using System;

namespace AzureFunctions
{
    public class NinjectWrapper : IDisposable
    {
        public StandardKernel Kernel;

        public NinjectWrapper()
        {
            Kernel = new StandardKernel();
            Kernel.Load<NinjectBindings>();
        }

        public void Dispose()
        {
            Kernel.Dispose();
        }
    }
}
