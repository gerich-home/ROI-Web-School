namespace Crm.Admin.Models
{
<<<<<<< HEAD
	using Domain;
    using System.ComponentModel.DataAnnotations;

	public class NewUserModel : IUser
	{
		int IUser.Id { get { return 0; } }
=======
	using System;
	using System.ComponentModel.DataAnnotations;
	using Domain;

	[MetadataType(typeof(Domain.Metadata.User))]
	public class NewUserModel : IUser
	{
		private readonly NewPasswordModel _password = new NewPasswordModel();

		public string CancelUrl { get; set; }

		public int Id
		{
			get { return 0; }
			set { throw new NotSupportedException(); }
		}

>>>>>>> 7af9fb1ea3b1a3e81293ef60abbc90bb0747ed25
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Login { get; set; }

<<<<<<< HEAD
		private NewPasswordModel _password;

		[Display(Name = "Password")]
		public NewPasswordModel Password { get { return _password; } }

        public void Save()
		{
			ServiceFactory.Resolve<IUserService>().Create(this, Password.Password);
=======
		public NewPasswordModel Password
		{
			get { return _password; }
		}

        public void Save()
		{
			ServiceFactory.Resolve<IUserService>().Create(this, Password);
>>>>>>> 7af9fb1ea3b1a3e81293ef60abbc90bb0747ed25
		}
	}
}