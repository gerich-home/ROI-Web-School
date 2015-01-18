using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Crm.Controllers
{
     public class HomeAssistantController : Controller
    {
        // GET api/HomeAssistant
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/HomeAssistant/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/HomeAssistant
        public void Post([FromBody]string value)
        {
        }

        // PUT api/HomeAssistant/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/HomeAssistant/5
        public void Delete(int id)
        {
        }
    }
}
