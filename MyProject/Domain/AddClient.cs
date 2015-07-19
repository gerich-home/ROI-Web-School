using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class AddClient
    {
       public enum _type
       {
           home,
           mobile,
           work,
           other
           
       }
       [Required]
       public string FirstName { get; set; }
       [Required]
       public string LastName { get; set; }
       [Required]
       public DateTime DateOfBirth { get; set; }
       [Required]
       public string PhoneNumber { get; set; }
       [Required]
       public _type? TypeCall { get; set; }
    }
}
