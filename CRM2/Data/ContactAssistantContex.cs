
using Crm.Data.Entities;
using Data;
using System.Data.Entity;
namespace Data
{
    public class ContactAssistantContex : DbContext
    {
        public ContactAssistantContex(string connectionStringName): base(connectionStringName)
        {
        }

        public DbSet<Contact> Contacts { set; get; }
    }
}
