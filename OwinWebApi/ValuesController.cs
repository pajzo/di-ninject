using System.Collections.Generic;
using System.Web.Http;
using TestLibrary1;

namespace OwinWebApi
{
    [RoutePrefix("values")]
    public class ValuesController : ApiController
    {
        private IMyRestService myRestService;

        public ValuesController(IMyRestService myRestService)
        {
            this.myRestService = myRestService;
        }

        [HttpGet, Route("")]
        public IEnumerable<string> Get()
        {
            return myRestService.GetList();
        }

        [HttpGet, Route("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost, Route("")]
        public void Post([FromBody]string value)
        {
        }

        [HttpPut, Route("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete, Route("{id}")]
        public void Delete(int id)
        {
        }
    }
}