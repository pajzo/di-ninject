using System.Collections.Generic;

namespace TestLibrary1
{
    public class MyRestService : IMyRestService
    {
        private ILogger logger;
        private string host;

        public MyRestService(ILogger logger, string host)
        {
            this.logger = logger;
            this.host = host;
        }

        public List<string> GetList()
        {
            logger.Log("Requested GetList() in " + host);

            return new List<string>
            {
                host + " Value 1",
                host + " Value 2"
            };
        }
    }
}
