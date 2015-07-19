using System;
using Domain.Metadata;

namespace Domain
{
    public interface IClient
    {
        int Id { get; }
        string FirstName { get; }
        string LastName { get; }
        DateTime DateOfBirth { get; set; }
      
    }
}
