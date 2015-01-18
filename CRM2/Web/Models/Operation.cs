using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTrackerForX.Models
{

    public enum OperationType : byte
    {
        InitialCall, Callback, OfferRejected, OfferAccepted
    }

    public class Operation
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime Performed { get; set; }
        public OperationType Type { get; set; } 
        public DateTime? Callback { get; set; }
        public decimal? Amount { get; set; }
        public string Comment { get; set; }
        public virtual Client Client { get; set; }
    }
}