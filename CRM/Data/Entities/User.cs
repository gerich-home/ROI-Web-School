namespace Crm.Data.Entities
{
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
<<<<<<< HEAD

	[Table("Users")]
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, StringLength(64, MinimumLength = 1)]
        public string FirstName { get; set; }

        [Required, StringLength(128, MinimumLength = 1)]
        public string LastName { get; set; }

        [Required, StringLength(64, MinimumLength = 1)]
        public string Login { get; set; }

        [StringLength(16)]
        public string Password { get; set; }
    }
}
=======
	using System.Diagnostics;
	using Domain;

	[ComplexType, MetadataType(typeof(Domain.Metadata.UserPasswordHash))]
	public class Password : IUserPasswordHash
	{
		private byte[] _hash;

		[Column("Hash")]
		public byte[] Hash
		{
			get { return _hash; }
			set
			{
				Debug.Assert(value == null || value.Length == 20);
				_hash = value;
			}
		}
	}

	[Table("Users"), MetadataType(typeof(Domain.Metadata.User))]
    public class User : IUser
    {
		private Password _password = new Password();

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

		[Index(IsUnique = true)]
        public string Login { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

		public Password Password
		{
			get { return _password; }
			set { _password = value; }
		}
    }
}
>>>>>>> 7af9fb1ea3b1a3e81293ef60abbc90bb0747ed25
