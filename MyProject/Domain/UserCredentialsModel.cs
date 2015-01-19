using System.ComponentModel.DataAnnotations;
using Domain.Metadata;

namespace Domain
{
    [MetadataType(typeof(UserLogin))]
    public class UserCredentialsModel : IUserLogin
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
