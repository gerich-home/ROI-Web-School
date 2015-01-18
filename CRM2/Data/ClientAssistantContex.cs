using System.Data.Entity;
using Crm.Data.Entities;

namespace Data
{
    public class ClientAssistantContex : DbContext
    {
        public ClientAssistantContex(string connectionStringName):base(connectionStringName)
        {
        }

        public DbSet<Client> Clients { set; get; }
    }
}