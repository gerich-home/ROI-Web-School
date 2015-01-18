using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTrackerForX.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public virtual contactType PhoneType { get; set; }
        public string PhoneNr { get; set; }
        public virtual Client Client { get; set; }
    }
}