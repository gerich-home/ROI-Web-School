using System.Data.Entity;
using Data1.Entities;

namespace Data1
{
    public class MyContext : DbContext, IMyContext
    {
		public IDbSet<User> Users { get; set; }
		public IDbSet<Client> Clients { get; set; }
		public IDbSet<Contact> Contacts { get; set; }
		public IDbSet<Operation> Operations { get; set; }

		public MyContext() { }

        public MyContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
     }
	}
}