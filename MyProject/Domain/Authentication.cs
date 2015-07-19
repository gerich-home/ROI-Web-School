using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class Authentication
    {
        [Required(ErrorMessage = "This field is required")]
        public string Login { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Password { get; set; }
    }
}
