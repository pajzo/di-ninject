using System.Collections.Generic;

namespace TestLibrary1
{
    public class MyRestServiceNew : IMyRestService
    {
        private ILogger logger;
        private string host;

        public MyRestServiceNew(ILogger logger, string host)
        {
            this.logger = logger;
            this.host = host;
        }

        public List<string> GetList()
        {
            logger.Log("Requested NEW GetList() in " + host);

            return new List<string>
            {
                host + " New Value 1",
                host + " New Value 2"
            };
        }
    }
}
