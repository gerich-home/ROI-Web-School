using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Registration:IUser 

{   
    public int Id { get; set; }

    [Required(ErrorMessage = "This field is required")]
    public string FirstName { get; set; }

     [Required(ErrorMessage = "This field is required")]
    public string LastName { get; set; }

     [Required(ErrorMessage = "This field is required")]
    public string Login { get; set; }

    [Required(ErrorMessage = "This field is required")]
    public string Password { get; set; }
}
}
