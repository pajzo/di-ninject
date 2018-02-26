using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Text;

namespace AzureFunctions
{
    public static class HttpExtensions
    {
        public static HttpResponseMessage ReturnJson<T>(this HttpRequestMessage request, T o)
        {
            return request.ReturnJson(o, HttpStatusCode.OK);
        }

        public static HttpResponseMessage ReturnJson<T>(this HttpRequestMessage request, T o, HttpStatusCode statusCode)
        {
            var json = JsonConvert.SerializeObject(o);

            var response = new HttpResponseMessage(statusCode)
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            return response;
        }
    }
}
