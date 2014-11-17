namespace Crm.Domain
{
	using System.Collections.Generic;

	public interface IUserService
    {
        void Create(IUser user, string password);
        IUser Read(int id);
        void Update(IUser user);
        void Delete(int id);
		void SetPassword(int id, string password);
<<<<<<< HEAD
=======
		IUser Authenticate(string login, string password);
>>>>>>> 7af9fb1ea3b1a3e81293ef60abbc90bb0747ed25
		IEnumerable<IUser> GetAll();
    }
}
