using BugTrackerForX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Crm.Controllers
{
    public class ClientController : ApiController
    {
        private readonly ClientRepository _clientRepository = new ClientRepository(new ClientAssistantContex("DefaultConnectionString"));
        // GET api/client
        public IEnumerable<Client> Get()
        {
            return _clientRepository.GetAll();
        }

        // GET api/client/5
        public Client Get(int id)
        {
            return _clientRepository.Get(id);
        }

        // POST api/client
        public void Post([FromBody]Client client)
        {
            _clientRepository.Add(client);
        }

        // PUT api/client/5
        public void Put(int id, [FromBody]Client client)
        {
            if (id == client.Id)
            {
                _clientRepository.Edit(client);
            }
        }

        // DELETE api/client/5
        public void Delete(int id)
        {
            _clientRepository.Delete(id);
        }
    }
}
