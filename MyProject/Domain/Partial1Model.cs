using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Partial1Model
    {
        public enum PhoneNrType : byte
        {
            Other, Mobile, Home, Work
        }
        public PhoneNrType PhoneType { get; set; }

        [Required, StringLength(32, MinimumLength = 1)]
        public string PhoneNr { get; set; }
    }
}
