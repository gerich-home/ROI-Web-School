using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTrackerForX.Models
{
    public class Client
    {
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public DateTime DataOfBirth { set; get; }
        public virtual ICollection<Operation> Operations { get; set; }
    }
}