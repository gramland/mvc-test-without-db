using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MvcApplication_test.Models;

namespace MvcApplication_test
{
    public class ChangeStatusController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public int Put(int id, [FromBody]int status)
        {
            MachineContext machineContext = new MachineContext();
            Machines machine = machineContext.Machines.Single(mac => mac.id == id);

            if (machine == null) {
                return 2;
                // more than one indicates an error
            }


            machine.status = status;
            
            return status;


        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}