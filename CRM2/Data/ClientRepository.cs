using System.Collections.Generic;
using System.Data.Entity;
using System.Data;
using Crm.Data.Entities;

namespace Data
{
    public class ClientRepository
    {
        private readonly ClientAssistantContex _contex;

        public ClientRepository(ClientAssistantContex contex)
        {
            _contex = contex;
        }

        public IEnumerable<Client> GetAll()
        {
            return _contex.Clients;
        }

        public Client Get(int clientId)
        {
            return _contex.Clients.Find(clientId);
        }

        public void Add(Client client)
        {
            _contex.Clients.Add(client);
            _contex.SaveChanges();
        }

        public void Edit(Client client)
        {
            _contex.Entry(client).State = EntityState.Modified;
            _contex.SaveChanges();
        }

        public void Delete(int clientId)
        {
            var client = _contex.Clients.Find(clientId);
            if (client != null)
            {
                _contex.Clients.Remove(client);
                _contex.SaveChanges();
            }
        }
    }
}
