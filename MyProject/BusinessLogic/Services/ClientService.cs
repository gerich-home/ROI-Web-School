using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data1;
using Data1.Entities;
using Domain;

namespace BusinessLogic.Services
{
    [Service(ServiceOption.Singleton)]
    internal class ClientService:IClientService
    {

       public IEnumerable<IClient> GetAll()
        {
        using (var cont = MyContextFactory.Get())
        {
            var m = cont.Clients.Include(p => p.Operations).ToList();
            return m;
          }
        }
    }
}
