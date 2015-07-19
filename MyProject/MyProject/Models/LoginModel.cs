using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessLogic;

namespace MyProject.Models
{
    using System.ComponentModel.DataAnnotations;
    using Domain;

    public class LoginModel
    {
        [Required]
        public string Login { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool Remember { get; set; }

        public UserModel Logon()
        {
            var user = ServiceFactory.Resolve<IUserService>().Authenticate(Login, Password);
            return user != null ? new UserModel(user) : null;
        }
    }
}