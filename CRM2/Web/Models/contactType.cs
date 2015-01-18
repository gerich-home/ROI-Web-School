using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTrackerForX.Models
{
    public enum PhoneNrType : byte
    {
        Other, Mobile, Home, Work
    }

    public class contactType
    {
        public int contactTypeId { get; set; }
        public ICollection<PhoneNrType> Title { get; set; }
    }
}