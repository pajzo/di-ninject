using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Ninject;
using TestLibrary1;

namespace AzureFunctions
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            using (var ninject = new NinjectWrapper())
            {
                log.Info("C# HTTP trigger function processed a request.");

                var service = ninject.Kernel.Get<IMyRestService>();

                var list = service.GetList();

                


                return req.ReturnJson(list);

            }
        }
    }
}
