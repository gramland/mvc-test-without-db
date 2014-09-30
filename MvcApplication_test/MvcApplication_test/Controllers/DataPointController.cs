using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication_test.Controllers
{
    public class DataPointController : ApiController
    {
        // GET api/datapoint
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/datapoint/5
        public int Get(int id)
        {
            Random rnd = new Random();
            return rnd.Next(1000);
        }

        // POST api/datapoint
        public void Post([FromBody]string value)
        {
        }

        // PUT api/datapoint/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/datapoint/5
        public void Delete(int id)
        {
        }
    }
}
