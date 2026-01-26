using SGF.Models;

namespace SGF.Interfaces.IRepository
{
    public interface IUserRepository : IDisposable
    {
        Task AddUser(UserModel user);
        Task<UserModel> GetUserByLogin (string login, string password);
        bool LoginExists(string login);
      

    }
}
