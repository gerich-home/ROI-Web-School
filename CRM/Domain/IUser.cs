namespace Crm.Domain
{
<<<<<<< HEAD
    public interface IUser
    {
        int Id { get; }
        string FirstName { get; }
        string LastName { get; }
        string Login { get; }
    }
}
=======
	public interface IUserLogin
	{
        string Login { get; }
	}

	public interface IUserPasswordHash
	{
		byte[] Hash { get; }
	}

	public interface IUser : IUserLogin
    {
		int Id { get; }
		string FirstName { get; }
		string LastName { get; }
    }
}
>>>>>>> 7af9fb1ea3b1a3e81293ef60abbc90bb0747ed25
