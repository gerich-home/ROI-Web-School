using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain;

namespace Data1.Entities
{
    
    public class Client:IClient
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, StringLength(64, MinimumLength = 1)]
        public string FirstName { get; set; }

        [Required, StringLength(128, MinimumLength = 1)]
        public string LastName { get; set; }

        [Required, Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }

        
        public virtual Contact Contacts { get; set; }

        
        public virtual Operation Operations { get; set; }
    }
}
