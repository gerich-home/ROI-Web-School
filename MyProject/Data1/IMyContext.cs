using System;
using System.Data.Entity;
using Data1.Entities;

namespace Data1
{
    public interface IMyContext : IDisposable
	{
		IDbSet<User> Users { get; }
		IDbSet<Client> Clients { get; }
		IDbSet<Contact> Contacts { get; }
		IDbSet<Operation> Operations { get; }

		int SaveChanges();
	}
}