using System.ComponentModel.DataAnnotations;

namespace Domain.Metadata
{
    public abstract class UserLogin : IUserLogin
    {
        [Required, StringLength(32)]
        public abstract string Login { get; }
    }

    public abstract class UserPasswordHash : IUserPasswordHash
    {
        [MinLength(5), MaxLength(20)]
        public abstract byte[] Hash { get; }
    }

    public abstract class User : UserLogin, IUser
    {
        public abstract int Id { get; }

        [StringLength(128)]
        public abstract string FirstName { get; }

        [StringLength(128)]
        public abstract string LastName { get; }

      }
}
